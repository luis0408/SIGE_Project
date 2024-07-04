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
    public partial class catalogoTipoUsuarios : DevExpress.XtraEditors.XtraForm
    {
        public catalogoTipoUsuarios()
        {
            InitializeComponent();
        }

        private void catalogoTipoUsuarios_Load(object sender, EventArgs e)
        {
            consultarDatos();
        }

        private void consultarDatos()
        {
            try
            {
                gridControl_tipoUsuarios.DataSource = null;
                object[] datos = { };
                string[] parametros = { };
                DataSet ds = new DataSet();
                ds = Utilerias.consultarProcedimiento("SIGE_CONSULTAR_TIPOUSUARIOS", datos, parametros);
                DataTable dt = ds.Tables[0];
                gridControl_tipoUsuarios.DataSource = dt;
                gridView_tipoUsuarios.BestFitColumns();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Se generó un error al consultar los datos. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            exportarDoc(gridView_tipoUsuarios, gridControl_tipoUsuarios, "tipoUsuarios");
        }

        private void navBarItem_add_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DatosTipoUsuarios objTipoUsuarios = new DatosTipoUsuarios();
            objTipoUsuarios.ShowDialog();
            if (objTipoUsuarios.DialogResult == DialogResult.OK)
            {
                consultarDatos();
            }
        }

        private void navBarItem_edit_ItemChanged(object sender, EventArgs e)
        {
            
        }

        private void navBarItem_edit_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string cveTipoUsuario = gridView_tipoUsuarios.GetRowCellValue(gridView_tipoUsuarios.FocusedRowHandle, "cveTipoUsuario").ToString();
            string descUsuario = gridView_tipoUsuarios.GetRowCellValue(gridView_tipoUsuarios.FocusedRowHandle, "descripcion").ToString();
            int estado = Convert.ToInt32(gridView_tipoUsuarios.GetRowCellValue(gridView_tipoUsuarios.FocusedRowHandle, "estado").ToString());

            DatosTipoUsuarios objDatosTipoUsuarios = new DatosTipoUsuarios(cveTipoUsuario, descUsuario, estado);
            objDatosTipoUsuarios.ShowDialog();
            if (objDatosTipoUsuarios.DialogResult == DialogResult.OK)
            {
                consultarDatos();
            }

        }

        Utilerias util = new Utilerias();
        private void navBarItem_delete_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string cveMedio = gridView_tipoUsuarios.GetRowCellValue(gridView_tipoUsuarios.FocusedRowHandle, "cveTipoUsuario").ToString();
            int estado = Convert.ToInt32(gridView_tipoUsuarios.GetRowCellValue(gridView_tipoUsuarios.FocusedRowHandle, "estado").ToString());
            estado = estado == 1 ? 0 : 1;///SE CAMBIA AL VALOR CONTRARIO DEL VALOR ORIGINAL 
            int resul = util.EjecutarQueryNonQuery("update [SIGE_Catalogo_TipoUsuarios] set estado=" + estado + " where cveTipoUsuario='" + cveMedio + "'");
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
    }
}