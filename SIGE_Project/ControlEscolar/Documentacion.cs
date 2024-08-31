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
        string CURP;
        string nombre;
        DataTable dtDocsAspirante;
        DataTable tablaDocumentos;
        DataTable tablaDocsAspirante;
        DataTable tablaDocsFinal;
        public Documentacion(string _CURP, string _nombre)
        {
            InitializeComponent();
            CURP = _CURP;
            nombre = _nombre;
            textEdit_CURP.Text = CURP;  
            textEdit_name.Text= nombre; 
        }

        private void Documentacion_Load(object sender, EventArgs e)
        {
            consultarDatos();   

        }
        object[] datos = { };
        string[] parametros = { };
        private void consultarDatos()
        {
            try
            {
                /////SE VALIDA SI EXISTE LA TABLA DE DOCUMENTACION DEL ASIPRANTE
                datos = new object[] { CURP };
                parametros = new string[] { "@CURP" };
                DataSet ds = new DataSet();
                ds = Utilerias.consultarProcedimiento("[SIGE_CONSULTAR_ASPIRANTE_DOCUMENTACION]", datos, parametros);
                if (ds.Tables[0].Rows.Count > 0) /////SI EXISTE, SE CARGAN DATOS
                {
                    dtDocsAspirante = new DataTable();
                    dtDocsAspirante = ds.Tables[0];
                    gridControl_docs.DataSource = dtDocsAspirante;
                    gridView_docs.BestFitColumns();

                }
                else /////SI NO EXISTE SE CREA Y DESPUES SE CARGA
                {
                    crearTablaDocumentos();

                    consultarDatos();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Se generó un error al consultar la documentación del aspirante. Detalles: "+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

        }
        private void crearTablaDocumentos()
        {
            getDocuments();
            fillTableDocsAspirante();
            if (insertarTablaDocumentacion()!=1)
            {
                throw new Exception("El proceso termino con errores, por favor cierre el formulario e intentelo de nuevo. ");
               
            }

        }
        private void getDocuments()
        {
            /////SE LLENA TABLA CON LA LISTA DE DOCUMENTO DISPONIBLES
            try
            {
                datos = new object[] { };
                parametros = new string[] { };
                DataSet ds = new DataSet();
                ds = Utilerias.consultarProcedimiento("[SIGE_CONSULTAR_LISTADOCUMENTOS]", datos, parametros);
                tablaDocumentos = new DataTable();
                tablaDocumentos = ds.Tables[0];
            }
            catch (Exception e)
            {
                throw new Exception("Se generó un error al cargar la lista de documentos. Detalles: " + e.Message);


            }

        }
        private void createTableDocsAspirante()
        {
            tablaDocsAspirante = new DataTable();
            tablaDocsAspirante.Columns.Add("CURP");
            tablaDocsAspirante.Columns.Add("idDocumento", typeof(int));
            tablaDocsAspirante.Columns.Add("original", typeof(int));
            tablaDocsAspirante.Columns.Add("copia", typeof(int));
            tablaDocsAspirante.Columns.Add("observaciones");
            tablaDocsAspirante.Columns.Add("rutaArchivo");
        }
        private void createTableDocsFinal()
        {
            tablaDocsFinal = new DataTable();
           // tablaDocsFinal.Columns.Add("idRegistro", typeof(int));
            tablaDocsFinal.Columns.Add("CURP");
            tablaDocsFinal.Columns.Add("idDocumento", typeof(int));
            tablaDocsFinal.Columns.Add("original", typeof(int));
            tablaDocsFinal.Columns.Add("copia", typeof(int));
            tablaDocsFinal.Columns.Add("observaciones");
            tablaDocsFinal.Columns.Add("rutaArchivo");
        }
        public void fillTableDocsAspirante()
        {
            /////SE CREA TABLA DE DOCUMENTACION DEL ASPIRANTE
            createTableDocsAspirante();
            /////SE RECORRE TABLA DE DOCS PARA LLENAR LA TABLA DE DOCUMENTOS DEL ASPIRANTE
            for (int i = 0; i < tablaDocumentos.Rows.Count; i++)
            {
                int idDocumento = Convert.ToInt32(tablaDocumentos.Rows[i]["idDocumento"].ToString());
                tablaDocsAspirante.Rows.Add(CURP, idDocumento, 0, 0, null, null);
            }
        }

        public int insertarTablaDocumentacion()
        {
            try
            {
                datos = new object[] { tablaDocsAspirante };
                parametros = new string[] { "@tableishon" };
                int resultadoInsertDocumentacion = Utilerias.ejecutarprocedimiento("SIGE_INSERTAR_ASPIRANTE_TABLADOCUMENTACION", datos, parametros);
                return resultadoInsertDocumentacion;
            }
            catch (Exception ex) 
            {
                XtraMessageBox.Show("Se generó un error al insetar la tabla documentos del alumnos. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;

            }

        }

        private void simpleButton_cancel_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Sí sale ahora los cambios no se guardaran, ¿Está seguro que desea salir?","Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void simpleButton_save_Click(object sender, EventArgs e)
        {
            try
            {
                ////SE CREA TABLA 
                createTableDocsFinal();
                ////SE RECORRE GRID Y SE INSERTAN VALORES EN EL DATATABLE tablaDocsFinal
                for (int i = 0; i < gridView_docs.RowCount; i++)
                {
                    //int idRegGrid = Convert.ToInt32(gridView_docs.GetRowCellValue(i, "idRegistro").ToString());
                    string curpGrid = gridView_docs.GetRowCellValue(i, "CURP").ToString();
                    int idDocGrid = Convert.ToInt32(gridView_docs.GetRowCellValue(i, "idDocumento").ToString());
                    int originalcGrid = Convert.ToInt32(gridView_docs.GetRowCellValue(i, "original").ToString());
                    int copiaGrid = Convert.ToInt32(gridView_docs.GetRowCellValue(i, "copia").ToString());
                    string observacionesGrid = gridView_docs.GetRowCellValue(i, "observaciones").ToString();

                    tablaDocsFinal.Rows.Add(curpGrid, idDocGrid, originalcGrid, copiaGrid, observacionesGrid);
                }
                updateablaDocumentacion();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Se generó un error al crear la tabla final de documentos. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        private void updateablaDocumentacion()
        {
            datos = new object[] { tablaDocsFinal,textEdit_CURP.Text};
            parametros = new string[] {"@tableishon","@CURP" };
            int resultUpdate=Utilerias.ejecutarprocedimiento("SIGE_ACTUALIZAR_ASPIRANTE_TABLADOCUMENTACION", datos, parametros);
            if (resultUpdate > 0) 
            {
                XtraMessageBox.Show("La información se actualizó correctamente." , "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();   

            }
            else
            
            {
                throw new Exception("Proceso terminado con errores,la información NO se actualizó.");

            }
        }
    }
}