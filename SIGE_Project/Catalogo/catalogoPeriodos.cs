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
    public partial class catalogoPeriodos : DevExpress.XtraEditors.XtraForm
    {
        public catalogoPeriodos()
        {
            InitializeComponent();
        }
        private void catalogoPeriodos_Load(object sender, EventArgs e)
        {
            consultarDatos();
        }
        private void consultarDatos()
        {
            try
            {
                gridControl_periodos.DataSource = null;
                object[] datos = { };
                string[] parametros = { };
                DataSet ds = new DataSet();
                ds = Utilerias.consultarProcedimiento("SIGE_CONSULTAR_PERIODOS", datos, parametros);
                DataTable dt = ds.Tables[0];
                gridControl_periodos.DataSource = dt;
                gridView_periodos.BestFitColumns();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Se generó un error al consultar los datos. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void navBarItem_add_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DatosPeriodos objDatosPeriodos = new DatosPeriodos();
            objDatosPeriodos.ShowDialog();
            if (objDatosPeriodos.DialogResult == DialogResult.OK)
            {
                consultarDatos();
            }
        }

    }
}