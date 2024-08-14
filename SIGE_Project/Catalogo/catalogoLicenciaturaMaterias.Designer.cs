namespace SIGE_Project.Catalogo
{
    partial class catalogoLicenciaturaMaterias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(catalogoLicenciaturaMaterias));
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem_refresh = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_add = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_edit = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_status = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem_export = new DevExpress.XtraNavBar.NavBarItem();
            this.gridControl_licenciaturaMaterias = new DevExpress.XtraGrid.GridControl();
            this.gridView_licenciaturaMaterias = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_licenciaturaMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_licenciaturaMaterias)).BeginInit();
            this.SuspendLayout();
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
            this.navBarItem_status,
            this.navBarItem_export});
            this.navBarControl1.Location = new System.Drawing.Point(638, 37);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 176;
            this.navBarControl1.Size = new System.Drawing.Size(176, 339);
            this.navBarControl1.TabIndex = 0;
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
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_status)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItem_refresh
            // 
            this.navBarItem_refresh.Caption = "Actualizar";
            this.navBarItem_refresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem_refresh.ImageOptions.SvgImage")));
            this.navBarItem_refresh.Name = "navBarItem_refresh";
            this.navBarItem_refresh.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_refresh_LinkClicked);
            // 
            // navBarItem_add
            // 
            this.navBarItem_add.Caption = "Agregar";
            this.navBarItem_add.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem_add.ImageOptions.SvgImage")));
            this.navBarItem_add.Name = "navBarItem_add";
            this.navBarItem_add.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_add_LinkClicked);
            // 
            // navBarItem_edit
            // 
            this.navBarItem_edit.Caption = "Editar";
            this.navBarItem_edit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem_edit.ImageOptions.SvgImage")));
            this.navBarItem_edit.Name = "navBarItem_edit";
            this.navBarItem_edit.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_edit_LinkClicked);
            // 
            // navBarItem_status
            // 
            this.navBarItem_status.Caption = "Activar/Desactivar";
            this.navBarItem_status.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem_status.ImageOptions.SvgImage")));
            this.navBarItem_status.Name = "navBarItem_status";
            this.navBarItem_status.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_status_LinkClicked);
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
            this.navBarItem_export.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_export_LinkClicked);
            // 
            // gridControl_licenciaturaMaterias
            // 
            this.gridControl_licenciaturaMaterias.Location = new System.Drawing.Point(12, 37);
            this.gridControl_licenciaturaMaterias.MainView = this.gridView_licenciaturaMaterias;
            this.gridControl_licenciaturaMaterias.Name = "gridControl_licenciaturaMaterias";
            this.gridControl_licenciaturaMaterias.Size = new System.Drawing.Size(620, 339);
            this.gridControl_licenciaturaMaterias.TabIndex = 1;
            this.gridControl_licenciaturaMaterias.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_licenciaturaMaterias});
            // 
            // gridView_licenciaturaMaterias
            // 
            this.gridView_licenciaturaMaterias.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView_licenciaturaMaterias.GridControl = this.gridControl_licenciaturaMaterias;
            this.gridView_licenciaturaMaterias.Name = "gridView_licenciaturaMaterias";
            this.gridView_licenciaturaMaterias.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Clave Materia";
            this.gridColumn1.FieldName = "cveMateria";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Descripcion";
            this.gridColumn2.FieldName = "descripcion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Clave Licenciatura";
            this.gridColumn3.FieldName = "cveLicenciatura";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Licenciatura";
            this.gridColumn4.FieldName = "nombreLicenciatura";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Estado Num";
            this.gridColumn5.FieldName = "estado";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Estado";
            this.gridColumn6.FieldName = "estadoLetra";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Materias";
            // 
            // catalogoLicenciaturaMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 388);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl_licenciaturaMaterias);
            this.Controls.Add(this.navBarControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("catalogoLicenciaturaMaterias.IconOptions.SvgImage")));
            this.Name = "catalogoLicenciaturaMaterias";
            this.Text = "Licenciatura Materias";
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_licenciaturaMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_licenciaturaMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraGrid.GridControl gridControl_licenciaturaMaterias;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_licenciaturaMaterias;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_refresh;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_add;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_edit;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_status;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_export;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}