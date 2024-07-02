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
    public partial class catalogoCicloEscolar : DevExpress.XtraEditors.XtraForm
    {
        public catalogoCicloEscolar()
        {
            InitializeComponent();
        }
        private void catalogoCicloEscolar_Load(object sender, EventArgs e)
        {
            consultarDatos();
        }
        public void consultarDatos()
        {
            try
            {
                gridControl_cicloEscolar.DataSource = null;
                object[] datos = { };
                string[] parametros = { };
                DataSet ds = new DataSet();
                ds = Utilerias.consultarProcedimiento("SIGE_CONSULTAR_CICLOESCOLAR", datos, parametros);
                gridControl_cicloEscolar.DataSource = ds;
                gridView_cicloEscolar.BestFitColumns();
            }
            catch (Exception ex) 
            {
                XtraMessageBox.Show("Se genero un error al consultar la base de datos: Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void navBarItem_refresh_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            consultarDatos();
        }
    }
}