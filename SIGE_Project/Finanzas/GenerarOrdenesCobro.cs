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
            //int anioActual = DateTime.Now.Year;
            //dateEdit_fechaConsultar.EditValue = DateTime.Now;
            dateEdit_fechaIncial.ReadOnly = true;
            dateEdit_fechaFinal.ReadOnly = true;
            simpleButton_consultar.Enabled = false;
            int NumeroDias = 12;
            DateTime fechaActual = DateTime.Now;
            DateTime fechaFinal = fechaActual.AddDays(-NumeroDias);

            dateEdit_fechaIncial.EditValue = fechaActual;
            dateEdit_fechaFinal.EditValue = fechaFinal;

            consultarSolcitudes();
        }
        
        private void consultarSolcitudes()
        {
            try
            {
                datos = new object[] {dateEdit_fechaIncial.EditValue,dateEdit_fechaFinal.EditValue };
                parametros = new string[] { "@fechaIni", "@fechaFin" };
                DataSet ds = Utilerias.consultarProcedimiento("SIGE_CONSULTAR_SOLICITUDESORDENCOBRO", datos, parametros);
                if (ds.Tables[0].Rows.Count>0)////PENDIENTES
                {
                    DataTable dt = ds.Tables[0];
                    gridControl_Pendientes.DataSource = dt;
                    gridView_Pendientes.BestFitColumns();
                }
                if (ds.Tables[1].Rows.Count > 0)////ENVIADAS
                {
                    DataTable dt = ds.Tables[1];
                    gridControl_Enviadas.DataSource = dt;
                    gridView_Enviadas.BestFitColumns();
                }
                if (ds.Tables[2].Rows.Count > 0)////fINALIZADAS
                {
                    DataTable dt = ds.Tables[2];
                    gridControl1_Finalizadas.DataSource = dt;
                    gridView_Finalizadas.BestFitColumns();
                }
                if (ds.Tables[3].Rows.Count > 0)////VENCIDAS
                {
                    DataTable dt = ds.Tables[3];
                    gridControl_Vencidas.DataSource = dt;
                    gridView_Vencidas.BestFitColumns();
                }
                if (ds.Tables[4].Rows.Count > 0)////CANCELADAS
                {
                    DataTable dt = ds.Tables[4];
                    gridControl_Canceladas.DataSource = dt;
                    gridView_Canceladas.BestFitColumns();
                }
                
            }
            catch (Exception ex) 
            {
                XtraMessageBox.Show("Se generó un error al realizar la consulta de las solicitudes. Detalles: "+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

        }

        private void simpleButton_consultar_Click(object sender, EventArgs e)
        {
            consultarSolcitudes();
        }

        private void checkEdit_searchPerzonalizada_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit_searchPerzonalizada.Checked)
            {
                dateEdit_fechaIncial.ReadOnly = false;
                dateEdit_fechaFinal.ReadOnly = false;
                simpleButton_consultar.Enabled = true;
            }
            else
            {
                dateEdit_fechaIncial.ReadOnly = true;
                dateEdit_fechaFinal.ReadOnly = true;
                simpleButton_consultar.Enabled = false;
            }
        }

        private void navBarItem_sendMail_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int rowsSelectCount = gridView_Pendientes.SelectedRowsCount;////CUENTA CUANTAS FILAS FUERON SELECCIONADAS
            if (rowsSelectCount == 0)
            {
                XtraMessageBox.Show("Selecciona una solicitud para enviar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rowsSelectCount >1)
            {
                XtraMessageBox.Show("Solo se puede enviar una solicitud a la vez", "Multiselcción no permitida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string curpSolicitante=gridView_Pendientes.GetRowCellValue(gridView_Pendientes.FocusedRowHandle, "CURP").ToString();
            string correoSolicitante= gridView_Pendientes.GetRowCellValue(gridView_Pendientes.FocusedRowHandle, "email").ToString();
            int idSolicitud = Convert.ToInt32(gridView_Pendientes.GetRowCellValue(gridView_Pendientes.FocusedRowHandle, "idSolicitud").ToString());
            EnviarOrdenCobro objSendOrdenCobro = new EnviarOrdenCobro(curpSolicitante,correoSolicitante,idSolicitud);
            objSendOrdenCobro.ShowDialog();
            if (objSendOrdenCobro.DialogResult==DialogResult.OK)
            {
                consultarSolcitudes();
            }
            {

            }
            
        }
    }
}