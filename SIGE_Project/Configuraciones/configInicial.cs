using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using SIGE_Project.Properties;

namespace SIGE_Project.Configuraciones
{
    public partial class configInicial : DevExpress.XtraEditors.XtraForm
    {
        public configInicial()
        {
            InitializeComponent();
            textEdit_cadenaConexion.Text = Settings.Default.CadenaConexion;
        }

        private void simpleButton_testConex_Click(object sender, EventArgs e)
        {
            string cadeneishon = "Data Source=" + textEdit_servidor.Text + ";Initial Catalog=" + textEdit_baseDatos.Text + ";User ID=" + textEdit_usuario.Text + ";Password=" + textEdit_contrasenia.Text + "";
            textEdit_cadenaConexion.Text = ConnectToDatabase(cadeneishon);
        }
        SqlConnection cnn = null;
        bool conexioncorrecta = false;
        public string ConnectToDatabase(string sConnectionString)
        {
            //********************************************** ***
            // CONNECT TO THE DATABASE
            //*************************************************
            cnn = new SqlConnection(sConnectionString);
            try
            {
                if ((cnn != null))
                {
                    if (cnn.State == System.Data.ConnectionState.Open)
                        return "True";
                }
                else
                {
                    cnn = new System.Data.SqlClient.SqlConnection(sConnectionString);
                }

                cnn.Open();
                XtraMessageBox.Show("Conexion establecida correctamente.", "Exito",MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexioncorrecta = true;
                cnn.Close();
                return sConnectionString;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("No se pudo conectar con la base de datos " + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexioncorrecta = false;

                return ex.Message;
            }

        }

        private void simpleButton_saveConfig_Click(object sender, EventArgs e)
        {
            if(conexioncorrecta==false)
            {
                XtraMessageBox.Show("La cadena de conexión no es correcta, no se pueden guardar los nuevos cambios. " , "Error de conexión", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
           
            try
            {
                XtraInputBoxArgs args = new XtraInputBoxArgs();
                TextEdit editor = new TextEdit();
                editor.Properties.UseSystemPasswordChar = true;
                args.Editor = editor;
                args.Caption = "Autentificación";
                args.Prompt = "Ingresar la contraseña:";
                args.DefaultResponse = "";
                var resultado = XtraInputBox.Show(args);
                string contrasenia = string.IsNullOrEmpty(Convert.ToString(resultado)) ? "" : Convert.ToString(resultado);
                if (contrasenia == "s1st3m4s")
                {

                    Settings.Default["CadenaConexionLocal"] = textEdit_cadenaConexion.Text;
                    //Settings.Default.CadenaConexion = textEdit_cadenaConexion.Text;
                    //Settings.Default.tipoEquipo = lookUpEdit_tipoMaquina.Text;
                    //Settings.Default.NoCaja = textEdit_noCaja.Text;
                    Settings.Default.Save();
                    if (MessageBox.Show("La configuración fue aplicada correctamente \n ¿Desea reiniciar el sistema?", "Configuración correcta", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        Application.Restart();
                    else
                        this.Close();
                }
                else
                {
                    XtraMessageBox.Show("La contraseña ingresada es incorrecta, no se guardaran los cambios ingresados.", "Error de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ecpo)
            {
                XtraMessageBox.Show("Error al guardar los cambios. Detalles: "+ecpo.Message, "Error general", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }
}