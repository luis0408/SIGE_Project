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
            insertarTablaDocumentacion();

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
                XtraMessageBox.Show("Se generó un error al cargar la lista de documentos. Detalles: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            datos = new object[] { tablaDocsAspirante };
            parametros = new string[] { "@tableishon" };
            int resultadoInsertDocumentacion = Utilerias.ejecutarprocedimiento("SIGE_INSERTAR_ASPIRANTE_TABLADOCUMENTACION", datos, parametros);
            return resultadoInsertDocumentacion;
        }
    }
}