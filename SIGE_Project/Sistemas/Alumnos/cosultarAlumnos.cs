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

namespace SIGE_Project.Sistemas.Alumnos
{
    public partial class cosultarAlumnos : DevExpress.XtraEditors.XtraForm
    {
        public cosultarAlumnos()
        {
            InitializeComponent();

            ////GENERACION
            lookUpEdit_generacion.Properties.DataSource = Utilerias.llenarlookupeditvalue("select idGeneracion,CONCAT(anioInicio,'-',anioFin)as descripcion from SIGE_Catalogo_Generaciones where estado=1 order by idGeneracion desc");
            lookUpEdit_generacion.Properties.DisplayMember = "descripcion";
            lookUpEdit_generacion.Properties.ValueMember = "idGeneracion";
        }

        private void cosultarAlumnos_Load(object sender, EventArgs e)
        {
            //consularDatos();
        }
        private void consularDatos()
        {
            object[] datos = {lookUpEdit_generacion.EditValue };
            string[] parmetros = { "@generacion" };
            
            DataSet ds = Utilerias.consultarProcedimiento("[SIGE_CONSULTAR_SISTEMAS_ALUMNOS]", datos, parmetros);
            gridControl_alumnos.DataSource = ds.Tables[0];
            gridView_alumnos.BestFitColumns();
        }

        private void simpleButton_buscar_Click(object sender, EventArgs e)
        {
            if (lookUpEdit_generacion.EditValue==null)
            {
                XtraMessageBox.Show("Seleccione una generación para consultar datos", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            consularDatos();
        }

        private void navBarItem_add_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            datosAlumnos obj = new datosAlumnos();
            obj.ShowDialog();
            if (obj.DialogResult==DialogResult.OK)
            {
                consularDatos();
            }
        }

        private void navBarItem_edit_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                int idAlumno = Convert.ToInt32(gridView_alumnos.GetRowCellValue(gridView_alumnos.FocusedRowHandle, "idAlumno").ToString());
                string nombres = gridView_alumnos.GetRowCellValue(gridView_alumnos.FocusedRowHandle, "nombres").ToString();
                string apPaterno = gridView_alumnos.GetRowCellValue(gridView_alumnos.FocusedRowHandle, "apelldioPaterno").ToString();
                string apMaterno = gridView_alumnos.GetRowCellValue(gridView_alumnos.FocusedRowHandle, "apellidoMaterno").ToString();
                int estadoAlumno = Convert.ToInt32(gridView_alumnos.GetRowCellValue(gridView_alumnos.FocusedRowHandle, "estadoAlumno").ToString());
                string cveMod = gridView_alumnos.GetRowCellValue(gridView_alumnos.FocusedRowHandle, "cveModalidad").ToString();
                string cveLic = gridView_alumnos.GetRowCellValue(gridView_alumnos.FocusedRowHandle, "cveLicenciatura").ToString();
                int idGeneracion = Convert.ToInt32(gridView_alumnos.GetRowCellValue(gridView_alumnos.FocusedRowHandle, "idGeneracion").ToString());
                int idSemestre = Convert.ToInt32(gridView_alumnos.GetRowCellValue(gridView_alumnos.FocusedRowHandle, "idSemestre").ToString());
                string email = gridView_alumnos.GetRowCellValue(gridView_alumnos.FocusedRowHandle, "email").ToString();



                datosAlumnos obj = new datosAlumnos(idAlumno, nombres, apPaterno, apMaterno, estadoAlumno, cveMod, cveLic,idGeneracion,idSemestre,null,0,null,email);
                obj.ShowDialog();
                if (obj.DialogResult == DialogResult.OK)
                {
                    consularDatos();
                }
            }
            catch(Exception xc)
            {
                XtraMessageBox.Show("Ocurrió un error al obtener los datos del alumno seleccionado. Detalles: "+xc.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void navBarItem_refresh_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            consularDatos();
        }

        private void navBarItem_export_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            exportarDoc(gridView_alumnos,gridControl_alumnos,"Alumnos");
        }
        private static void exportarDoc(DevExpress.XtraGrid.Views.Grid.GridView gvw, DevExpress.XtraGrid.GridControl gr, string sheetna)
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
    }
}