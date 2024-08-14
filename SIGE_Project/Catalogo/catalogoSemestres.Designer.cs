namespace SIGE_Project.Catalogo
{
    partial class catalogoSemestres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(catalogoSemestres));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem_actualizar = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_agregar = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_editar = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_activarDesactivar = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem_exportar = new DevExpress.XtraNavBar.NavBarItem();
            this.gridControl_semestres = new DevExpress.XtraGrid.GridControl();
            this.gridView_semestres = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idSemestres = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_semestres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_semestres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.navBarControl1);
            this.layoutControl1.Controls.Add(this.gridControl_semestres);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(653, 507);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(105, 24);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Semestres";
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
            this.navBarControl1.Location = new System.Drawing.Point(442, 40);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 199;
            this.navBarControl1.Size = new System.Drawing.Size(199, 455);
            this.navBarControl1.TabIndex = 5;
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
            this.navBarItem_actualizar.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_actualizar_LinkClicked);
            // 
            // navBarItem_agregar
            // 
            this.navBarItem_agregar.Caption = "Agregar";
            this.navBarItem_agregar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem_agregar.ImageOptions.SvgImage")));
            this.navBarItem_agregar.Name = "navBarItem_agregar";
            this.navBarItem_agregar.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_agregar_LinkClicked);
            // 
            // navBarItem_editar
            // 
            this.navBarItem_editar.Caption = "Editar";
            this.navBarItem_editar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem_editar.ImageOptions.SvgImage")));
            this.navBarItem_editar.Name = "navBarItem_editar";
            this.navBarItem_editar.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_editar_LinkClicked);
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
            this.navBarItem_exportar.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_exportar_LinkClicked);
            // 
            // gridControl_semestres
            // 
            this.gridControl_semestres.Location = new System.Drawing.Point(12, 40);
            this.gridControl_semestres.MainView = this.gridView_semestres;
            this.gridControl_semestres.Name = "gridControl_semestres";
            this.gridControl_semestres.Size = new System.Drawing.Size(426, 455);
            this.gridControl_semestres.TabIndex = 4;
            this.gridControl_semestres.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_semestres});
            // 
            // gridView_semestres
            // 
            this.gridView_semestres.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idSemestres,
            this.descripcion,
            this.estado,
            this.estadoLetra});
            this.gridView_semestres.GridControl = this.gridControl_semestres;
            this.gridView_semestres.Name = "gridView_semestres";
            this.gridView_semestres.OptionsView.ShowGroupPanel = false;
            // 
            // idSemestres
            // 
            this.idSemestres.Caption = "Id semestre";
            this.idSemestres.FieldName = "idSemestre";
            this.idSemestres.MinWidth = 25;
            this.idSemestres.Name = "idSemestres";
            this.idSemestres.Width = 94;
            // 
            // descripcion
            // 
            this.descripcion.Caption = "Descripción";
            this.descripcion.FieldName = "descripcion";
            this.descripcion.MinWidth = 25;
            this.descripcion.Name = "descripcion";
            this.descripcion.Visible = true;
            this.descripcion.VisibleIndex = 0;
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
            this.estadoLetra.VisibleIndex = 1;
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
            this.Root.Size = new System.Drawing.Size(653, 507);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl_semestres;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(430, 459);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.navBarControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(430, 28);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(203, 459);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.labelControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(633, 28);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // catalogoSemestres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 507);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("catalogoSemestres.IconOptions.SvgImage")));
            this.Name = "catalogoSemestres";
            this.Text = "Semestres";
            this.Load += new System.EventHandler(this.catalogoSemestres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_semestres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_semestres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_actualizar;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_agregar;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_editar;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_activarDesactivar;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraGrid.GridControl gridControl_semestres;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_semestres;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_exportar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn idSemestres;
        private DevExpress.XtraGrid.Columns.GridColumn descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn estado;
        private DevExpress.XtraGrid.Columns.GridColumn estadoLetra;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}