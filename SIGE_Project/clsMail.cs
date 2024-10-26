using DevExpress.CodeParser;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SIGE_Project
{
    class Mail
    {
        string From = "";
        string To;
        string Message;
        string Subject;
        bool checkM;
        List<string> Archivo = new List<string>();
       
        //string DE;
        string PASS; 

        System.Net.Mail.MailMessage Email;

        public string error = "";

        Utilerias util = new Utilerias();
        string Desencrypted = "";
        string cveUsuario;
        public Mail()
        {
        }

        public void setDatosEmisor(string _cveUsuario)
        {
            /////SE CONULTA EL CORREO EN BASE AL USUARIO
            DataSet ds = util.ejecutarQueryDataset("tblCorreo", "select correoElectronico,passwordCorreoElectronico from SIGE_Configuracion_Usuarios_CorreosElectronicos where cuentaUsuario='" + _cveUsuario + "'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                From = dt.Rows[0]["correoElectronico"].ToString();
                PASS= Desencriptar(dt.Rows[0]["passwordCorreoElectronico"].ToString());
            }
        }

        public void setDatosReceptor(string _mailReceptor)
        {
            To = _mailReceptor;
        }
        public void setCuerpoCorreo(string _Mensaje, string _Asunto,List<string>ArchivoAdjunto=null)
        {
            Message = _Mensaje;
            Subject = _Asunto;
            Archivo = ArchivoAdjunto;
        }

        


        public bool enviaMail()
        {
            if (To.Trim().Equals("") || Message.Trim().Equals("") || Subject.Trim().Equals(""))
            {
                error = "El mail, el asunto y el mensaje son obligatorios";
                return false;
            }
            try
            {
                Email = new System.Net.Mail.MailMessage(From, To, Subject, Message);
                if (Archivo != null)
                {
                    foreach (string archivo in Archivo)
                    {
                        if (System.IO.File.Exists(@archivo))
                            Email.Attachments.Add(new Attachment(@archivo));
                    }
                }
                Email.IsBodyHtml = true;
                Email.From = new MailAddress(From);
                System.Net.Mail.SmtpClient smtpMail = new System.Net.Mail.SmtpClient("smtp.gmail.com");
                smtpMail.EnableSsl = true;
                smtpMail.UseDefaultCredentials = false;
                smtpMail.Host = "smtp.gmail.com";
                smtpMail.Port = 587;
                smtpMail.Credentials = new System.Net.NetworkCredential(From, PASS);
                smtpMail.Send(Email);
                smtpMail.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                error = "Ocurrio un error: " + ex.Message;
                // uti.guardarLog(error);
                return false;
            }

            return false;

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
    }
}
