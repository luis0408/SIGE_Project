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

namespace SIGE_Project.ControlEscolar
{
    public partial class Documentacion : DevExpress.XtraEditors.XtraForm
    {
        public Documentacion(string nombre)
        {
            InitializeComponent();
            textEdit1.Text= nombre; 
        }

        private void Documentacion_Load(object sender, EventArgs e)
        {
            object[] datos = { };
            string[] parametros = { };
            DataSet ds= new DataSet();  
            ds= Utilerias.consultarProcedimiento("[SIGE_CONSULTAR_LISTADOCUMENTOS]", datos, parametros);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];  
            gridControl_docs.DataSource = dt;
            gridView_docs.BestFitColumns();
        }
    }
}