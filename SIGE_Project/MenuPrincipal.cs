using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Localization;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraTabbedMdi;
using DevExpress.XtraWaitForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGE_Project
{

    public partial class MenuPrincipal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Utilerias util = new Utilerias();
        Timer TimerReloj = new Timer();
        SqlConnection cnn = new SqlConnection(Properties.Settings.Default.CadenaConexion);

        public MenuPrincipal()
        {
            InitializeComponent();
            barStaticItem1.Caption = "Usuario: " + variables.varUser;
            barStaticItem3.Caption = variables.nombreCompleto;
            //barStaticItem4.Caption = "Sucursal: " + getNombreSursal();
            TimerReloj.Interval = 1000;
            TimerReloj.Tick += new EventHandler(Reloj);
            TimerReloj.Enabled = true;
        }
        public void itemOpen_ItemClick(object sender, ItemClickEventArgs e)
        {

            string cad = "";
            string nombreform;
            cad = e.Item.Name;
            DialogResult result;
            switch (e.Item.Name)
            {

                case "30.0010.00Salir10.00.png":
                    result = XtraMessageBox.Show(this, "¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);


                    if (result == DialogResult.Yes)
                    {
                        Application.ExitThread();


                    }
                    else
                    {
                        return;
                    }
                    break;
                case "10.0010.00Aperturardía10.00.png":
                    //realizarApertura();
                    return;
                    break;
                case "10.0010.00Aperturarcaja20.00.png":
                    //aperturarCaja();
                    return;
                    break;
                case "10.0010.00Cerrarcaja40.00.png":
                    //cerrarCaja();
                    return;
                    break;

                case "10.0010.00Cerrardía50.00.png":
                    //realizarCierreDia();
                    return;
                    break;
                //case "6010ConsultaRequisiciones20.png":

                //    Requisiciones.ConsultaRequisiciones frm4 = new Requisiciones.ConsultaRequisiciones(Variables.var_cveare);
                //        frm4.MdiParent = this;
                //        frm4.Show();
                //        return;
                //        break;
                //case "10.0010.00Minimizar20.00.png":

                //    WindowState = FormWindowState.Minimized;
                //    return;
                //    break;



                case "30.0010.00Actualizarsistema20.00.png":

                    try
                    {
                        //splashScreenManager1.ShowWaitForm();
                        InstallUpdateSyncWithInfo();
                        //splashScreenManager2.CloseWaitForm();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    return;
                    break;

                case "30.0010.00Cambiarsucursal60.00.png":
                    //Configuraciones.selectSucursal obj = new Configuraciones.selectSucursal();
                    //DialogResult dResult = obj.ShowDialog();
                    //if (dResult == DialogResult.OK)
                    //{
                    //    barStaticItem4.Caption = "Sucursal: " + variables.nombreSuc;
                    //}
                    return;
                    break;

                    //case "10.0050.00Cambiardeempresa30.00.png":
                    //    SeleccionarEmpresa x = new SeleccionarEmpresa();
                    //    System.Windows.Forms.DialogResult okk = x.ShowDialog();
                    //    if (okk == System.Windows.Forms.DialogResult.OK)
                    //    {
                    //        barStaticItem4.Caption = Variables.varNomEmpresa;
                    //        barStaticItem6.Caption = Variables.rfc;
                    //    }
                    //    return;

                    //Trafico.frmprogramarviaje progviajes = new Trafico.frmprogramarviaje();
                    ////progviajes.MdiParent = this;
                    //progviajes.Show();
                    //return;
                    break;
                case "110.0010.00DescargamasivaSAT5.00.png":
                    //object[] dats = { DateTime.Now.ToShortDateString(), Variables.rfc };
                    //string[] parr = { "@fecha", "@rfccc" };
                    //DataSet descargados = Utilerias.consultarprocedimientoSAT("ERP_FAC_ObtenerTotaldescargadosXRFC", dats, parr);

                    //if (Convert.ToInt32(descargados.Tables[0].Rows[0]["totaldescargados"].ToString()) >= 2000)
                    //{
                    //    XtraMessageBox.Show("No se pueden descargar mas de 2000 archivos por día.", "Descargas excedidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //}
                    //else
                    //{


                    //    string searchWithinThis = Application.UserAppDataPath;
                    //    string searchForThis = "Local";
                    //    int firstCharacter = searchWithinThis.IndexOf(searchForThis);
                    //    string cadenaroaming = (Application.UserAppDataPath.Substring(0, firstCharacter) + @"Roaming\Microsoft\Windows\Start Menu\Programs\ConsorcioEstival");
                    //    string path = Path.Combine(cadenaroaming, "DescargaMasivaSAT.appref-ms");
                    //    Process.Start(path);
                    //}
                    //return;
                    break;

                case "50.0010.00ServidorSIFAR_DATA10.00.png":
                    System.Diagnostics.Process.Start("C:\\Program Files\\Internet Explorer\\IExplore.exe", "http://simiserver.estivalsistemas.com/sifar/SIFAR_DATA/SIFAR_DATA.application");
                    return;
                    break;

                case "50.0010.00ServidorSIFAR_FAC20.00.png":
                    System.Diagnostics.Process.Start("C:\\Program Files\\Internet Explorer\\IExplore.exe", "http://simiserver.estivalsistemas.com/sifar/SIFAR_FAC2.0/SIFAR_FAC2.application");
                    return;
                    break;

            }
            //SqlCommand cm = new SqlCommand("select nomubiform from [SIGE_Configuracion_Menus] where replace((replace(item,' ','')+convert(varchar,coditem)+'.png'),'/','')='" + cad + "'", cnn);
            SqlCommand cm = new SqlCommand("select ubicform from [SIGE_Configuracion_Menus] where replace((convert(varchar,idpestaña)+convert(varchar,idcat) + replace(item,' ','')+convert(varchar,iditem)+'.png'),'/','')='" + cad + "'", cnn);
            
            SqlDataReader dr;
            cnn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                nombreform = dr["ubicform"].ToString();
                if (!string.IsNullOrEmpty(nombreform))
                {
                    mostrarForm(nombreform);
                }
                else
                {
                    MessageBox.Show("Módulo en Proceso de Desarrollo", "Desarrollo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            cnn.Close();
            


        }
        public void InstallUpdateSyncWithInfo()
        {
            UpdateCheckInfo info = null;

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;

                try
                {
                    info = ad.CheckForDetailedUpdate();

                }
                catch (DeploymentDownloadException dde)
                {
                    XtraMessageBox.Show("La nueva versión de la aplicación no se puede descargar en este momento. \n\n Verifique la conexión de red o vuelva a intentarlo más tarde. Error: " + dde.Message);
                    return;
                }
                catch (InvalidDeploymentException ide)
                {
                    XtraMessageBox.Show("No se puede comprobar si hay una nueva versión de la aplicación. El despliegue de ClickOnce está dañado. Vuelva a distribuir la aplicación e inténtelo de nuevo. Error:" + ide.Message);
                    return;
                }
                catch (InvalidOperationException ioe)
                {
                    XtraMessageBox.Show("Esta aplicación no se puede actualizar. Es probable que no sea una aplicación ClickOnce. Error: " + ioe.Message);
                    return;
                }

                if (info.UpdateAvailable)
                {
                    Boolean doUpdate = true;

                    if (!info.IsUpdateRequired)
                    {
                        //splashScreenManager1.CloseWaitForm();
                        DialogResult dr = XtraMessageBox.Show("Hay disponible una actualización. ¿Desea actualizar la aplicación ahora?", "Actualización disponible", MessageBoxButtons.OKCancel);
                        //splashScreenManager1.ShowWaitForm();
                        if (!(DialogResult.OK == dr))
                        {
                            doUpdate = false;
                        }
                    }
                    else
                    {
                        // Display a message that the app MUST reboot. Display the minimum required version.
                        XtraMessageBox.Show("Esta aplicación ha detectado una actualización obligatoria de su " +
                            "versión a versión " + info.MinimumRequiredVersion.ToString() + ".\n" +
                            "La aplicación ahora instalará la actualización y reiniciará.",
                            "Actualización disponible", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    if (doUpdate)
                    {
                        try
                        {
                            ad.Update();
                            //splashScreenManager1.CloseWaitForm();
                            XtraMessageBox.Show("Se ha actualizado la aplicación y se reiniciará.", "Actualización correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            u.reiniciarApplicacion();
                            //Application.Restart();
                        }
                        catch (DeploymentDownloadException dde)
                        {
                            XtraMessageBox.Show("No se puede instalar la última versión de la aplicación. \n\n Verifique la conexión de red o vuelva a intentarlo más tarde. Error: " + dde);
                            return;
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("No existen actualizaciones para el sistema", "El sistema esta actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    //splashScreenManager1.CloseWaitForm();
                    XtraMessageBox.Show("No existen actualizaciones para el sistema", "El sistema esta actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show("El sistema no es un aplicativo ClickOnce", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            Image tnImage;
            string sql = "";
            this.Text = " SIGE --" + this.Text + "-- Versión." + obtenerversioninsatalada();
            //this.Text = this.Text + "- Versión: " + obtenerversioninsatalada();
            if (variables.tipoUser.Equals("ADMIN")) //"ADMINISTRADOR"))
            
            {
                sql = "select pestaña,categoria,idcat,item,replace((convert(varchar,idpestaña)+convert(varchar,idcat) + replace(item,' ','')+convert(varchar,iditem)+'.png'),'/','') id_item,Imagen  from [SIGE_Configuracion_Menus] order by idpestaña, idcat, idItem";

            }
            else
            {
                sql = "  select pestaña,categoria,mn.idCat,mn.item "
                    + "  ,replace((convert(varchar,mn.idPestaña)+convert(varchar,mn.idCat) +"
                    + "  replace(mn.item,' ','')+convert(varchar,mn.idItem)+'.png'),'/','') id_item,Imagen "
                    + "  from [SIGE_Configuracion_Menus] mn,PV_Usuarios_PermisosXUsuario pr  where 1 = 1 "
                    + "  and mn.idpestaña=pr.idPestaña and mn.idcat=pr.idCat and mn.idItem=pr.iditem  "
                    + "  and upper(pr.cve_usu)=upper('" + variables.varUser + "') order by mn.idpestaña, idcat, mn.idItem";
            }

            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader dr;
            cnn.Open();
            this.Controls.Add(ribbon);
            ////Se asigna la colección de imágenes que proporcionará imágenes para los elementos de la barra
            dr = cmd.ExecuteReader();
            string pest_ant = "";
            string grup_ant = "";
            string nomimg = "";
            string pest = "";
            string grup = "";
            string itm = "";
           // bool pest_sts, cat_sts, btn_sts;
            var page1 = new RibbonPage();
            var group1 = new RibbonPageGroup();
            BarButtonItem itembutton;


            while (dr.Read())
            {
                //int p;
                pest = Convert.ToString(dr.GetValue(0));
                grup = Convert.ToString(dr.GetValue(1));
                itm = Convert.ToString(dr.GetValue(3));
                nomimg = Convert.ToString(dr.GetValue(4));

                ////Se crea Ribbon page y Ribbon group.
                if (pest_ant == "")
                {
                    page1 = new RibbonPage(pest);
                    group1 = new RibbonPageGroup(grup);
                    grup_ant = grup;
                    
                    itembutton = Ribbon.Items.CreateButton(itm);
                    itembutton.Name = nomimg;

                    if (dr["Imagen"] != DBNull.Value)
                    {
                        Image img = u.Bytes2Image((byte[])dr["Imagen"]);
                        if (img != null)
                        {
                            itembutton.LargeGlyph = img;
                        }
                    }
                    else
                    {
                        itembutton.LargeGlyph = Properties.Resources.invalido;
                    }
                        

                    itembutton.ItemClick += new ItemClickEventHandler(itemOpen_ItemClick);
                    group1.ItemLinks.Add(itembutton);
                    pest_ant = pest;
                }
                else if (pest_ant == pest)
                {
                    if (grup_ant == grup)
                    {
                        itembutton = Ribbon.Items.CreateButton(itm);
                        itembutton.Name = nomimg;

                        if (dr["Imagen"] != DBNull.Value)
                        {
                            Image img = u.Bytes2Image((byte[])dr["Imagen"]);
                            if (img != null)
                            {
                                itembutton.LargeGlyph = img;
                            }
                        }
                        else
                        {
                            itembutton.LargeGlyph = Properties.Resources.invalido;

                        }

                        itembutton.ItemClick += new ItemClickEventHandler(itemOpen_ItemClick);
                        group1.ItemLinks.Add(itembutton);
                       
                        grup_ant = grup;
                    }
                    else
                    {
                        page1.Groups.Add(group1);
                        group1 = new RibbonPageGroup(grup);
                        grup_ant = grup;
                        
                        itembutton = Ribbon.Items.CreateButton(itm);
                        itembutton.Name = nomimg;
                        if (dr["Imagen"] != DBNull.Value)
                        {
                            Image img = u.Bytes2Image((byte[])dr["Imagen"]);
                            if (img != null)
                            {
                                itembutton.LargeGlyph = img;
                            }
                        }
                        else
                            itembutton.LargeGlyph = Properties.Resources.invalido;

                        itembutton.ItemClick += new ItemClickEventHandler(itemOpen_ItemClick);
                        group1.ItemLinks.Add(itembutton);
                        //}
                        pest_ant = pest;
                    }
                }
                else
                {
                    page1.Groups.Add(group1);
                    ribbon.Pages.Add(page1);
                    page1 = new RibbonPage(pest);
                    group1 = new RibbonPageGroup(grup);
                    grup_ant = grup;
                    itembutton = Ribbon.Items.CreateButton(itm);
                    itembutton.Name = nomimg;
                    if (dr["Imagen"] != DBNull.Value)
                    {
                        Image img = u.Bytes2Image((byte[])dr["Imagen"]);
                        if (img != null)
                        {
                            itembutton.LargeGlyph = img;
                        }
                    }
                    else
                        itembutton.LargeGlyph = Properties.Resources.invalido;


                    itembutton.ItemClick += new ItemClickEventHandler(itemOpen_ItemClick);

                    group1.ItemLinks.Add(itembutton);
                    //}
                    pest_ant = pest;
                }
            }
            page1.Groups.Add(group1);
            ribbon.Pages.Add(page1);

            cnn.Close();

            //*************************************************
            RibbonGalleryBarItem galleryBarItem = new RibbonGalleryBarItem(ribbon.Manager);
            galleryBarItem.GalleryItemClick += new GalleryItemClickEventHandler(ribbonGalleryBarItem1_GalleryItemClick);
            GalleryItemGroup itemGroup1 = new GalleryItemGroup();
            galleryBarItem.Gallery.Groups.Add(itemGroup1);


            page1 = new RibbonPage("Styles");
            group1 = new RibbonPageGroup("Estilos");
            grup_ant = grup;
            //// ' Create another Ribbon page group.
            group1.ItemLinks.Add(galleryBarItem);
            page1.Groups.Add(group1);
            ribbon.Pages.Add(page1);


            BarLocalizer.Active = new MyBarLocalizer();

            SkinHelper.InitSkinGallery(galleryBarItem, true);
            SkinHelper.InitSkinPopupMenu(popupMenu1);


            //*************************************************



            /***************************Habilita los formalarios para abrir tipo Tab*************************/
            if (SIGE_Project.Properties.Settings.Default.xtratab == "1")
            {
                XtraTabbedMdiManager mdiManager = new XtraTabbedMdiManager();
                mdiManager.MdiParent = this;
                mdiManager.MdiParent.IsMdiContainer = true;
                mdiManager.MdiParent.AutoSize = true;
                mdiManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageAndTabControlHeader;
                Ribbon.MdiMergeStyle = RibbonMdiMergeStyle.Always;
            }
            /***************************Aplica el estilo guardado*************************/
            string skinName = SIGE_Project.Properties.Settings.Default.stilodev;
            if (skinName != null && (!skinName.Equals(string.Empty)))
            {
                this.defaultLookAndFeel1.LookAndFeel.SkinName = skinName;
            }

            SplashScreenManager.CloseForm(false);
        }
        public class MyBarLocalizer : BarLocalizer
        {
            public override string GetLocalizedString(BarString id)
            {
                if (id == BarString.SkinCaptions)
                {
                    string defaultSkinCaptions = base.GetLocalizedString(id);
                    string newSkinCaptions = defaultSkinCaptions.Replace("|DevExpress Style|", "|My Favorite Skin|");
                    return newSkinCaptions;
                }
                return base.GetLocalizedString(id);
            }


        }
        private string obtenerversioninsatalada()
        {
            try
            {
                return ("" + ApplicationDeployment.CurrentDeployment.CurrentVersion.Major + "." + ApplicationDeployment.CurrentDeployment.CurrentVersion.Minor + "." + ApplicationDeployment.CurrentDeployment.CurrentVersion.Build + "." + ApplicationDeployment.CurrentDeployment.CurrentVersion.Revision);
            }
            catch
            {
                return Convert.ToString(Assembly.GetExecutingAssembly().GetName().Version);
            }
        }
        void ribbonGalleryBarItem1_GalleryItemClick(object sender, GalleryItemClickEventArgs e)
        {
            string style;
            style = Convert.ToString(e.Item.Tag);
            style = style.Replace("(", "").Replace(")", "");


            Properties.Settings.Default.stilodev = style;
            Properties.Settings.Default.Save();
        }
        public void Reloj(Object Sender, EventArgs e)
        {
            barStaticItem2.Caption = DateTime.Now.ToString();

        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
        private void mostrarForm(string nombreform)
        {
            try
            {
                Form frmdinamico = default(Form);
                //Extraemos toda la información necesaria para poder pasar
                //con el solo nombre del formulario a la variable "frmdinamico", el objeto
                frmdinamico = (Form)AppDomain.CurrentDomain.CreateInstanceAndUnwrap(
                             this.GetType().Assembly.GetName().Name,
                             System.String.Concat(this.GetType().Assembly.GetName().Name, ".",
                             nombreform));


                //Llamamos la rutina que no permitira abrir 2 veces el formulario
                llamarform(frmdinamico, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Error de forma", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        public void llamarform(Form formulario, Form mdi)
        {
            //Form frm;
            bool escargado = false;
            try
            {

                foreach (Form frm in mdi.MdiChildren)
                {
                    if (frm.GetType() == formulario.GetType()
                        && frm != formulario)
                    {
                        escargado = true;
                        //Sale del loop si es verdadero
                        break;
                        frm.Close();
                    }
                }
                if (!escargado)
                {
                    //Carga el formulario si no esta llamado
                    formulario.MdiParent = mdi;
                    formulario.Show();

                }
                else if (escargado)
                {
                    //Enfoca el objeto
                    formulario.WindowState = FormWindowState.Normal;
                    formulario.Select();
                    formulario.Focus();
                    formulario.BringToFront();


                }

                //Nada que hacer, toca colocar la exception
            }
            catch (Exception ex)
            {
                //Mostrar mensaje
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Limpiar todo
            formulario = null;
            //   frm = null;
        }
        [DllImport("user32.Dll")]
        public static extern IntPtr RemoveMenu(int hMenu, int nPosition, int wFlags);

        //Obtener el menú de sistema
        [DllImport("User32.Dll")]
        public static extern IntPtr GetSystemMenu(int hWnd, bool bRevert);

        //Obtener el número de elementos del menú de sistema
        [DllImport("User32.Dll")]
        public static extern IntPtr GetMenuItemCount(int hMenu);

        //Redibujar la barra de título de la ventana
        [DllImport("User32.Dll")]
        public static extern IntPtr DrawMenuBar(int hwnd);

        private const int MF_BYPOSITION = 0x0400;

        private const int MF_DISABLED = 0x0002;
        public void DisableCloseButton(int hWnd)
        {
            IntPtr hMenu;
            IntPtr menuItemCount;
            //Obtener el manejador del menú de sistema del formulario
            hMenu = GetSystemMenu(hWnd, false);
            //Obtener la cuenta de los ítems del menú de sistema.
            //Es el menú que aparece al pulsar sobre el icono a la izquierda
            //de la Barra de título de la ventana, consta de los ítems: Restaurar, Mover,
            //Tamaño,Minimizar, Maximizar, Separador, Cerrar
            menuItemCount = GetMenuItemCount(hMenu.ToInt32());
            //Quitar el ítem Close (Cerrar), que es el último de ese menú
            RemoveMenu(hMenu.ToInt32(), menuItemCount.ToInt32() - 1, MF_DISABLED | MF_BYPOSITION);
            //Quitar el ítem Separador, el penúltimo de ese menú, entre Maximizar y Cerrar
            RemoveMenu(hMenu.ToInt32(), menuItemCount.ToInt32() - 2, MF_DISABLED | MF_BYPOSITION);
            //Redibujar la barra de menú
            DrawMenuBar(hWnd);
        }

        private void barButtonItem_exit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            LOGIN frm = new LOGIN();
            frm.Show();
        }
    }
}