using DevExpress.Utils.CommonDialogs;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGE_Project.Finanzas
{
    public partial class EnviarOrdenCobro : DevExpress.XtraEditors.XtraForm
    {
        public EnviarOrdenCobro()
        {
            InitializeComponent();
        }
        string CURP, correoElectronico;
        int idSolicitud;
        public EnviarOrdenCobro(string _CURP, string _correoElectronico, int _idSolicitud)
        {
            InitializeComponent();
        }


        private void buttonEdit_Ruta_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string rutaLocalOrdenCobro= "";
            this.openFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf";
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String file in openFileDialog1.FileNames)
                {
                    rutaLocalOrdenCobro = file;

                }

            }
        }

        private void simpleButton_send_Click(object sender, EventArgs e)
        {

        }
    }
}