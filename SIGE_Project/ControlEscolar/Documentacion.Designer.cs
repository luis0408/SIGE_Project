namespace SIGE_Project.ControlEscolar
{
    partial class Documentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Documentacion));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.textEdit_CURP = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton_save = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl_docs = new DevExpress.XtraGrid.GridControl();
            this.gridView_docs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit_original = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit_copia = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEdit_name = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::SIGE_Project.WaitForm1), true, true);
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_CURP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_docs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_docs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_copia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textEdit_CURP);
            this.layoutControl1.Controls.Add(this.simpleButton_save);
            this.layoutControl1.Controls.Add(this.simpleButton_cancel);
            this.layoutControl1.Controls.Add(this.gridControl_docs);
            this.layoutControl1.Controls.Add(this.textEdit_name);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(829, 156, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(912, 479);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // textEdit_CURP
            // 
            this.textEdit_CURP.Location = new System.Drawing.Point(65, 12);
            this.textEdit_CURP.Name = "textEdit_CURP";
            this.textEdit_CURP.Properties.ReadOnly = true;
            this.textEdit_CURP.Size = new System.Drawing.Size(299, 20);
            this.textEdit_CURP.StyleController = this.layoutControl1;
            this.textEdit_CURP.TabIndex = 8;
            // 
            // simpleButton_save
            // 
            this.simpleButton_save.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton_save.ImageOptions.SvgImage")));
            this.simpleButton_save.Location = new System.Drawing.Point(661, 431);
            this.simpleButton_save.Name = "simpleButton_save";
            this.simpleButton_save.Size = new System.Drawing.Size(239, 36);
            this.simpleButton_save.StyleController = this.layoutControl1;
            this.simpleButton_save.TabIndex = 7;
            this.simpleButton_save.Text = "Guardar";
            this.simpleButton_save.Click += new System.EventHandler(this.simpleButton_save_Click);
            // 
            // simpleButton_cancel
            // 
            this.simpleButton_cancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton_cancel.ImageOptions.SvgImage")));
            this.simpleButton_cancel.Location = new System.Drawing.Point(422, 431);
            this.simpleButton_cancel.Name = "simpleButton_cancel";
            this.simpleButton_cancel.Size = new System.Drawing.Size(235, 36);
            this.simpleButton_cancel.StyleController = this.layoutControl1;
            this.simpleButton_cancel.TabIndex = 6;
            this.simpleButton_cancel.Text = "Cancelar";
            this.simpleButton_cancel.Click += new System.EventHandler(this.simpleButton_cancel_Click);
            // 
            // gridControl_docs
            // 
            this.gridControl_docs.Location = new System.Drawing.Point(12, 36);
            this.gridControl_docs.MainView = this.gridView_docs;
            this.gridControl_docs.Name = "gridControl_docs";
            this.gridControl_docs.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit_original,
            this.repositoryItemCheckEdit_copia});
            this.gridControl_docs.Size = new System.Drawing.Size(888, 391);
            this.gridControl_docs.TabIndex = 5;
            this.gridControl_docs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_docs});
            // 
            // gridView_docs
            // 
            this.gridView_docs.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView_docs.GridControl = this.gridControl_docs;
            this.gridView_docs.Name = "gridView_docs";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id documento";
            this.gridColumn1.FieldName = "idDocumento";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Documento";
            this.gridColumn2.FieldName = "descripcion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Original";
            this.gridColumn3.ColumnEdit = this.repositoryItemCheckEdit_original;
            this.gridColumn3.FieldName = "original";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // repositoryItemCheckEdit_original
            // 
            this.repositoryItemCheckEdit_original.AutoHeight = false;
            this.repositoryItemCheckEdit_original.Name = "repositoryItemCheckEdit_original";
            this.repositoryItemCheckEdit_original.ValueChecked = 1;
            this.repositoryItemCheckEdit_original.ValueUnchecked = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Copia";
            this.gridColumn4.ColumnEdit = this.repositoryItemCheckEdit_copia;
            this.gridColumn4.FieldName = "copia";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // repositoryItemCheckEdit_copia
            // 
            this.repositoryItemCheckEdit_copia.AutoHeight = false;
            this.repositoryItemCheckEdit_copia.Name = "repositoryItemCheckEdit_copia";
            this.repositoryItemCheckEdit_copia.ValueChecked = 1;
            this.repositoryItemCheckEdit_copia.ValueUnchecked = 0;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Observaciones";
            this.gridColumn5.FieldName = "observaciones";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // textEdit_name
            // 
            this.textEdit_name.Location = new System.Drawing.Point(421, 12);
            this.textEdit_name.Name = "textEdit_name";
            this.textEdit_name.Properties.ReadOnly = true;
            this.textEdit_name.Size = new System.Drawing.Size(417, 20);
            this.textEdit_name.StyleController = this.layoutControl1;
            this.textEdit_name.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(912, 479);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit_name;
            this.layoutControlItem1.Location = new System.Drawing.Point(356, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(474, 24);
            this.layoutControlItem1.Text = "Nombre:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(41, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl_docs;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(892, 395);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton_cancel;
            this.layoutControlItem3.Location = new System.Drawing.Point(410, 419);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(239, 40);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.simpleButton_save;
            this.layoutControlItem4.Location = new System.Drawing.Point(649, 419);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(243, 40);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 419);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(410, 40);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(830, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(62, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.textEdit_CURP;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(356, 24);
            this.layoutControlItem5.Text = "CURP:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(41, 13);
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Id registro";
            this.gridColumn6.FieldName = "idRegistro";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // Documentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 479);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Documentacion.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.Name = "Documentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documentación";
            this.Load += new System.EventHandler(this.Documentacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_CURP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_docs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_docs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_copia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControl_docs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_docs;
        private DevExpress.XtraEditors.TextEdit textEdit_name;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton simpleButton_save;
        private DevExpress.XtraEditors.SimpleButton simpleButton_cancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit_original;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit_copia;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.TextEdit textEdit_CURP;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}