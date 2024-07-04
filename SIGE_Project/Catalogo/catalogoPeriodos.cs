using DevExpress.Export;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void navBarItem_refresh_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            consultarDatos();
        }

        public static void exportarDoc(DevExpress.XtraGrid.Views.Grid.GridView gvw, DevExpress.XtraGrid.GridControl gr, string sheetna)
        {

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2010) (.xlsx)|*.xlsx|Excel (2003)(.xls)|*.xls";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xls":
                            //gvw.OptionsPrint.ExpandAllDetails = true;
                            //gvw.OptionsPrint.PrintDetails = true;
                            XlsExportOptions _options = new DevExpress.XtraPrinting.XlsExportOptions();
                            _options.TextExportMode = TextExportMode.Value;
                            _options.ExportMode = XlsExportMode.SingleFile;
                            _options.ShowGridLines = true;
                            _options.SheetName = sheetna;
                            //gvw.OptionsView.ColumnAutoWidth = false;
                            gvw.OptionsPrint.AutoWidth = false;
                            gvw.BestFitColumns();
                            //this.gridView1.ExportToXls("1.xls", _options);
                            DevExpress.Export.ExportSettings.DefaultExportType = ExportType.WYSIWYG;
                            gr.ExportToXls(exportFilePath, _options);

                            break;
                        case ".xlsx":
                            //gvw.OptionsPrint.ExpandAllDetails = true;
                            //gvw.OptionsPrint.PrintDetails = true;
                            XlsxExportOptions _options2 = new XlsxExportOptions();
                            _options2.TextExportMode = TextExportMode.Value;
                            _options2.ExportMode = XlsxExportMode.SingleFile;
                            _options2.ShowGridLines = true;
                            _options2.SheetName = sheetna;
                            // gvw.OptionsView.ColumnAutoWidth = false;
                            gvw.OptionsPrint.AutoWidth = false;
                            gvw.BestFitColumns();
                            //this.gridView1.ExportToXls("1.xls", _options);
                            DevExpress.Export.ExportSettings.DefaultExportType = ExportType.WYSIWYG;
                            gr.ExportToXlsx(exportFilePath, _options2);
                            break;
                        default:
                            break;
                    }

                    if ((DevExpress.XtraEditors.XtraMessageBox.Show("¿Desea abrir el archivo creado?", "Abrir archivo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.Yes)
                    {
                        try
                        {
                            //Try to open the file and let windows decide how to open it.
                            System.Diagnostics.Process.Start(exportFilePath);
                        }
                        catch
                        {
                            String msg = "El archivo no puede ser abierto." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            DevExpress.XtraEditors.XtraMessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "El archivo no se pudo guardar." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        DevExpress.XtraEditors.XtraMessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void navBarItem_export_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            exportarDoc(gridView_periodos, gridControl_periodos, "periodos");
        }

        private void navBarItem_edit_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int idCicloEscolar = Convert.ToInt32(gridView_periodos.GetRowCellValue(gridView_periodos.FocusedRowHandle, "idCicloEscolar"));
            string cveMesInicio = gridView_periodos.GetRowCellValue(gridView_periodos.FocusedRowHandle, "cveMesInicio").ToString();
            int anioInicio = Convert.ToInt32(gridView_periodos.GetRowCellValue(gridView_periodos.FocusedRowHandle, "anioInicio").ToString());
            string cveMesFin = gridView_periodos.GetRowCellValue(gridView_periodos.FocusedRowHandle, "cveMesFin").ToString();
            int anioFin = Convert.ToInt32(gridView_periodos.GetRowCellValue(gridView_periodos.FocusedRowHandle, "anioFin").ToString());
            DatosPeriodos objDatosPeriodos = new DatosPeriodos(idCicloEscolar, cveMesInicio, anioInicio, cveMesFin, anioFin);
            objDatosPeriodos.ShowDialog();
            if (objDatosPeriodos.DialogResult == DialogResult.OK)
            {
                consultarDatos();
            }
        }
    }
}