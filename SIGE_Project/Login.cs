
using DevExpress.XtraEditors;
using SIGE_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SIGE_Project
{
    public partial class LOGIN : DevExpress.XtraEditors.XtraForm
    {
        bool cons;
        
        Utilerias util = new Utilerias();
        //string tipoUser;

        global::System.Text.UTF8Encoding ue = new global::System.Text.UTF8Encoding();
        string Encrypted = "";
        string Desencrypted = "";
        public LOGIN()
        {
            InitializeComponent();
           
            if (Settings.Default.recordarme.Contains("1"))
            {
                textBox_user.Text = Settings.Default.usuario;
                textBox_password.Text = Settings.Default.passw;
                checkEdit_recordar.Checked = true;
            }
            
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            ingresar();
        }
        public void ingresar()
        {
            if (textBox_user.Text == "")
            {
                textBox_user.Focus();
                //textBox_user.Text = "Ingrese un usuario";
                XtraMessageBox.Show("Ingrese un usuario.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (textBox_password.Text == "")
                {
                    textBox_password.Focus();
                    //textBox_password.Text = "Ingrese una contraseña";
                    XtraMessageBox.Show("Ingrese una constraseña", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);




                }
                else
                {
                    string functionReturnValue = null;
                    string user = textBox_user.Text;
                    string pass = textBox_password.Text;
                    string en = Encriptar(pass);

                    //se evalua que el usuario y contraseña sean correctas
                    cons = util.Consultar1("PV_tblUsuarios", "cuenta_usuario", user.ToUpper(), "contrasenia", en);

                    if (cons)
                    {
                        //se obtienen los datos del usuario
                        DataSet ds = new DataSet();
                        string CONSULTA = "select*from PV_tblUsuarios where cuenta_usuario='" + user.ToUpper()+"'";
                        ds = util.ejecutarQueryDataset("datosUser", CONSULTA);
                        DataTable dt = ds.Tables[0];
                        //variables.idUser = Convert.ToInt32(dt.Rows[0]["id_usuario"].ToString());
                        variables.nombreCompleto = Convert.ToString(dt.Rows[0]["nombreUsuario"].ToString());
                        variables.varUser = Convert.ToString(dt.Rows[0]["cuenta_usuario"].ToString());
                        variables.tipoUser = Convert.ToString(dt.Rows[0]["tipoUsuario"].ToString());
                        //variables.esVendedor = Convert.ToInt32(dt.Rows[0]["esVendedor"].ToString());
                        
                        if (checkEdit_recordar.Checked)
                        {
                            Settings.Default.usuario = textBox_user.Text;
                            Settings.Default.passw = textBox_password.Text;
                            Settings.Default.recordarme = "1";
                            Settings.Default.Save();
                        }
                        else
                        {
                            Settings.Default.usuario = "Usuario";
                            Settings.Default.passw = "Constraseña";
                            Settings.Default.recordarme = "";
                            Settings.Default.Save();

                        }
                        //splashScreenManager3.ShowWaitForm();
                        MenuPrincipal p = new MenuPrincipal();
                        //splashScreenManager3.CloseWaitForm();

                        p.Show();
                        this.Close();

                    }
                    else
                    {
                        ///label3.Visible = true;
                        XtraMessageBox.Show("Usuario y/o constraseña incorrectos.", "Credenciales incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //textBox_user.Text = "";
                        textBox_user.Focus();
                        textBox_password.Text = "";
                    }

                }
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox_user.Text = "";
            textBox_user.ForeColor = Color.Black;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox_password.Text = "";
            textBox_password.ForeColor = Color.Black;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '*';
            textBox_password.ForeColor = Color.Black;
        }
        public string Encriptar(string EncriptString)
        {
            string functionReturnValue = null;
            if (string.IsNullOrEmpty(EncriptString))
            {
                return null;
                return functionReturnValue;
            }
            try
            {
                byte[] IV = ASCIIEncoding.ASCII.GetBytes("qualityi");
                //La clave debe ser de 8 caracteres  
                byte[] EncryptionKey = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5");
                //No se puede alterar la cantidad de caracteres pero si la clave  
                byte[] buffer = Encoding.UTF8.GetBytes(EncriptString);
                TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
                des.Key = EncryptionKey;
                des.IV = IV;


                return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length));
            }
            catch (Exception exc)
            {
                //Interaction.MsgBox("Un error ha ocurrido en la encriptación.");
            }
            return Encrypted;
            return functionReturnValue;

        }
        public string Desencriptar(string TextEncripted)
        {
            string functionReturnValue = null;
            if (string.IsNullOrEmpty(TextEncripted))
            {
                return null;
                return functionReturnValue;
            }
            try
            {
                byte[] IV = ASCIIEncoding.ASCII.GetBytes("qualityi");
                //La clave debe ser de 8 caracteres  
                byte[] EncryptionKey = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5");
                //No se puede alterar la cantidad de caracteres pero si la clave  
                byte[] buffer = Convert.FromBase64String(TextEncripted);
                TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
                des.Key = EncryptionKey;
                des.IV = IV;
                return Encoding.UTF8.GetString(des.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length));


            }
            catch (Exception exc)
            {
                //	Interaction.MsgBox("Un error ha ocurrido en la desencriptación.");
            }
            return Desencrypted;
            return functionReturnValue;

        }

        private void textBox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ingresar();

            }
        }

        private void textBox_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ingresar();

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
       

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            //if(variables.primera==0)
            //{
            //    for (int i = 0; i < 100; i++)
            //    {

            //        Thread.Sleep(100);
            //    }
            //}
           

            //LongInitialization();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cambiarConexiónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {

            Configuraciones.configInicial obj = new Configuraciones.configInicial();
            obj.ShowDialog();
        }
        //SplashScreen1 spla = new SplashScreen1();
        //protected void LongInitialization()
        //{
        //    BaseInitialization();
        //    LoadFonts();
        //    LoadTextures();
        //}

        //void BaseInitialization()
        //{
        //    // Set progress stage to be displayed by SplashImagePainter
        //    //SplashImagePainter.Painter.ViewInfo.Stage = "c";
        //    spla.labelControl2.Text = "Inicializando aplicación";
        //    for (int i = 1; i <= 100; i++)
        //    {
        //        System.Threading.Thread.Sleep(20);

        //        //// Change progress to be displayed by SplashImagePainter
        //        //SplashImagePainter.Painter.ViewInfo.Counter = i;
        //        ////Force SplashImagePainter to repaint information
        //        //SplashScreenManager.Default.Invalidate();

        //    }
        //}
        //void LoadFonts()
        //{
        //    // Set progress stage to be displayed by SplashImagePainter
        //    //SplashImagePainter.Painter.ViewInfo.Stage = "Actualizando archivos";
        //    spla.labelControl2.Text = "Actualizando archivos";
        //    for (int i = 1; i <= 100; i++)
        //    {
        //        System.Threading.Thread.Sleep(20);

        //        // Change progress to be displayed by SplashImagePainter
        //        //SplashImagePainter.Painter.ViewInfo.Counter = i;
        //        //Force SplashImagePainter to repaint information
        //       // SplashScreenManager.Default.Invalidate();
        //    }
        //}
        //void LoadTextures()
        //{
        //    // Set progress stage to be displayed by SplashImagePainter
        //    //SplashImagePainter.Painter.ViewInfo.Stage = "Cargando base de datos";
        //    spla.labelControl2.Text = "Cargando base de datoss";

        //    for (int i = 1; i <= 100; i++)
        //    {
        //        System.Threading.Thread.Sleep(20);

        //        // Change progress to be displayed by SplashImagePainter
        //        //SplashImagePainter.Painter.ViewInfo.Counter = i;
        //        //Force SplashImagePainter to repaint information
        //        //SplashScreenManager.Default.Invalidate();
        //    }
        //}
    }
}
