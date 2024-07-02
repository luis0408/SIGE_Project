namespace SIGE_Project.Catalogo
{
    partial class catalogoCicloEscolar
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
            DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(catalogoCicloEscolar));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl_cicloEscolar = new DevExpress.XtraGrid.GridControl();
            this.gridView_cicloEscolar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem_add = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_edit = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_delete = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_refresh = new DevExpress.XtraNavBar.NavBarItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_cicloEscolar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_cicloEscolar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "ID Ciclo Escolar";
            gridColumn1.FieldName = "idCicloEscolar";
            gridColumn1.Name = "gridColumn1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl_cicloEscolar);
            this.layoutControl1.Controls.Add(this.navBarControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 233, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(981, 494);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl_cicloEscolar
            // 
            this.gridControl_cicloEscolar.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gridControl_cicloEscolar.Location = new System.Drawing.Point(12, 12);
            this.gridControl_cicloEscolar.MainView = this.gridView_cicloEscolar;
            this.gridControl_cicloEscolar.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl_cicloEscolar.Name = "gridControl_cicloEscolar";
            this.gridControl_cicloEscolar.Size = new System.Drawing.Size(653, 470);
            this.gridControl_cicloEscolar.TabIndex = 5;
            this.gridControl_cicloEscolar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_cicloEscolar});
            // 
            // gridView_cicloEscolar
            // 
            this.gridView_cicloEscolar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView_cicloEscolar.DetailHeight = 239;
            this.gridView_cicloEscolar.GridControl = this.gridControl_cicloEscolar;
            this.gridView_cicloEscolar.Name = "gridView_cicloEscolar";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Año Inicio";
            this.gridColumn2.FieldName = "anioInicio";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Año Fin";
            this.gridColumn3.FieldName = "anioFin";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Estado Num";
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
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem_add,
            this.navBarItem_edit,
            this.navBarItem_delete,
            this.navBarItem_refresh});
            this.navBarControl1.Location = new System.Drawing.Point(669, 12);
            this.navBarControl1.Margin = new System.Windows.Forms.Padding(2);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 300;
            this.navBarControl1.Size = new System.Drawing.Size(300, 470);
            this.navBarControl1.TabIndex = 4;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "ACCIONES";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_add),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_edit),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_delete),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_refresh)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItem_add
            // 
            this.navBarItem_add.Caption = "Agregar ciclo escolar.";
            this.navBarItem_add.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem_add.ImageOptions.SvgImage")));
            this.navBarItem_add.Name = "navBarItem_add";
            // 
            // navBarItem_edit
            // 
            this.navBarItem_edit.Caption = "Editar ciclo escolar.";
            this.navBarItem_edit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem_edit.ImageOptions.SvgImage")));
            this.navBarItem_edit.Name = "navBarItem_edit";
            // 
            // navBarItem_delete
            // 
            this.navBarItem_delete.Caption = "Eliminar ciclo escolar.";
            this.navBarItem_delete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem_delete.ImageOptions.SvgImage")));
            this.navBarItem_delete.Name = "navBarItem_delete";
            // 
            // navBarItem_refresh
            // 
            this.navBarItem_refresh.Caption = "Actualizar.";
            this.navBarItem_refresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem_refresh.ImageOptions.SvgImage")));
            this.navBarItem_refresh.Name = "navBarItem_refresh";
            //this.navBarItem_refresh.ItemChanged += new System.EventHandler(this.navBarItem_refresh_ItemChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(981, 494);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.navBarControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(657, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(304, 474);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl_cicloEscolar;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(657, 474);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // catalogoCicloEscolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 494);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "catalogoCicloEscolar";
            this.Text = "catalogoCicloEscolar";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_cicloEscolar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_cicloEscolar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl gridControl_cicloEscolar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_cicloEscolar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_add;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_edit;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_delete;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_refresh;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}