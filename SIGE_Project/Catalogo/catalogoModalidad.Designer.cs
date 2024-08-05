namespace SIGE_Project.Catalogo
{
    partial class catalogoModalidad
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.navBarControl_export = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem_refresh = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_add = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_edit = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_delete = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem_export = new DevExpress.XtraNavBar.NavBarItem();
            this.gridControl_modalidad = new DevExpress.XtraGrid.GridControl();
            this.gridView_modalidad = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl_export)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_modalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_modalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.navBarControl_export);
            this.layoutControl1.Controls.Add(this.gridControl_modalidad);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(899, 532);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 19);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Modalidad";
            // 
            // navBarControl_export
            // 
            this.navBarControl_export.ActiveGroup = this.navBarGroup1;
            this.navBarControl_export.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.navBarControl_export.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem_refresh,
            this.navBarItem_add,
            this.navBarItem_edit,
            this.navBarItem_delete,
            this.navBarItem_export});
            this.navBarControl_export.Location = new System.Drawing.Point(710, 35);
            this.navBarControl_export.Name = "navBarControl_export";
            this.navBarControl_export.OptionsNavPane.ExpandedWidth = 177;
            this.navBarControl_export.Size = new System.Drawing.Size(177, 485);
            this.navBarControl_export.TabIndex = 5;
            this.navBarControl_export.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Acciones";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_refresh),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_add),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_edit),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_delete)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItem_refresh
            // 
            this.navBarItem_refresh.Caption = "Actualizar";
            this.navBarItem_refresh.ImageOptions.SvgImage = global::SIGE_Project.Properties.Resources.actions_refresh3;
            this.navBarItem_refresh.Name = "navBarItem_refresh";
            this.navBarItem_refresh.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_refresh_LinkClicked);
            // 
            // navBarItem_add
            // 
            this.navBarItem_add.Caption = "Agregar";
            this.navBarItem_add.ImageOptions.SvgImage = global::SIGE_Project.Properties.Resources.actions_addcircled1;
            this.navBarItem_add.Name = "navBarItem_add";
            this.navBarItem_add.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_add_LinkClicked);
            // 
            // navBarItem_edit
            // 
            this.navBarItem_edit.Caption = "Editar";
            this.navBarItem_edit.ImageOptions.SvgImage = global::SIGE_Project.Properties.Resources.actions_edit2;
            this.navBarItem_edit.Name = "navBarItem_edit";
            this.navBarItem_edit.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_edit_LinkClicked);
            // 
            // navBarItem_delete
            // 
            this.navBarItem_delete.Caption = "Acrivar/Desactivar";
            this.navBarItem_delete.ImageOptions.SvgImage = global::SIGE_Project.Properties.Resources.actions_rating5;
            this.navBarItem_delete.Name = "navBarItem_delete";
            this.navBarItem_delete.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_delete_LinkClicked);
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
            this.navBarItem_export.ImageOptions.SvgImage = global::SIGE_Project.Properties.Resources.exporttoxlsx5;
            this.navBarItem_export.Name = "navBarItem_export";
            this.navBarItem_export.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_export_LinkClicked);
            // 
            // gridControl_modalidad
            // 
            this.gridControl_modalidad.Location = new System.Drawing.Point(12, 35);
            this.gridControl_modalidad.MainView = this.gridView_modalidad;
            this.gridControl_modalidad.Name = "gridControl_modalidad";
            this.gridControl_modalidad.Size = new System.Drawing.Size(694, 485);
            this.gridControl_modalidad.TabIndex = 4;
            this.gridControl_modalidad.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_modalidad});
            // 
            // gridView_modalidad
            // 
            this.gridView_modalidad.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView_modalidad.GridControl = this.gridControl_modalidad;
            this.gridView_modalidad.Name = "gridView_modalidad";
            this.gridView_modalidad.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id registro";
            this.gridColumn1.FieldName = "idRegistro";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Clave de modalidad";
            this.gridColumn2.FieldName = "cveModalidad";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Descripción";
            this.gridColumn3.FieldName = "descripcion";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Estado num";
            this.gridColumn4.FieldName = "estado";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Estado";
            this.gridColumn5.FieldName = "estadoLetra";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
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
            this.Root.Size = new System.Drawing.Size(899, 532);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl_modalidad;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 23);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(698, 489);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.navBarControl_export;
            this.layoutControlItem2.Location = new System.Drawing.Point(698, 23);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(181, 489);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.labelControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(879, 23);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // catalogoModalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 532);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.SvgImage = global::SIGE_Project.Properties.Resources.groupbyresource;
            this.Name = "catalogoModalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modalidad";
            this.Load += new System.EventHandler(this.catalogoModalidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl_export)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_modalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_modalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraNavBar.NavBarControl navBarControl_export;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_refresh;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_add;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_edit;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_delete;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_export;
        private DevExpress.XtraGrid.GridControl gridControl_modalidad;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_modalidad;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}