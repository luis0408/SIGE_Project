namespace SIGE_Project.Catalogo
{
    partial class catalogoPeriodos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(catalogoPeriodos));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl_periodos = new DevExpress.XtraGrid.GridControl();
            this.gridView_periodos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1_idCicloEscolar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1_cveMesInicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1_anioInicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1_cveMesFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1_anioFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem_add = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_periodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_periodos)).BeginInit();
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
            this.layoutControl1.Controls.Add(this.gridControl_periodos);
            this.layoutControl1.Controls.Add(this.navBarControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(865, 426);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 13);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "PERIODOS IESE.";
            // 
            // gridControl_periodos
            // 
            this.gridControl_periodos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gridControl_periodos.Location = new System.Drawing.Point(12, 29);
            this.gridControl_periodos.MainView = this.gridView_periodos;
            this.gridControl_periodos.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl_periodos.Name = "gridControl_periodos";
            this.gridControl_periodos.Size = new System.Drawing.Size(588, 385);
            this.gridControl_periodos.TabIndex = 0;
            this.gridControl_periodos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_periodos});
            // 
            // gridView_periodos
            // 
            this.gridView_periodos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1_idCicloEscolar,
            this.gridColumn1_cveMesInicio,
            this.gridColumn1_anioInicio,
            this.gridColumn1_cveMesFin,
            this.gridColumn1_anioFin});
            this.gridView_periodos.DetailHeight = 239;
            this.gridView_periodos.GridControl = this.gridControl_periodos;
            this.gridView_periodos.Name = "gridView_periodos";
            this.gridView_periodos.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1_idCicloEscolar
            // 
            this.gridColumn1_idCicloEscolar.Caption = "Id ciclo escolar";
            this.gridColumn1_idCicloEscolar.FieldName = "idCicloEscolar";
            this.gridColumn1_idCicloEscolar.Name = "gridColumn1_idCicloEscolar";
            this.gridColumn1_idCicloEscolar.Visible = true;
            this.gridColumn1_idCicloEscolar.VisibleIndex = 0;
            // 
            // gridColumn1_cveMesInicio
            // 
            this.gridColumn1_cveMesInicio.Caption = "Clave mes de inicio";
            this.gridColumn1_cveMesInicio.FieldName = "cveMesInicio";
            this.gridColumn1_cveMesInicio.Name = "gridColumn1_cveMesInicio";
            this.gridColumn1_cveMesInicio.Visible = true;
            this.gridColumn1_cveMesInicio.VisibleIndex = 1;
            this.gridColumn1_cveMesInicio.Width = 50;
            // 
            // gridColumn1_anioInicio
            // 
            this.gridColumn1_anioInicio.Caption = "Año de inicio";
            this.gridColumn1_anioInicio.FieldName = "anioInicio";
            this.gridColumn1_anioInicio.Name = "gridColumn1_anioInicio";
            this.gridColumn1_anioInicio.Visible = true;
            this.gridColumn1_anioInicio.VisibleIndex = 2;
            this.gridColumn1_anioInicio.Width = 50;
            // 
            // gridColumn1_cveMesFin
            // 
            this.gridColumn1_cveMesFin.Caption = "Clave mes de fin";
            this.gridColumn1_cveMesFin.FieldName = "cveMesFin";
            this.gridColumn1_cveMesFin.Name = "gridColumn1_cveMesFin";
            this.gridColumn1_cveMesFin.Visible = true;
            this.gridColumn1_cveMesFin.VisibleIndex = 3;
            this.gridColumn1_cveMesFin.Width = 50;
            // 
            // gridColumn1_anioFin
            // 
            this.gridColumn1_anioFin.Caption = "Año de fin";
            this.gridColumn1_anioFin.FieldName = "anioFin";
            this.gridColumn1_anioFin.Name = "gridColumn1_anioFin";
            this.gridColumn1_anioFin.Visible = true;
            this.gridColumn1_anioFin.VisibleIndex = 4;
            this.gridColumn1_anioFin.Width = 50;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem_add,
            this.navBarItem2,
            this.navBarItem3,
            this.navBarItem4,
            this.navBarItem5,
            this.navBarItem6});
            this.navBarControl1.Location = new System.Drawing.Point(604, 29);
            this.navBarControl1.Margin = new System.Windows.Forms.Padding(2);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 249;
            this.navBarControl1.Size = new System.Drawing.Size(249, 385);
            this.navBarControl1.TabIndex = 1;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "ACCIONES.";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_add),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItem_add
            // 
            this.navBarItem_add.Caption = "Nuevo periodo.";
            this.navBarItem_add.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem_add.ImageOptions.SvgImage")));
            this.navBarItem_add.Name = "navBarItem_add";
            this.navBarItem_add.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_add_LinkClicked);
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "Editar periodo.";
            this.navBarItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem2.ImageOptions.SvgImage")));
            this.navBarItem2.Name = "navBarItem2";
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "Eliminar periodo.";
            this.navBarItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem3.ImageOptions.SvgImage")));
            this.navBarItem3.Name = "navBarItem3";
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "Actualizar.";
            this.navBarItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem4.ImageOptions.SvgImage")));
            this.navBarItem4.Name = "navBarItem4";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "REPORTES.";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem6)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "Reporte de todos los periodos.";
            this.navBarItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem5.ImageOptions.SvgImage")));
            this.navBarItem5.Name = "navBarItem5";
            // 
            // navBarItem6
            // 
            this.navBarItem6.Caption = "Reporte filtrado de periodos.";
            this.navBarItem6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem6.ImageOptions.SvgImage")));
            this.navBarItem6.Name = "navBarItem6";
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
            this.Root.Size = new System.Drawing.Size(865, 426);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.navBarControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(592, 17);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(253, 389);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl_periodos;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 17);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(592, 389);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.labelControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(845, 17);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // catalogoPeriodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 426);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "catalogoPeriodos";
            this.Text = "catalogoPeriodos";
            this.Load += new System.EventHandler(this.catalogoPeriodos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_periodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_periodos)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gridControl_periodos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_periodos;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_add;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1_cveMesInicio;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1_anioInicio;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1_cveMesFin;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1_anioFin;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1_idCicloEscolar;
    }
}