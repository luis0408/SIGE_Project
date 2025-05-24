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

namespace SIGE_Project.Sistemas.Alumnos
{
    public partial class cosultarAlumnos : DevExpress.XtraEditors.XtraForm
    {
        public cosultarAlumnos()
        {
            InitializeComponent();

            ////GENERACION
            lookUpEdit_generacion.Properties.DataSource = Utilerias.llenarlookupeditvalue("select idGeneracion,CONCAT(anioInicio,'-',anioFin)as descripcion from SIGE_Catalogo_Generaciones where estado=1 order by idGeneracion desc");
            lookUpEdit_generacion.Properties.DisplayMember = "descripcion";
            lookUpEdit_generacion.Properties.ValueMember = "idGeneracion";
        }

        private void cosultarAlumnos_Load(object sender, EventArgs e)
        {
            //consularDatos();
        }
        private void consularDatos()
        {
            object[] datos = {lookUpEdit_generacion.EditValue };
            string[] parmetros = { "@generacion" };
            DataSet ds = Utilerias.consultarProcedimiento("[SIGE_CONSULTAR_SISTEMAS_ALUMNOS]", datos, parmetros);
            gridControl_alumnos.DataSource = ds.Tables[0];
            gridView_alumnos.BestFitColumns();
        }

        private void simpleButton_buscar_Click(object sender, EventArgs e)
        {
            if (lookUpEdit_generacion.EditValue==null)
            {
                XtraMessageBox.Show("Seleccione una generación para consultar datos", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            consularDatos();
        }

        private void navBarItem_add_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            datosAlumnos obj = new datosAlumnos();
            obj.ShowDialog();
            if (obj.DialogResult==DialogResult.OK)
            {
                consularDatos();
            }
        }
    }
}