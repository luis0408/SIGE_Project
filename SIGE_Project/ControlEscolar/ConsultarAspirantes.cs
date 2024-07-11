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
            //consultarAspirantes();
            navBarControl_opciones.Enabled = false;
        }
        private void consultarAspirantes() 
        {
            int fechaSelect =  Convert.ToDateTime(dateEdit_fechaConsultar.EditValue).Year;
            datos = new object[] {fechaSelect };
            parametros = new string[] { "@anioConsulta" };  
            DataSet dsAspirantes = new DataSet();
            dsAspirantes = Utilerias.consultarProcedimiento("[SIGE_CONSULTAR_ASPIRANTES]", datos,parametros);
            DataTable dtAspirantes=dsAspirantes.Tables[0];  
            gridControl_enEspera.DataSource= dtAspirantes;
            gridView_enEspera.BestFitColumns();
        }

        private void navBarItem_exportar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            exportarDoc(gridView_enEspera, gridControl_enEspera, "AspirantesEnEspera");
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

        private void simpleButton_buscar_Click(object sender, EventArgs e)
        {
            consultarAspirantes();

        }

        private void xtraTabControl_Aspirantes_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            ////METODO PARA EVALUAR EL CAMBIO DE PAGINA 
            string nomPag = xtraTabControl_Aspirantes.SelectedTabPage.Name;////SE EVALUA EL NOMBRE DE LA PAGINA SELECCIONADA


            switch(nomPag)
            {
                case "xtraTabPage_espera":
                    navBarItem_aceptar.Visible = true;
                    navBarItem_inscribir.Visible = false;
                    navBarItem_reutilizar.Visible = false;

                    navBarItem_editar.Visible = true;
                    navBarItem_declinar.Visible = true;

                    navBarItem_generarFicha.Visible = true;
                    break;
                case "xtraTabPage_aceptados":
                    navBarItem_aceptar.Visible = false;
                    navBarItem_inscribir.Visible = true;
                    navBarItem_reutilizar.Visible = false;

                    navBarItem_editar.Visible = true;
                    navBarItem_declinar.Visible = true;

                    navBarItem_generarFicha.Visible = true;
                    break;
                case "xtraTabPage_declinados":
                    navBarItem_aceptar.Visible = false;
                    navBarItem_inscribir.Visible = false;
                    navBarItem_reutilizar.Visible = true;

                    navBarItem_editar.Visible = false;
                    navBarItem_declinar.Visible = false;

                    navBarItem_generarFicha.Visible = false;
                    break;
                default:
                    break;
            }
        }
    }
}