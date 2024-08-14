namespace SIGE_Project.Catalogo
{
    partial class catalogoTipoSangre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(catalogoTipoSangre));
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem_actualizar = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_agregar = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_editar = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_activarDesactivar = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem_exportar = new DevExpress.XtraNavBar.NavBarItem();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl_tipoSangre = new DevExpress.XtraGrid.GridControl();
            this.gridView_tipoSangre = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cveTipoSangre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ClaveTipoSangre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.estadoLetra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_tipoSangre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_tipoSangre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.navBarControl1);
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.gridControl_tipoSangre);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(938, 593);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem_actualizar,
            this.navBarItem_agregar,
            this.navBarItem_editar,
            this.navBarItem_activarDesactivar,
            this.navBarItem_exportar});
            this.navBarControl1.Location = new System.Drawing.Point(724, 40);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 202;
            this.navBarControl1.Size = new System.Drawing.Size(202, 541);
            this.navBarControl1.TabIndex = 9;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Acciones";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_actualizar),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_agregar),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_editar),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_activarDesactivar)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItem_actualizar
            // 
            this.navBarItem_actualizar.Caption = "Actualizar";
            this.navBarItem_actualizar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem_actualizar.ImageOptions.SvgImage")));
            this.navBarItem_actualizar.Name = "navBarItem_actualizar";
            this.navBarItem_actualizar.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_actualizar_LinkClicked_1);
            // 
            // navBarItem_agregar
            // 
            this.navBarItem_agregar.Caption = "Agregar";
            this.navBarItem_agregar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem_agregar.ImageOptions.SvgImage")));
            this.navBarItem_agregar.Name = "navBarItem_agregar";
            this.navBarItem_agregar.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_agregar_LinkClicked_1);
            // 
            // navBarItem_editar
            // 
            this.navBarItem_editar.Caption = "Editar";
            this.navBarItem_editar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem_editar.ImageOptions.SvgImage")));
            this.navBarItem_editar.Name = "navBarItem_editar";
            this.navBarItem_editar.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_editar_LinkClicked_1);
            // 
            // navBarItem_activarDesactivar
            // 
            this.navBarItem_activarDesactivar.Caption = "Activar/Desactivar";
            this.navBarItem_activarDesactivar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem_activarDesactivar.ImageOptions.SvgImage")));
            this.navBarItem_activarDesactivar.Name = "navBarItem_activarDesactivar";
            this.navBarItem_activarDesactivar.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_activarDesactivar_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Reportes";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_exportar)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarItem_exportar
            // 
            this.navBarItem_exportar.Caption = "Exportar";
            this.navBarItem_exportar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem_exportar.ImageOptions.SvgImage")));
            this.navBarItem_exportar.Name = "navBarItem_exportar";
            this.navBarItem_exportar.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_reportes_LinkClicked);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(121, 24);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Tipo Sangre";
            // 
            // gridControl_tipoSangre
            // 
            this.gridControl_tipoSangre.Location = new System.Drawing.Point(12, 40);
            this.gridControl_tipoSangre.MainView = this.gridView_tipoSangre;
            this.gridControl_tipoSangre.Name = "gridControl_tipoSangre";
            this.gridControl_tipoSangre.Size = new System.Drawing.Size(708, 541);
            this.gridControl_tipoSangre.TabIndex = 7;
            this.gridControl_tipoSangre.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_tipoSangre});
            // 
            // gridView_tipoSangre
            // 
            this.gridView_tipoSangre.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cveTipoSangre,
            this.ClaveTipoSangre,
            this.descripcion,
            this.estado,
            this.estadoLetra});
            this.gridView_tipoSangre.GridControl = this.gridControl_tipoSangre;
            this.gridView_tipoSangre.Name = "gridView_tipoSangre";
            this.gridView_tipoSangre.OptionsView.ShowGroupPanel = false;
            // 
            // cveTipoSangre
            // 
            this.cveTipoSangre.Caption = "Id registro";
            this.cveTipoSangre.FieldName = "idRegistro";
            this.cveTipoSangre.MinWidth = 25;
            this.cveTipoSangre.Name = "cveTipoSangre";
            this.cveTipoSangre.Width = 94;
            // 
            // ClaveTipoSangre
            // 
            this.ClaveTipoSangre.Caption = "Clave tipo de sangre";
            this.ClaveTipoSangre.FieldName = "cveTipoSangre";
            this.ClaveTipoSangre.MinWidth = 25;
            this.ClaveTipoSangre.Name = "ClaveTipoSangre";
            this.ClaveTipoSangre.Visible = true;
            this.ClaveTipoSangre.VisibleIndex = 0;
            this.ClaveTipoSangre.Width = 94;
            // 
            // descripcion
            // 
            this.descripcion.Caption = "Descripcion";
            this.descripcion.FieldName = "descripcion";
            this.descripcion.MinWidth = 25;
            this.descripcion.Name = "descripcion";
            this.descripcion.Visible = true;
            this.descripcion.VisibleIndex = 1;
            this.descripcion.Width = 94;
            // 
            // estado
            // 
            this.estado.Caption = "Estado";
            this.estado.FieldName = "estado";
            this.estado.MinWidth = 25;
            this.estado.Name = "estado";
            this.estado.Width = 94;
            // 
            // estadoLetra
            // 
            this.estadoLetra.Caption = "Estado";
            this.estadoLetra.FieldName = "estadoLetra";
            this.estadoLetra.MinWidth = 25;
            this.estadoLetra.Name = "estadoLetra";
            this.estadoLetra.Visible = true;
            this.estadoLetra.VisibleIndex = 2;
            this.estadoLetra.Width = 94;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(938, 593);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl_tipoSangre;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(712, 545);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.labelControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(918, 28);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.navBarControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(712, 28);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(206, 545);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // catalogoTipoSangre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 593);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("catalogoTipoSangre.IconOptions.SvgImage")));
            this.Name = "catalogoTipoSangre";
            this.Text = "Tipo Sangre";
            this.Load += new System.EventHandler(this.catalogoTipoSangre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_tipoSangre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_tipoSangre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_actualizar;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_agregar;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_editar;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_activarDesactivar;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl_tipoSangre;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_tipoSangre;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_exportar;
        private DevExpress.XtraGrid.Columns.GridColumn cveTipoSangre;
        private DevExpress.XtraGrid.Columns.GridColumn ClaveTipoSangre;
        private DevExpress.XtraGrid.Columns.GridColumn descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn estado;
        private DevExpress.XtraGrid.Columns.GridColumn estadoLetra;
    }
}