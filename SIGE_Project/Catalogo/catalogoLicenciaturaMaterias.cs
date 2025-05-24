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
    public partial class catalogoLicenciaturaMaterias : DevExpress.XtraEditors.XtraForm
    {
        Utilerias util = new Utilerias();
        public catalogoLicenciaturaMaterias()
        {
            InitializeComponent();
        }

        private void catalogoLicenciaturaMaterias_Load(object sender, EventArgs e)
        {
            consultarDatos();
        }

        public void consultarDatos()
        {
            try
            {
                gridControl_licenciaturaMaterias.DataSource = null;
                object[] datos = { };
                string[] parametros = { };
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ds = Utilerias.consultarProcedimiento("SIGE_CONSULTAR_LICENCIATURAMATERIAS", datos, parametros);
                dt = ds.Tables[0];
                gridControl_licenciaturaMaterias.DataSource = dt;
                gridView_licenciaturaMaterias.BestFitColumns();
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

        private void navBarItem_add_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DatosLicenciaturaMaterias objLicenciaturaMaterias = new DatosLicenciaturaMaterias();
            objLicenciaturaMaterias.ShowDialog();
            if (objLicenciaturaMaterias.DialogResult == DialogResult.OK)
                consultarDatos();
        }

        private void navBarItem_edit_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string cveMateria = gridView_licenciaturaMaterias.GetRowCellValue(gridView_licenciaturaMaterias.FocusedRowHandle, "cveMateria").ToString();
            string descripcion = gridView_licenciaturaMaterias.GetRowCellValue(gridView_licenciaturaMaterias.FocusedRowHandle, "descripcion").ToString();
            string cveLicenciatura = gridView_licenciaturaMaterias.GetRowCellValue(gridView_licenciaturaMaterias.FocusedRowHandle, "cveLicenciatura").ToString();
            int estado = Convert.ToInt32(gridView_licenciaturaMaterias.GetRowCellValue(gridView_licenciaturaMaterias.FocusedRowHandle, "estado").ToString());
            DatosLicenciaturaMaterias objLicenciaturaMaterias = new DatosLicenciaturaMaterias(cveMateria, descripcion, cveLicenciatura, estado);
            objLicenciaturaMaterias.ShowDialog();
            if (objLicenciaturaMaterias.DialogResult == DialogResult.OK)
                consultarDatos();
        }

        private void navBarItem_status_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string cveMateria = gridView_licenciaturaMaterias.GetRowCellValue(gridView_licenciaturaMaterias.FocusedRowHandle, "cveMateria").ToString();
            string descripcion = gridView_licenciaturaMaterias.GetRowCellValue(gridView_licenciaturaMaterias.FocusedRowHandle, "descripcion").ToString();
            string cveLicenciatura = gridView_licenciaturaMaterias.GetRowCellValue(gridView_licenciaturaMaterias.FocusedRowHandle, "cveLicenciatura").ToString();
            int estado = Convert.ToInt32(gridView_licenciaturaMaterias.GetRowCellValue(gridView_licenciaturaMaterias.FocusedRowHandle, "estado").ToString());
            estado = estado == 1 ? 0 : 1;
            int resul = util.EjecutarQueryNonQuery("update [SIGE_Catalogo_Licenciatura_Materias] set estado=" + estado + " where cveMateria='" + cveMateria + "'");
            if (resul != 0)
            {
                XtraMessageBox.Show("El registro se actualizó correctamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                XtraMessageBox.Show("Se generó un error al actualiar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
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
                            XlsExportOptions _options = new DevExpress.XtraPrinting.XlsExportOptions();
                            _options.TextExportMode = TextExportMode.Value;
                            _options.ExportMode = XlsExportMode.SingleFile;
                            _options.ShowGridLines = true;
                            _options.SheetName = sheetna;
                            gvw.OptionsPrint.AutoWidth = false;
                            gvw.BestFitColumns();
                            DevExpress.Export.ExportSettings.DefaultExportType = ExportType.WYSIWYG;
                            gr.ExportToXls(exportFilePath, _options);
                            break;

                        case ".xlsx":
                            XlsxExportOptions _options2 = new XlsxExportOptions();
                            _options2.TextExportMode = TextExportMode.Value;
                            _options2.ExportMode = XlsxExportMode.SingleFile;
                            _options2.ShowGridLines = true;
                            _options2.SheetName = sheetna;
                            gvw.OptionsPrint.AutoWidth = false;
                            gvw.BestFitColumns();
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
            exportarDoc(gridView_licenciaturaMaterias, gridControl_licenciaturaMaterias, "CatalogoLicenciaturaMaterias");
        }

        private void catalogoLicenciaturaMaterias_Load_1(object sender, EventArgs e)
        {

        }
    }
}