namespace SIGE_Project.Catalogo
{
    partial class CatalogoDiscapacidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogoDiscapacidad));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl_discapacidad = new DevExpress.XtraGrid.GridControl();
            this.gridView_discapacidad = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idDIscapacidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.estadoLetra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem_refresh = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_add = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_edit = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem_export = new DevExpress.XtraNavBar.NavBarItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_discapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_discapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.gridControl_discapacidad);
            this.layoutControl1.Controls.Add(this.navBarControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1106, 462);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(16, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(157, 29);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Discapacidad";
            // 
            // gridControl_discapacidad
            // 
            this.gridControl_discapacidad.Location = new System.Drawing.Point(16, 51);
            this.gridControl_discapacidad.MainView = this.gridView_discapacidad;
            this.gridControl_discapacidad.Name = "gridControl_discapacidad";
            this.gridControl_discapacidad.Size = new System.Drawing.Size(833, 395);
            this.gridControl_discapacidad.TabIndex = 5;
            this.gridControl_discapacidad.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_discapacidad});
            // 
            // gridView_discapacidad
            // 
            this.gridView_discapacidad.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idDIscapacidad,
            this.descripcion,
            this.estado,
            this.estadoLetra});
            this.gridView_discapacidad.GridControl = this.gridControl_discapacidad;
            this.gridView_discapacidad.Name = "gridView_discapacidad";
            this.gridView_discapacidad.OptionsView.ShowGroupPanel = false;
            // 
            // idDIscapacidad
            // 
            this.idDIscapacidad.Caption = "id Discapacidad";
            this.idDIscapacidad.FieldName = "idDIscapacidad";
            this.idDIscapacidad.MinWidth = 30;
            this.idDIscapacidad.Name = "idDIscapacidad";
            this.idDIscapacidad.Width = 112;
            // 
            // descripcion
            // 
            this.descripcion.Caption = "Descripcion";
            this.descripcion.FieldName = "descripcion";
            this.descripcion.MinWidth = 30;
            this.descripcion.Name = "descripcion";
            this.descripcion.Visible = true;
            this.descripcion.VisibleIndex = 0;
            this.descripcion.Width = 112;
            // 
            // estado
            // 
            this.estado.Caption = "estado";
            this.estado.FieldName = "estado";
            this.estado.MinWidth = 30;
            this.estado.Name = "estado";
            this.estado.Width = 112;
            // 
            // estadoLetra
            // 
            this.estadoLetra.Caption = "Estado";
            this.estadoLetra.FieldName = "estadoLetra";
            this.estadoLetra.MinWidth = 30;
            this.estadoLetra.Name = "estadoLetra";
            this.estadoLetra.Visible = true;
            this.estadoLetra.VisibleIndex = 1;
            this.estadoLetra.Width = 112;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem_refresh,
            this.navBarItem_add,
            this.navBarItem_edit,
            this.navBarItem4,
            this.navBarItem_export});
            this.navBarControl1.Location = new System.Drawing.Point(855, 51);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 235;
            this.navBarControl1.Size = new System.Drawing.Size(235, 395);
            this.navBarControl1.TabIndex = 4;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Acciones";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_refresh),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_add),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_edit),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItem_refresh
            // 
            this.navBarItem_refresh.Caption = "Actualizar";
            this.navBarItem_refresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem_refresh.ImageOptions.SvgImage")));
            this.navBarItem_refresh.Name = "navBarItem_refresh";
            this.navBarItem_refresh.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_refresh_LinkClicked_1);
            // 
            // navBarItem_add
            // 
            this.navBarItem_add.Caption = "Agregar";
            this.navBarItem_add.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem_add.ImageOptions.SvgImage")));
            this.navBarItem_add.Name = "navBarItem_add";
            this.navBarItem_add.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_add_LinkClicked_1);
            // 
            // navBarItem_edit
            // 
            this.navBarItem_edit.Caption = "Editar";
            this.navBarItem_edit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem_edit.ImageOptions.SvgImage")));
            this.navBarItem_edit.Name = "navBarItem_edit";
            this.navBarItem_edit.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_edit_LinkClicked_1);
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "Activar/Desactivar";
            this.navBarItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem4.ImageOptions.SvgImage")));
            this.navBarItem4.Name = "navBarItem4";
            this.navBarItem4.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem4_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Reportes";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_export)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarItem_export
            // 
            this.navBarItem_export.Caption = "Exportar";
            this.navBarItem_export.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem_export.ImageOptions.SvgImage")));
            this.navBarItem_export.Name = "navBarItem_export";
            this.navBarItem_export.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_export_LinkClicked_1);
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
            this.Root.Size = new System.Drawing.Size(1106, 462);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.navBarControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(839, 35);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(241, 401);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl_discapacidad;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 35);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(839, 401);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.labelControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1080, 35);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // CatalogoDiscapacidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 462);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("CatalogoDiscapacidad.IconOptions.SvgImage")));
            this.Name = "CatalogoDiscapacidad";
            this.Text = "Discapacidad";
            this.Load += new System.EventHandler(this.CatalogoDiscapacidad_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_discapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_discapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl_discapacidad;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_discapacidad;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_refresh;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_add;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_edit;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_export;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn idDIscapacidad;
        private DevExpress.XtraGrid.Columns.GridColumn descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn estado;
        private DevExpress.XtraGrid.Columns.GridColumn estadoLetra;
    }
}