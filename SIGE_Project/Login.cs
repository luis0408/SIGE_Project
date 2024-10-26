
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using SIGE_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SIGE_Project
{
    public partial class LOGIN : DevExpress.XtraEditors.XtraForm
    {
        

       // global::System.Text.UTF8Encoding ue = new global::System.Text.UTF8Encoding();

        // //Variable para la encriptacion
        string Encrypted = "";
        string Desencrypted = "";
        
         
        public LOGIN()
        {
            InitializeComponent();

            
            // //Si esta la configuracion de recordar se colocan los valores guardados
            if (Settings.Default.recordarme.Contains("1"))
            {
                textBox_user.Text = Settings.Default.usuario;
                textBox_password.Text = Settings.Default.passw;
                checkEdit_recordar.Checked = true;
            }
            
        }
        SplashLoadInicial objSplash= new SplashLoadInicial();

        void BaseInitialization()
        {
            // Set progress stage to be displayed by SplashImagePainter

            //SplashImagePainter.Painter.ViewInfo.Stage = "Inicializando aplicación";
            objSplash.labelStatus.Text = "Inicializando aplicación...";
            for (int i = 1; i <= 100; i++)
            {
                System.Threading.Thread.Sleep(20);

                // Change progress to be displayed by SplashImagePainter
                //SplashImagePainter.Painter.ViewInfo.Counter = i;
                //objSplash.labelStatus.Text +=i.ToString()+ "%";

                //Force SplashImagePainter to repaint information
                //objSplash.Default.Invalidate();

            }
        }
        void LoadFonts()
        {
            // Set progress stage to be displayed by SplashImagePainter
            //SplashImagePainter.Painter.ViewInfo.Stage = "Actualizando archivos";
            objSplash.labelStatus.Text = "Actualizando archivos...";

            for (int i = 1; i <= 100; i++)
            {
                System.Threading.Thread.Sleep(20);

                // Change progress to be displayed by SplashImagePainter
                //SplashImagePainter.Painter.ViewInfo.Counter = i;
                //objSplash.labelStatus.Text += i.ToString() + "%";

                //Force SplashImagePainter to repaint information
                //SplashScreenManager.Default.Invalidate();
            }
        }
        void LoadTextures()
        {
            // Set progress stage to be displayed by SplashImagePainter
            //SplashImagePainter.Painter.ViewInfo.Stage = "Cargando base de datos";
            objSplash.labelStatus.Text = "Cargando base de datos...";

            for (int i = 1; i <= 100; i++)
            {
                System.Threading.Thread.Sleep(20);

                // Change progress to be displayed by SplashImagePainter
                //objSplash.labelStatus.Text += i.ToString() + "%";
                //Force SplashImagePainter to repaint information
                //SplashScreenManager.Default.Invalidate();
            }
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            ingresar();
        }
        public void ingresar()
        {
            // //Se validan los campos llenos correctamente
            if (string.IsNullOrEmpty(textBox_user.Text))
            {
                textBox_user.Focus();
                XtraMessageBox.Show("Ingrese un usuario.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (string.IsNullOrEmpty(textBox_password.Text))
            {
                textBox_password.Focus();
                XtraMessageBox.Show("Ingrese una constraseña", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    string usuario = textBox_user.Text;
                    string constrsenia = textBox_password.Text;
                    string constrseniaEncriptada = Encriptar(constrsenia);

                    //se evalua que el usuario y contraseña sean correctas
                    object[] datos = { usuario, constrseniaEncriptada };
                    string[] parametors = { "@usuario", "@constrasenia" };
                    DataSet ds = new DataSet();
                    ds = Utilerias.consultarProcedimiento("SIGE_CONSULTAR_DATOSLOGIN", datos, parametors);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DataTable dt = ds.Tables[0];
                        int estadoUsuario = Convert.ToInt32(dt.Rows[0]["estadoUser"]);
                        if (estadoUsuario == 0)/////Se valida el estado del usuario ingresado
                        {
                            XtraMessageBox.Show("El usuario ingresado se encuentra inactivo, contacte al departamento de sistemas.", "Usuario inactivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        ////Se asignan los valores de la tabla a las variables publicas
                        variables.nombreCompleto = dt.Rows[0]["nombreCompleto"].ToString();
                        variables.varUser = dt.Rows[0]["cuentaUsuario"].ToString();
                        variables.cveTipoUser = dt.Rows[0]["cveTipoUsuario"].ToString();

                        if (checkEdit_recordar.Checked)
                        {
                            ////Si marca la casilla se guardan los valores ingresados 
                            Settings.Default.usuario = textBox_user.Text;
                            Settings.Default.passw = textBox_password.Text;
                            Settings.Default.recordarme = "1";
                            Settings.Default.Save();
                        }
                        else
                        {
                            ////Si no se marca, se guardan los valores por default
                            Settings.Default.usuario = "Usuario";
                            Settings.Default.passw = "Constraseña";
                            Settings.Default.recordarme = "";
                            Settings.Default.Save();

                        }
                        //splashScreenManager3.ShowWaitForm();
                        MenuPrincipal objMenuPrincipal = new MenuPrincipal();
                        //splashScreenManager3.CloseWaitForm();

                        objMenuPrincipal.Show();////Se muestra el menu principal
                        this.Close();
                    }
                    else
                    {
                        ////Se muestra mensaje de error por ingresar mal las credenciales
                        ///label3.Visible = true;
                        XtraMessageBox.Show("Usuario y/o constraseña incorrectos.", "Credenciales incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //textBox_user.Text = "";
                        textBox_user.Focus();
                        textBox_password.Text = "";
                    }

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Usuario y/o constraseña incorrectos.", "Credenciales incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    textBox_user.Focus();
                    textBox_password.Text = "";
                }
                

            }
        }

        
        ////Metodo para encriptar una cadena de texto
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
        ////Metodo para desencriptar una cadena de texto
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
        ////Metodo para validar tecla ingresada en el textbox
        private void textBox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ingresar();

            }
        }
        ////Metodo para validar tecla ingresada en el textbox
        private void textBox_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ingresar();

            }
        }

        

        private void LOGIN_Load(object sender, EventArgs e)
        {
            //for (int i = 0; i < 100; i++)
            //{

            //    Thread.Sleep(100);
            //}
            LongInitialization();
        }

        protected void LongInitialization()
        {
            
            BaseInitialization();
            
            //LoadFonts();
            //LoadTextures();
        }
        private void simpleButton_exit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

       
        private void simpleButton_minisize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox_user_Click(object sender, EventArgs e)
        {
            textBox_user.Text = "";
            textBox_user.ForeColor = Color.Black;
        }

        private void textBox_password_Click(object sender, EventArgs e)
        {
            textBox_password.Text = "";
            textBox_password.ForeColor = Color.Black;
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '*';
            textBox_password.ForeColor = Color.Black;
        }

        private void simpleButton_configConex_Click(object sender, EventArgs e)
        {
            Configuraciones.configInicial obj = new Configuraciones.configInicial();
            obj.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
