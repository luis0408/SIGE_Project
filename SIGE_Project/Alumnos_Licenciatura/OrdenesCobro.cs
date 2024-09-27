using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGE_Project.Alumnos_Licenciatura
{
    public partial class OrdenesCobro : DevExpress.XtraEditors.XtraForm
    {
        public OrdenesCobro()
        {
            InitializeComponent();
        }

        private void simpleButton_solicitarOrdenCobro_Click(object sender, EventArgs e)
        {
            if (validarSolicitudPendiente()==true)
            {
                XtraMessageBox.Show("Actualmente existe uan solicictud pendiente, ponganse en contacto con el depsartamento de finanzas.");
                return;
            }
            string msg = "Antes de continuar recuerda que una vez enviada la orden de cobro a tu correo electronico, " +
                         "tienes 3 días habiles para poder realizar el pago, si no se realiza el pago en el timpo mencionado deberas solciitar una nueva orden."
                         +"\n ¿Desea solicitar una orden de cobro?";
            if (XtraMessageBox.Show(msg,"Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                realizarSolicitudOrdenCobro();
            }
        }
        private void llenarLokups()
        {
            ////PERIODO
            ////SE SELECCIONA EL MAXIMO PARA QUE SIEMPRE SEA EL MAS RECIENTE
            lookUpEdit_periodo.Properties.DataSource = Utilerias.llenarlookupeditvalue("select  MAX(idPeriodo)as idPeriodo, CONCAT(cveMesInicio,' ',anioInicio,'-',cveMesFin,' ',anioFin)as descripcion from SIGE_Catalogo_Periodos GROUP by cveMesInicio,cveMesFin,anioInicio,anioFin");
            lookUpEdit_periodo.Properties.DisplayMember = "descripcion";
            lookUpEdit_periodo.Properties.ValueMember = "idPeriodo";
        }
        private bool validarSolicitudPendiente()
        {
            /////SE RETORNA VERDADERO SI EXISTE UNA SOLICITUD PENDIENTE
            ////SE RETORNA FALSO CUANDO NO EXISTE UNA SOLCITUD PENDIENTE
            return false;
        }
        private void realizarSolicitudOrdenCobro()
        {

        }
    }
}