using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using System.Data.SqlClient;

namespace SIGE_Project.Configuraciones
{
    public partial class Configmenus : DevExpress.XtraEditors.XtraForm
    {
        public Configmenus()
        {
            InitializeComponent();
        }
        int focopestaña, focogrupo, focoactivoi;
        private void Configmenus_Load(object sender, EventArgs e)
        {
            cargapestañas();
            cargagrupos();
            cargabotones();

        }
        Utilerias util = new Utilerias();
        private void cargapestañas()
        {
            //zona limpieza
            gridControlpestañas.DataSource = null;
            gridViewpestañas.Columns.Clear();

            var _with1 = gridControlpestañas;
            string sqlpest = "select distinct idPestaña,Pestaña from  [SIGE_Configuracion_Menus]  order by idpestaña";
            _with1.DataSource = util.ejecutarQueryDataset("Pestañas", sqlpest);
            _with1.DataMember = "Pestañas";
            gridViewpestañas.FocusedRowHandle = focopestaña;
        }

        private void cargagrupos()
        {
            gridControlgrupos.DataSource = null;
            gridViewgrupos.Columns.Clear();
            var _with2 = gridControlgrupos;
            string sqlgrup = "select distinct idpestaña, pestaña,idCat,Categoria from  [SIGE_Configuracion_Menus]  order by  idpestaña,idcat";
            _with2.DataSource = util.ejecutarQueryDataset("grupos", sqlgrup);
            _with2.DataMember = "grupos";
            //  gridViewgrupos.OptionsView.ShowGroupedColumns = true; //con esta instruccion muestra tambien la columna agrupada en el gridview
            gridViewgrupos.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office2003;
            gridViewgrupos.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            gridViewgrupos.OptionsBehavior.AutoExpandAllGroups = true;
            gridViewgrupos.Columns["idpestaña"].Visible = false;

            GridColumn colReceived = gridViewgrupos.Columns["pestaña"];
            //    GridColumn colRead = gridViewgrupos.Columns["Read"];
            gridViewgrupos.SortInfo.ClearAndAddRange(new GridColumnSortInfo[] { 
        new GridColumnSortInfo(colReceived, DevExpress.Data.ColumnSortOrder.None),
        //new GridColumnSortInfo(colRead, DevExpress.Data.ColumnSortOrder.Ascending),
        }, 1);//aqui el numero de datos a agrupar
            gridViewgrupos.Columns["idCat"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            gridViewgrupos.FocusedRowHandle = focogrupo;
        }


        private void cargabotones()
        {
            gridControlbotones.DataSource = null;
            gridViewbotones.Columns.Clear();

            var _with3 = gridControlbotones;
            string sqlbot = "select idpestaña, pestaña, Categoria,idCat,iditem,Item,ubicform,Imagen,id   from  [SIGE_Configuracion_Menus]  order by idpestaña, idcat, idItem";
            _with3.DataSource = util.ejecutarQueryDataset("botones", sqlbot);
            _with3.DataMember = "botones";
            gridViewbotones.Columns["idpestaña"].Visible = false;
            gridViewbotones.Columns["id"].Visible = false;
            //  gridViewgrupos.OptionsView.ShowGroupedColumns = true; //con esta instruccion muestra tambien la columna agrupada en el gridview
            gridViewbotones.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Default;
            //gridViewbotones.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            gridViewbotones.OptionsBehavior.AutoExpandAllGroups = true;


            GridColumn colpesta = gridViewbotones.Columns["pestaña"];
            GridColumn colcodcat = gridViewbotones.Columns["iddCat"];
            GridColumn colcat = gridViewbotones.Columns["Categoria"];
            gridViewbotones.SortInfo.ClearAndAddRange(new GridColumnSortInfo[] { 
        new GridColumnSortInfo(colpesta, DevExpress.Data.ColumnSortOrder.None),
new GridColumnSortInfo(colcodcat, DevExpress.Data.ColumnSortOrder.Ascending),
new GridColumnSortInfo(colcat , DevExpress.Data.ColumnSortOrder.None),
        }, 2);//aqui el numero de datos a agrupar
            gridViewbotones.Columns["iditem"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            gridViewbotones.FocusedRowHandle = focoactivoi;

        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (xtraTabControl1.SelectedTabPageIndex == 0)
            {
                Configuraciones.AgregarPestanias addpest = new Configuraciones.AgregarPestanias();
                System.Windows.Forms.DialogResult _respuesta = addpest.ShowDialog();
                if (_respuesta == System.Windows.Forms.DialogResult.OK)
                {
                    decimal idpest = Convert.ToDecimal(addpest.textEdit_idPestania.Text);
                    string nombrepest = addpest.textEdit_descripcion.Text;
                    if (Convert.ToInt32(util.EjecutarQueryEscalar("select count(*) from  [SIGE_Configuracion_Menus] where idpestaña =" + idpest)) <= 0)
                    {
                        util.EjecutarQueryNonQuery("insert into  [SIGE_Configuracion_Menus] (idpestaña,Pestaña)values(" + idpest + ",'" + nombrepest + "')");

                        // RibbonControl1.Pages[0].Groups[0].ItemLinks.Add(galleryBarItem);
                        cargapestañas();
                        cargagrupos();
                        //  CreatNewRow(idpest, nombrepest);
                    }
                    else
                    {
                        XtraMessageBox.Show("Ya existe la clave para la pestaña", "Clave existente", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                }
            }
            else if (xtraTabControl1.SelectedTabPageIndex == 1)
            {
                Configuraciones.AgregarrCategoria addcat = new Configuraciones.AgregarrCategoria();
                System.Windows.Forms.DialogResult _respuesta = addcat.ShowDialog();
                if (_respuesta == System.Windows.Forms.DialogResult.OK)
                {
                    string idpestaña = Convert.ToString(gridViewgrupos.GetRowCellValue(gridViewgrupos.FocusedRowHandle, "idpestaña"));
                    string nompestaña = Convert.ToString(gridViewgrupos.GetRowCellValue(gridViewgrupos.FocusedRowHandle, "pestaña"));

                    if (string.IsNullOrEmpty(idpestaña))
                    {
                        var groupRow = gridViewgrupos.GetFocusedValue();
                        idpestaña = util.obtenerdato("select idpestaña from  [SIGE_Configuracion_Menus]  where pestaña='" + groupRow + "'");
                        nompestaña = Convert.ToString(groupRow);
                    }

                    int idcat = Convert.ToInt32(addcat.textEdit_idMenu.Text);
                    string nombrecat = addcat.textEdit_decripcion.Text;
                    if (Convert.ToUInt32(util.EjecutarQueryEscalar("select count(*) from  [SIGE_Configuracion_Menus] where idpestaña =" + idpestaña + " and idcat is null ")) >= 1)
                    {

                        util.EjecutarQueryNonQuery("update  [SIGE_Configuracion_Menus] set idCat =" + idcat + " ,Categoria ='" + nombrecat + "' where  idpestaña =" + idpestaña);
                        cargagrupos();
                        cargabotones();

                    }
                    else
                    {
                        if (Convert.ToInt32(util.EjecutarQueryEscalar("select count(*) from  [SIGE_Configuracion_Menus] where idpestaña =" + idpestaña + " and idcat=" + idcat)) <= 0)
                        {
                            util.EjecutarQueryNonQuery("insert into [SIGE_Configuracion_Menus] ([idpestaña]      ,[Pestaña]      ,[Categoria]      ,[idCat]  )values(" + idpestaña + ",'" + nompestaña + "','" + nombrecat + "'," + idcat + " )");
                            cargagrupos();
                            cargabotones();
                        }
                        else
                        {
                            XtraMessageBox.Show("Ya existe la clave para la Categoria,\r\n Elija otra", "Clave existente", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }

                    }
                }

            }
            else if (xtraTabControl1.SelectedTabPageIndex == 2)
            {

                string idpestaña = Convert.ToString(gridViewbotones.GetRowCellValue(gridViewbotones.FocusedRowHandle, "idpestaña"));
                string idcat = Convert.ToString(gridViewbotones.GetRowCellValue(gridViewbotones.FocusedRowHandle, "idCat"));
                string npestaña = Convert.ToString(gridViewbotones.GetRowCellValue(gridViewbotones.FocusedRowHandle, "pestaña"));
                string ncat = Convert.ToString(gridViewbotones.GetRowCellValue(gridViewbotones.FocusedRowHandle, "Categoria"));

                if (string.IsNullOrEmpty(idpestaña))
                {
                    var codcat = gridViewbotones.GetFocusedValue();
                    //**********************************************+



                    int intIndex = gridViewbotones.SourceRowHandle;
                    int ParentRowHandle = gridViewbotones.GetParentRowHandle(gridViewbotones.FocusedRowHandle);
                    DataRow parentRow = gridViewbotones.GetDataRow(ParentRowHandle);


                    idpestaña = Convert.ToString(parentRow.ItemArray[0]);
                    npestaña = Convert.ToString(parentRow.ItemArray[1]);
                    idcat = Convert.ToString(codcat);
                    if (string.IsNullOrEmpty(idcat))
                    {
                        XtraMessageBox.Show("Debe agregar una categoria antes de agregar un boton", "Sin categoria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;

                    }
                    ncat = util.obtenerdato("select categoria from  [SIGE_Configuracion_Menus]  where idpestaña=" + idpestaña + " and codcat=" + idcat);


                    //********************************************+

                }

                Configuraciones.AgregarBotones addbot = new Configuraciones.AgregarBotones();

                System.Windows.Forms.DialogResult _respuesta = addbot.ShowDialog();



                if (_respuesta == System.Windows.Forms.DialogResult.OK)
                {

                    string coditem = (addbot.textEdit_idBoton.Text);
                    string nombrebot = addbot.textEdit_nombreBoton.Text;
                    string raplicacion = Convert.ToString(addbot.textEdit_aplicacion.Text);
                    if (Convert.ToUInt32(util.EjecutarQueryEscalar("select count(*) from  [SIGE_Configuracion_Menus] where idpestaña =" + idpestaña + " and idcat=" + idcat + "and idItem  is null ")) >= 1)
                    {

                        SqlConnection cnn = new SqlConnection(Properties.Settings.Default.CadenaConexion);
                        SqlCommand cmd;
                        try
                        {
                            cnn.Open();
                            string sql_c = "update  [SIGE_Configuracion_Menus] set idItem =@CodItem  ,item=@Item, ubicform =@NomUbiform,imagen=@imagen where  idpestaña =@id_pestaña and idcat=@codcat";
                            cmd = new SqlCommand(sql_c, cnn);
                            cmd.Parameters.Add("@CodItem", SqlDbType.Money).Value = coditem;
                            cmd.Parameters.Add("@Item", SqlDbType.VarChar).Value = nombrebot;
                            cmd.Parameters.Add("@NomUbiform", SqlDbType.VarChar).Value = raplicacion;
                            cmd.Parameters.Add("@imagen", SqlDbType.Image).Value = util.Image2Bytes(addbot.pictureEdit_imgBoton.Image);
                            cmd.Parameters.Add("@id_pestaña", SqlDbType.Money).Value = idpestaña;
                            cmd.Parameters.Add("@codcat", SqlDbType.Money).Value = idcat;
                            int i = cmd.ExecuteNonQuery();
                            cnn.Close();
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show("Error", "Ocurrio un error: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            if (cnn.State == ConnectionState.Open)
                                cnn.Close();
                        }


                        cargagrupos();
                        cargabotones();
                    }
                    else
                    {
                        if (Convert.ToInt32(util.EjecutarQueryEscalar("select count(*) from  [SIGE_Configuracion_Menus] where  idpestaña =" + idpestaña + " and idcat=" + idcat + " and idItem =" + coditem)) <= 0)
                        {

                            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.CadenaConexion);
                            SqlCommand cmd;
                            try
                            {
                                cnn.Open();
                                string sql_c = "insert into [[SIGE_Configuracion_Menus]](  [idpestaña]      ,[Pestaña]      ,[Categoria]      ,[idCat]  ,[Item]      ,[idItem]      ,[ubicform]      ,[Imagen])values(@id_pestaña,@pestaña,@categoria,@codcat ,@Item, @CodItem,@NomUbiform,@imagen  )";
                                cmd = new SqlCommand(sql_c, cnn);
                                cmd.Parameters.Add("@CodItem", SqlDbType.Money).Value = coditem;
                                cmd.Parameters.Add("@pestaña", SqlDbType.VarChar).Value = npestaña;
                                cmd.Parameters.Add("@categoria", SqlDbType.VarChar).Value = ncat;
                                cmd.Parameters.Add("@Item", SqlDbType.VarChar).Value = nombrebot;
                                cmd.Parameters.Add("@NomUbiform", SqlDbType.VarChar).Value = raplicacion;
                                cmd.Parameters.Add("@imagen", SqlDbType.Image).Value = util.Image2Bytes(addbot.pictureEdit_imgBoton.Image);
                                cmd.Parameters.Add("@id_pestaña", SqlDbType.Money).Value = idpestaña;
                                cmd.Parameters.Add("@codcat", SqlDbType.Money).Value = idcat;
                                int i = cmd.ExecuteNonQuery();
                                cnn.Close();
                            }
                            catch (Exception ex)
                            {
                                XtraMessageBox.Show("Error", "Ocurrio un error: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                if (cnn.State == ConnectionState.Open)
                                    cnn.Close();
                            }

                            cargabotones();

                        }
                        else
                        {
                            XtraMessageBox.Show("Ya existe la clave para el boton\r \n Elija otra", "Clave existente", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }

                    }
                }
            }
            cargagrid();

        }
        private void cargagrid()
        {
            gridControl1.DataSource = null;
            menusDataGridView.Columns.Clear();

            var _with1 = gridControl1;
            string sqlpest = "select idpestaña as id,Pestaña,idCat,Categoria,idItem,Item,ubicform as Ubicacion,Imagen from  [SIGE_Configuracion_Menus]  order by idpestaña,idcat, idItem";
            _with1.DataSource = util.ejecutarQueryDataset("Menus", sqlpest);
            _with1.DataMember = "Menus";

            menusDataGridView.BestFitColumns();
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (xtraTabControl1.SelectedTabPageIndex == 0)
            {


                string idpestaña = Convert.ToString(gridViewpestañas.GetRowCellValue(gridViewpestañas.FocusedRowHandle, "idPestaña"));
                string nompestaña = Convert.ToString(gridViewpestañas.GetRowCellValue(gridViewpestañas.FocusedRowHandle, "Pestaña"));


                Configuraciones.AgregarPestanias addpest = new Configuraciones.AgregarPestanias(idpestaña, nompestaña);
                System.Windows.Forms.DialogResult _respuesta = addpest.ShowDialog();
                if (_respuesta == System.Windows.Forms.DialogResult.OK)
                {
                    //int idpest = Convert.ToInt32(addpest.txtidpest.Text);
                    string nombrepest = addpest.textEdit_descripcion.Text;

                    util.EjecutarQueryNonQuery("update  [SIGE_Configuracion_Menus] set Pestaña='" + nombrepest + "' where idpestaña=" + idpestaña);

                    cargapestañas();
                    cargabotones();
                    cargagrupos();
                    cargagrid();

                }
            }
            else if (xtraTabControl1.SelectedTabPageIndex == 1)
            {

                string idpestaña = Convert.ToString(gridViewgrupos.GetRowCellValue(gridViewgrupos.FocusedRowHandle, "idpestaña"));
                string idgrupo = Convert.ToString(gridViewgrupos.GetRowCellValue(gridViewgrupos.FocusedRowHandle, "idCat"));
                string nomgrupo = Convert.ToString(gridViewgrupos.GetRowCellValue(gridViewgrupos.FocusedRowHandle, "Categoria"));

                Configuraciones.AgregarrCategoria addcat = new Configuraciones.AgregarrCategoria(idgrupo, nomgrupo);
                System.Windows.Forms.DialogResult _respuesta = addcat.ShowDialog();
                if (_respuesta == System.Windows.Forms.DialogResult.OK)
                {

                    string nombrecat = addcat.textEdit_decripcion.Text;

                    util.EjecutarQueryNonQuery("update  [SIGE_Configuracion_Menus]  set Categoria ='" + nombrecat + "' where  idpestaña =" + idpestaña + " and idCat =" + idgrupo);
                    cargagrupos();
                    cargabotones();
                    cargagrid();


                }

            }
            else if (xtraTabControl1.SelectedTabPageIndex == 2)
            {
                string idpestaña = Convert.ToString(gridViewbotones.GetRowCellValue(gridViewbotones.FocusedRowHandle, "idpestaña"));
                string idcat = Convert.ToString(gridViewbotones.GetRowCellValue(gridViewbotones.FocusedRowHandle, "idCat"));
                string iditem = Convert.ToString(gridViewbotones.GetRowCellValue(gridViewbotones.FocusedRowHandle, "iditem"));
                string nomitem = Convert.ToString(gridViewbotones.GetRowCellValue(gridViewbotones.FocusedRowHandle, "Item"));
                string raplicacion = Convert.ToString(gridViewbotones.GetRowCellValue(gridViewbotones.FocusedRowHandle, "ubicform"));
                //,,,,Imagen

                if (string.IsNullOrEmpty(iditem))
                {
                    XtraMessageBox.Show("No ahi boton en esta session", "Sin boton", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                Configuraciones.AgregarBotones addbot = new Configuraciones.AgregarBotones(Convert.ToDecimal(idpestaña), Convert.ToDecimal(idcat), Convert.ToDecimal(iditem), nomitem, raplicacion);
                //configuraciones.frmaddbotones addbot = new frmaddbotones(Convert.ToInt32(idpestaña), Convert.ToInt32(idcat), Convert.ToInt32(iditem), nomitem, raplicacion);
                System.Windows.Forms.DialogResult _respuesta = addbot.ShowDialog();
                if (_respuesta == System.Windows.Forms.DialogResult.OK)
                {



                    string nombrebot = addbot.textEdit_nombreBoton.Text;
                    raplicacion = Convert.ToString(addbot.textEdit_aplicacion.Text);




                    SqlConnection cnn = new SqlConnection(Properties.Settings.Default.CadenaConexion);
                    SqlCommand cmd;
                    try
                    {
                        cnn.Open();
                        string sql_c = " update  [SIGE_Configuracion_Menus] set Item  =@Item,ubicform=@NomUbiform,Imagen=@imagen where  idpestaña =@id_pestaña and idcat=@codcat and idItem =@CodItem";
                        cmd = new SqlCommand(sql_c, cnn);
                        cmd.Parameters.Add("@CodItem", SqlDbType.Money).Value = iditem;
                        cmd.Parameters.Add("@Item", SqlDbType.VarChar).Value = nombrebot;
                        cmd.Parameters.Add("@NomUbiform", SqlDbType.VarChar).Value = raplicacion;
                        cmd.Parameters.Add("@imagen", SqlDbType.Image).Value = util.Image2Bytes(addbot.pictureEdit_imgBoton.Image);
                        cmd.Parameters.Add("@id_pestaña", SqlDbType.Money).Value = idpestaña;
                        cmd.Parameters.Add("@codcat", SqlDbType.Money).Value = idcat;
                        int i = cmd.ExecuteNonQuery();
                        cnn.Close();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Ocurrio un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (cnn.State == ConnectionState.Open)
                            cnn.Close();
                    }
                    cargabotones();
                    cargagrid();


                }
            }

        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
          {
            if (xtraTabControl1.SelectedTabPageIndex == 0)
            {
                string idpestaña = Convert.ToString(gridViewpestañas.GetRowCellValue(gridViewpestañas.FocusedRowHandle, "idPestaña"));


                if (Convert.ToInt32(util.EjecutarQueryEscalar("select count(*) from  [SIGE_Configuracion_Menus] where idpestaña =" + idpestaña + " and idcat is null")) == 0)
                {
                    if (XtraMessageBox.Show("Esta pestaña contiene categorias existentes,... \r\n ¿Desea continuar Eliminando esta Pestaña?", "Existentes...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                    {
                        util.EjecutarQueryNonQuery("delete from [[SIGE_Configuracion_Menus]] where  idpestaña =" + idpestaña);
                        cargapestañas();
                        cargagrupos();
                        cargabotones();
                        cargagrid();
                    }

                }
                else
                {
                    if (XtraMessageBox.Show("¿Desea Eliminar esta Pestaña?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        util.EjecutarQueryNonQuery("delete from [[SIGE_Configuracion_Menus]] where  idpestaña =" + idpestaña);
                        cargapestañas();
                        cargagrupos();
                        cargabotones();
                        cargagrid();
                    }
                }
            }
            else if (xtraTabControl1.SelectedTabPageIndex == 1)
            {

                string idpestaña = Convert.ToString(gridViewgrupos.GetRowCellValue(gridViewgrupos.FocusedRowHandle, "idpestaña"));
                string idcat = Convert.ToString(gridViewgrupos.GetRowCellValue(gridViewgrupos.FocusedRowHandle, "idCat"));
                string id = Convert.ToString(gridViewgrupos.GetRowCellValue(gridViewgrupos.FocusedRowHandle, "id"));

                if (string.IsNullOrEmpty(idpestaña))
                {

                    DataRow parentRow = gridViewgrupos.GetFocusedDataRow();//ParentRowHandle);

                    idpestaña = Convert.ToString(parentRow.ItemArray[0]);
                    idcat = Convert.ToString(parentRow.ItemArray[2]);

                }

                if (Convert.ToInt32(util.EjecutarQueryEscalar("select count(*) from  [SIGE_Configuracion_Menus] where idpestaña =" + idpestaña + " and idcat=" + idcat + " and idItem is null ")) == 0)
                {
                    if (XtraMessageBox.Show("Esta Categoria contiene botones existentes,...\r \n ¿Desea continuar Eliminando esta categoria?", "Existentes...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                    {
                        util.EjecutarQueryNonQuery("delete from [[SIGE_Configuracion_Menus]] where   idpestaña =" + idpestaña + " and idcat =" + idcat);

                        cargagrupos();
                        cargabotones();
                        cargagrid();
                    }

                }
                else
                {
                    if (XtraMessageBox.Show("¿Desea Eliminar esta Pestaña?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                    {
                        util.EjecutarQueryNonQuery("delete from [[SIGE_Configuracion_Menus]] where   idpestaña =" + idpestaña + " and idcat =" + idcat);
                        cargagrupos();
                        cargabotones();
                        cargagrid();
                    }
                }

            }
            else if (xtraTabControl1.SelectedTabPageIndex == 2)
            {

                string id = Convert.ToString(gridViewbotones.GetRowCellValue(gridViewbotones.FocusedRowHandle, "id"));



                if (XtraMessageBox.Show("¿Desea Eliminar este boton?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    util.EjecutarQueryNonQuery("delete from [[SIGE_Configuracion_Menus]] where   id =" + id);
                    cargabotones();
                    cargagrid();
                }





            }
        }

    }
}