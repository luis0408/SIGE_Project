using DevExpress.Utils.CommonDialogs;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Pdf;
using System.CodeDom;
using DevExpress.XtraRichEdit.Model;

namespace SIGE_Project.Finanzas
{
    public partial class EnviarOrdenCobro : DevExpress.XtraEditors.XtraForm
    {
        //public EnviarOrdenCobro()
        //{
        //    InitializeComponent();
        //}
        string CURP, correoElectronico;
        int idSolicitud;

        string rutaLocalOrdenCobro = "";
        string nombreArchivoLocal = "";
        string rutaFTP_ordenesCobro = variables.rutaFTP +"OrdenesCobro/";

        Mail objMail;
        clsOrdenCobro objOrdenCobro;

        public EnviarOrdenCobro(string _CURP, string _correoElectronico, int _idSolicitud)
        {
            InitializeComponent();
            CURP = _CURP;
            correoElectronico = _correoElectronico;
            idSolicitud = _idSolicitud;

            ///SE SETAN VALORES
            textEdit_curp.Text = _CURP;
            textEdit_correoAEnviar.Text = _correoElectronico;
        }


        private void buttonEdit_Ruta_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ////SE SELECCIONA EL ARCHIVO QUE SE VA A ENVIAR
            this.openFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf";
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                rutaLocalOrdenCobro = openFileDialog1.FileName;
                nombreArchivoLocal = Path.GetFileName(rutaLocalOrdenCobro);
                buttonEdit_Ruta.Text = rutaLocalOrdenCobro;
            }

        }
        private void simpleButton_send_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                ////SE COPIA ARCHVIO A SERVIDOR
                copyFileToServer();
                ////SE ENVIA CORREO ELECTRONICO
                sendEmail();

                this.DialogResult= DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                if (splashScreenManager1.IsSplashFormVisible)
                {
                    splashScreenManager1.CloseWaitForm();
                }
                XtraMessageBox.Show("Ocurrió un erro al realizar la solicitud. Detalles: "+ex.Message, "Error general", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void sendEmail()
        {
            try
            {
                ////SE CREA OBJETO MAIL
                string msgMail = "IMPORTANTE: LEE QUE TUS DATOS SEAN LOS CORRECTOS  EN CASO DE QUE NO SEA ASI... " +
                                  "RESPONDE EN ESE MISMO CORREO PARA HACER LA ORDEN DE COBRO CORRECTA  UNA VEZ QUE HAYAS REALIZADO EL PAGO DE TU ORDEN, " +
                                  "DEBERÁS VENIR A LA INSTITUCIÓN CON TU ORIGINAL Y UNA COPIA  (EL COMPROBANTE DE PAGO DEBERÁ VENIR EN LA PARTE DE ABAJO " +
                                  "DE TU ORDEN DE COBRO ORIGINAL, ENGRAPADO Y POSTERIORMENTE SACAR LAS COPIA) Y PRESENTARLAS AL DEPARTAMENTO DE FINANZAS DEL " +
                                  "IESE PARA QUE SEAN SELLADAS Y FIRMADAS PARA PODER ESTAR REINSCRITO.";

                ////SE ARMA LISTA DE DOCUMENTOS ADJUNTOS
                List<string> lstArchivos = new List<string>();
                lstArchivos.Add(rutaLocalOrdenCobro);
                objMail = new Mail();
                objMail.setDatosEmisor(variables.cveTipoUser);
                objMail.setDatosReceptor(textEdit_correoAEnviar.Text);
                objMail.setCuerpoCorreo(msgMail, "Orden de cobro para inscripción o reinscripción", lstArchivos);
                if (objMail.enviaMail() == true)
                {
                    //////SI SE ENVIO CORRECTAMENTE SE ACUALIZAN DATOS EN LA BASE DE DATOS
                    objOrdenCobro = new clsOrdenCobro(CURP);
                    objOrdenCobro.setIdOrdenCobro(idSolicitud);
                    objOrdenCobro.setDatosEnviadoOrdenCobro(variables.varUser, Path.Combine(rutaFTP_ordenesCobro, crearNombreArchivo()));
                    if (objOrdenCobro.updateEnviadoOrdenCobro()==0)
                    {
                        throw new Exception("No se realizó la actualización de la solicitud en la base de datos. ");
                    }

                    if (splashScreenManager1.IsSplashFormVisible)
                    {
                        splashScreenManager1.CloseWaitForm();
                    }
                    XtraMessageBox.Show("El email se envió correctamente. ", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception("El email no pudo ser enviado. Detalles:  " + objMail.error);
                    
                }
            }
            catch(Exception excMail)
            {
                throw new Exception("Error al relizar el proceso. Excepcion: "+excMail.Message);
            }
            
        }
        
        private void simpleButton_cancel_Click(object sender, EventArgs e)
        {
            if(XtraMessageBox.Show("Aún no ha enviado el correo, ¿Desea cerrar esta ventana?","Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                ////SI RESPONDE QUE SI QUIERE CERRAR SE CIERRA Y SE ENVIA RESPUESTA CANCEL
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }

            #region Metodo mostrar documento de FTP
            //// URL del archivo PDF en el FTP
            //string ftpUrl = "ftp://clienteFTP@wyb.ddns.net/OrdenesCobro/16422.pdf";
            //// Ruta local temporal para guardar el archivo descargado
            //string localPath = Path.Combine(Path.GetTempPath(), "temp.pdf");

            //// Descargar el archivo PDF del FTP
            //using (WebClient request = new WebClient())
            //{
            //    request.Credentials = new NetworkCredential("clienteFTP", "cl13nt3ftp");
            //    try
            //    {
            //        request.DownloadFile(ftpUrl, localPath);
            //        MessageBox.Show("Archivo descargado exitosamente.");

            //        // Cargar el PDF en el PdfViewerControl
            //        System.Diagnostics.Process.Start(localPath);
            //    }
            //    catch (WebException ex)
            //    {
            //        MessageBox.Show("Error al descargar el archivo: " + ex.Message);
            //    }
            //}
            #endregion
        }


        private string crearNombreArchivo()
        {
            ////EL NOMBRE DEL ARCHIVO SE COMPONDRA DE LA CURP DEL SOLICITANTE + OdenCobro_ ID DE LA SOLICITUD 
            string nombreArchivoFinal = CURP + "_OrdenCobro_" + idSolicitud.ToString()+".pdf";
            return nombreArchivoFinal;
        }

        private void EnviarOrdenCobro_Load(object sender, EventArgs e)
        {

        }

        private void copyFileToServer()
        {
            /////SE COPIA EL ARCHIVO LOCAL AL SERVIDOR POR MEDIO DE FTP
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(Path.Combine(rutaFTP_ordenesCobro, crearNombreArchivo()));
                request.Method = WebRequestMethods.Ftp.UploadFile;
                string user = variables.userFTP;
                string password = variables.passwordFTP;
                request.Credentials = new NetworkCredential(user, password);

                request.UsePassive = false;
                request.UseBinary = true;
                request.KeepAlive = true;
                request.Method = WebRequestMethods.Ftp.UploadFile;

                FileStream stream = File.OpenRead(rutaLocalOrdenCobro);
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                stream.Close();

                Stream reqStream = request.GetRequestStream();
                reqStream.Write(buffer, 0, buffer.Length);
                reqStream.Flush();
                reqStream.Close();

                /////SI TERMINA SIN ERRORES QUIERE DECIR QUE SE SUBIO CORRECTAMENTE, EN CASO DE HABER ERROR VA A ACTIVAR EL CATCH
                //XtraMessageBox.Show("subido ok");
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo copiar el archivo en el FTP. Exception: "+ex.Message);
            }





        }
    }
}