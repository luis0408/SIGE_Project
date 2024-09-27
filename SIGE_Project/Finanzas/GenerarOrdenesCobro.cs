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
    public partial class GenerarOrdenesCobro : DevExpress.XtraEditors.XtraForm
    {
        public GenerarOrdenesCobro()
        {
            InitializeComponent();
        }
        object[] datos = { };
        string[] parametros = { };
        private void GenerarOrdenesCobro_Load(object sender, EventArgs e)
        {
            //navBarControl_opciones.Enabled = false;
            int anioActual = DateTime.Now.Year;
            dateEdit_fechaConsultar.EditValue = DateTime.Now;
            consultarAspirantes();
        }
        private void consultarAspirantes()
        {
            //int fechaSelect = Convert.ToDateTime(dateEdit_fechaConsultar.EditValue).Year;
            //datos = new object[] { fechaSelect };
            //parametros = new string[] { "@anioConsulta" };
            //DataSet dsAspirantes = new DataSet();
            //dsAspirantes = Utilerias.consultarProcedimiento("[SIGE_CONSULTAR_ASPIRANTES]", datos, parametros);
            //DataTable dtEnEspera = dsAspirantes.Tables[0];
            //DataTable dtAceptados = dsAspirantes.Tables[1];
            //DataTable dtDeclinados = dsAspirantes.Tables[2];
            //gridControl_enEspera.DataSource = dtEnEspera;
            //gridView_enEspera.BestFitColumns();
            //gridControl_aceptados.DataSource = dtAceptados;
            //gridView_aceptados.BestFitColumns();

            //xtraTabControl_Aspirantes.SelectedTabPageIndex = 1;
            //xtraTabControl_Aspirantes.SelectedTabPageIndex = 0;
            //navBarControl_opciones.Enabled = true;

        }
    }
}