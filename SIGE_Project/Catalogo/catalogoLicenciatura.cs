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

namespace SIGE_Project.Catalogo
{
    public partial class catalogoLicenciatura : DevExpress.XtraEditors.XtraForm
    {
        public catalogoLicenciatura()
        {
            InitializeComponent();
        }

        private void catalogoLicenciatura_Load(object sender, EventArgs e)
        {
            consultarDatos();
        }
        private void consultarDatos()
        {
            try
            {
                gridControl_mediosDifusion.DataSource = null;
                object[] datos = { };
                string[] parametros = { };
                DataSet ds = new DataSet();
                ds = Utilerias.consultarProcedimiento("", datos, parametros);
                DataTable dt = ds.Tables[0];
                gridControl_mediosDifusion.DataSource = dt;
                gridView_mediosDifusion.BestFitColumns();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Se generó un error al consultar los datos. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}