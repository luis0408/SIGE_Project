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
    public partial class CatalogoDiscapacidad : XtraForm
    {
        public CatalogoDiscapacidad()
        {
            InitializeComponent();
        }

        private void CatalogoDiscapacidad_Load(object sender, EventArgs e)
        {
            consultarDatosDiscapacidad();
        }

        private void consultarDatosDiscapacidad()
        {
            try
            {
                gridControl_discapacidad.DataSource = null;
                object[] datos = { };
                string[] parametros = { };
                DataSet ds = Utilerias.consultarProcedimiento("SIGE_CONSULTAR_DISCAPACIDAD", datos, parametros);
                DataTable dt = ds.Tables[0];
                gridControl_discapacidad.DataSource = dt;
                gridView_discapacidad.BestFitColumns();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Se generó un error al consultar los datos. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    

        public static void exportarDoc(DevExpress.XtraGrid.Views.Grid.GridView gvw, DevExpress.XtraGrid.GridControl gr, string sheetna)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2010) (.xlsx)|*.xlsx|Excel (2003)(.xls)|*.xls";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtension = new FileInfo(exportFilePath).Extension;

                    switch (fileExtension)
                    {
                        case ".xls":
                            XlsExportOptions options = new XlsExportOptions
                            {
                                TextExportMode = TextExportMode.Value,
                                ExportMode = XlsExportMode.SingleFile,
                                ShowGridLines = true,
                                SheetName = sheetna
                            };
                            gvw.OptionsPrint.AutoWidth = false;
                            gvw.BestFitColumns();
                            DevExpress.Export.ExportSettings.DefaultExportType = ExportType.WYSIWYG;
                            gr.ExportToXls(exportFilePath, options);
                            break;

                        case ".xlsx":
                            XlsxExportOptions options2 = new XlsxExportOptions
                            {
                                TextExportMode = TextExportMode.Value,
                                ExportMode = XlsxExportMode.SingleFile,
                                ShowGridLines = true,
                                SheetName = sheetna
                            };
                            gvw.OptionsPrint.AutoWidth = false;
                            gvw.BestFitColumns();
                            DevExpress.Export.ExportSettings.DefaultExportType = ExportType.WYSIWYG;
                            gr.ExportToXlsx(exportFilePath, options2);
                            break;

                        default:
                            break;
                    }

                    if (XtraMessageBox.Show("¿Desea abrir el archivo creado?", "Abrir archivo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        try
                        {
                            System.Diagnostics.Process.Start(exportFilePath);
                        }
                        catch
                        {
                            string msg = "El archivo no puede ser abierto." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            XtraMessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void navBarItem_export_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            exportarDoc(gridView_discapacidad, gridControl_discapacidad, "discapacidad");
        }

       

        private void navBarItem_refresh_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            consultarDatosDiscapacidad();
        }

        private void navBarItem_add_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DatosDiscapacidad objDatosDiscapacidad = new DatosDiscapacidad();
            objDatosDiscapacidad.ShowDialog();
            if (objDatosDiscapacidad.DialogResult == DialogResult.OK)
            {
                consultarDatosDiscapacidad();
            }

        }

        private void navBarItem_edit_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (gridView_discapacidad.FocusedRowHandle >= 0) 
            {
                int idDiscapacidad = Convert.ToInt32(gridView_discapacidad.GetRowCellValue(gridView_discapacidad.FocusedRowHandle, "idDIscapacidad"));
                string descripcion = gridView_discapacidad.GetRowCellValue(gridView_discapacidad.FocusedRowHandle, "descripcion").ToString();
                int estado = Convert.ToInt32(gridView_discapacidad.GetRowCellValue(gridView_discapacidad.FocusedRowHandle, "estado"));

                DatosDiscapacidad objDatosDiscapacidad = new DatosDiscapacidad(idDiscapacidad, descripcion, estado);
                objDatosDiscapacidad.ShowDialog();

                if (objDatosDiscapacidad.DialogResult == DialogResult.OK)
                {
                    consultarDatosDiscapacidad();
                }
            }
            else
            {
                XtraMessageBox.Show("Por favor, seleccione una discapacidad para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        Utilerias util = new Utilerias();
        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
           
            string descripcion = gridView_discapacidad.GetRowCellValue(gridView_discapacidad.FocusedRowHandle, "descripcion").ToString();
            int estado = Convert.ToInt32(gridView_discapacidad.GetRowCellValue(gridView_discapacidad.FocusedRowHandle, "estado").ToString());
            estado = estado == 1 ? 0 : 1; 
            int resul = util.EjecutarQueryNonQuery("update [SIGE_Catalogo_Discapacidad] set estado=" + estado + " where descripcion='" + descripcion + "'");
            if (resul != 0)
            {
                XtraMessageBox.Show("El registro se actualizó correctamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                XtraMessageBox.Show("Se generó un error al actualiar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            consultarDatosDiscapacidad();
        }

        private void CatalogoDiscapacidad_Load_1(object sender, EventArgs e)
        {
            consultarDatosDiscapacidad();
        }

        private void navBarItem_export_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            exportarDoc(gridView_discapacidad, gridControl_discapacidad, "discapacidad");

        }
    }
}