﻿using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
            if (XtraMessageBox.Show("Verifique que la información sea correcta. ¿Desea continuar?","Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
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
            


        }
        private void updateablaDocumentacion()
        {
            datos = new object[] { tablaDocsFinal,textEdit_CURP.Text};
            parametros = new string[] {"@tableishon","@CURP" };
            int resultUpdate=Utilerias.ejecutarprocedimiento("SIGE_ACTUALIZAR_ASPIRANTE_TABLADOCUMENTACION", datos, parametros);
            if (resultUpdate > 0) 
            {
                XtraMessageBox.Show("La información se actualizó correctamente." , "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Close();   

            }
            else
            
            {
                throw new Exception("Proceso terminado con errores,la información NO se actualizó.");

            }
        }

        private void simpleButton_createCartaCompromiso_Click(object sender, EventArgs e)
        {

            ////se valida que no exista info de la curp selecionada
            if (validarCartaCompromisoExistente() == 1)
            {
                XtraMessageBox.Show("Existe una carta compromiso pendiente, finalicela o cancelela para poder generar una nueva.", "Carta comrpomiso pendiente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mostrarCartaCompromiso(CURP);
                return;
            }
            simpleButton_save_Click(sender, e); ///SE GUARADAN CAMBIOS POR SI NO LOS HA GUARDADO EL USUARIO
            try
            {

                ////SE SOLICTA LA FECHA DE VENCIMIENTO
                XtraInputBoxArgs args = new XtraInputBoxArgs();
                DateEdit editor = new DateEdit();
                args.Editor = editor;
                args.Caption = "Fecha limite";
                args.Prompt = "Ingrese la fecha limite para la entrega de documentos:";
                args.DefaultResponse = DateTime.Now;
                var resultado = XtraInputBox.Show(args);
                DateTime fechaLimite = Convert.ToDateTime(string.IsNullOrEmpty(Convert.ToString(resultado)) ? DateTime.Now.ToString() : Convert.ToString(resultado));

                splashScreenManager1.ShowWaitForm();
                ArrayList rowsPrev;
               int numDocsSelect = gridView_docs.SelectedRowsCount;
                if (numDocsSelect == 0)
                {
                    if (splashScreenManager1.IsSplashFormVisible)
                        splashScreenManager1.CloseWaitForm();
                    XtraMessageBox.Show("Selecciona al menos un documento para generar la carta compromiso.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                rowsPrev = new ArrayList();
                for (int vp = 0; vp < gridView_docs.SelectedRowsCount; vp++)
                {
                    /////se agregan las filas seleccionada a la lista
                    if (gridView_docs.GetSelectedRows()[vp] >= 0)
                    {
                        rowsPrev.Add(gridView_docs.GetDataRow(gridView_docs.GetSelectedRows()[vp]));
                    }
                }
                /////CONFIRMACION DEL NUMERO DE ARCHIVOS CON EL QUE DESEA GENERAR LA CARTA
                if (XtraMessageBox.Show("¿Desea generar una carta compromiso con " + rowsPrev.Count.ToString() + " docuementos pendientes?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)!=DialogResult.Yes)
                {
                    ///SI NO RESPONDE 'SI' SE CANCELA EL PROCESO
                    XtraMessageBox.Show("Proceso cancelado","Cancelado",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                    
                }

                crearDTcartaCompromiso();
               
                /////SE RECORRE LA LISTA CREADA Y SE OBTIENEN LOS DATOS NECESARIOS
                for (int i = 0; i < rowsPrev.Count; i++)
                {
                    

                    DataRow row = rowsPrev[i] as DataRow;

                    string observacionesDoc = Convert.ToString(row["observaciones"]);////LAS OBESERVACIONES DEBEN SER OBLIGATORIAS PARA UNA CARTA COMPROMISO
                    if (string.IsNullOrEmpty(observacionesDoc))
                    {
                        throw new Exception("Debe agregar observaciones a todo los docuemntos seleccionados.");
                        
                    }
                    string idDocumento = Convert.ToString(row["idDocumento"]);

                    dtCartaCompromiso.Rows.Add(textEdit_CURP.Text,idDocumento,variables.varUser,fechaLimite,1);
                }
                int resulInsert = insertCartaCompromiso();
                if (resulInsert == 1)
                {
                    /////Se muestra carta compromiso
                    if (splashScreenManager1.IsSplashFormVisible)
                        splashScreenManager1.CloseWaitForm();
                    mostrarCartaCompromiso(CURP);
                   

                    XtraMessageBox.Show("La carta compromiso se generó correctamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (resulInsert==0)
                {
                    ////No se pudo insertar se muestra mensaje de error
                    if (splashScreenManager1.IsSplashFormVisible)
                    splashScreenManager1.CloseWaitForm();
                }

            }
            catch (Exception exs)
            {
                if (splashScreenManager1.IsSplashFormVisible)
                    splashScreenManager1.CloseWaitForm();
                XtraMessageBox.Show("Error al generar la carta comrpomiso " + exs.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void mostrarCartaCompromiso(string CURP)
        {
            Reportes.CartaCompromiso rptCartaCompromiso = new Reportes.CartaCompromiso();
            rptCartaCompromiso.sqlDataSource1.ConnectionParameters = Utilerias.GetConnectionParametersBase();
            rptCartaCompromiso.Parameters["CURP"].Value = CURP;
            rptCartaCompromiso.RequestParameters = false;
            ReportPrintTool p = new ReportPrintTool(rptCartaCompromiso);
            p.AutoShowParametersPanel = false;
            p.ShowPreview();
        }
        DataTable dtCartaCompromiso;
        private void crearDTcartaCompromiso()
        {
            dtCartaCompromiso = new DataTable();
            dtCartaCompromiso.Columns.Add("CURP");
            dtCartaCompromiso.Columns.Add("idDocumento", typeof(int));
            dtCartaCompromiso.Columns.Add("usuarioRegistro");
            dtCartaCompromiso.Columns.Add("fechaLimite", typeof(DateTime));
            dtCartaCompromiso.Columns.Add("estado", typeof(int)); 
        }
        private int validarCartaCompromisoExistente()
        {
            ////SE VALIDA SI YA EXISTEN DATOS DE UNA CARTA COMPROMISO EN ESTADO PENDIENTE
            datos = new object[] { };
            parametros = new string[] { };
            DataSet dsCartaCompromiso= new DataSet();
            dsCartaCompromiso = Utilerias.consultarProcedimiento("SIGE_CONSULTAR_CARTACOMPROMISO", datos,parametros);
            if (dsCartaCompromiso.Tables[0].Rows.Count>0)
            {
                /////EXISTE CARTA CON ESTADO PENDIENTE
                return 1;
            }
            else
            {
                ////NO EXISTE CARTA PENDIENTE, SE PUEDE REALIZAR UNA NUEVA
                return 0;

            }
        }
        private int insertCartaCompromiso()
        {
            try
            {
                datos = new object[] {dtCartaCompromiso };
                parametros = new string[] { "@tableishon" };
                int resulInsert = Utilerias.ejecutarprocedimiento("SIGE_INSERTAR_CARTACOMPROMISO", datos, parametros);
                return resulInsert;
            }
            catch { return 0; }
            
            
           
        }

    }
}