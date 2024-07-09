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
    public partial class ConsultarAspirantes : DevExpress.XtraEditors.XtraForm
    {
        public ConsultarAspirantes()
        {
            InitializeComponent();
        }
        object[] datos = { };
        string[] parametros = { };
        private void ConsultarAspirantes_Load(object sender, EventArgs e)
        {
            consultarAspirantes();
        }
        private void consultarAspirantes() 
        {
            datos = new object[] { };
            parametros = new string[] { };  
            DataSet dsAspirantes = new DataSet();
            dsAspirantes = Utilerias.consultarProcedimiento("[SIGE_CONUSLTAR_ASPIRANTES]", datos,parametros);
            DataTable dtAspirantes=dsAspirantes.Tables[0];  
            gridControl_enEspera.DataSource= dtAspirantes;
            gridView_enEspera.BestFitColumns();
        }
    }
}