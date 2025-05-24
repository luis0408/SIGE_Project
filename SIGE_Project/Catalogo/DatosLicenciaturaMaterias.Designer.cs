namespace SIGE_Project.Catalogo
{
    partial class DatosLicenciaturaMaterias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosLicenciaturaMaterias));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit_status = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButton_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_agree = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEdit_cveLicenciatura = new DevExpress.XtraEditors.LookUpEdit();
            this.textEdit_descripcion = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_cveMateria = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_cveLicenciatura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_descripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_cveMateria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.checkEdit_status);
            this.layoutControl1.Controls.Add(this.simpleButton_cancel);
            this.layoutControl1.Controls.Add(this.simpleButton_agree);
            this.layoutControl1.Controls.Add(this.lookUpEdit_cveLicenciatura);
            this.layoutControl1.Controls.Add(this.textEdit_descripcion);
            this.layoutControl1.Controls.Add(this.textEdit_cveMateria);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(523, 203);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(160, 19);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Datos de la Materia";
            // 
            // checkEdit_status
            // 
            this.checkEdit_status.Location = new System.Drawing.Point(394, 35);
            this.checkEdit_status.Name = "checkEdit_status";
            this.checkEdit_status.Properties.Caption = "Activo";
            this.checkEdit_status.Size = new System.Drawing.Size(117, 20);
            this.checkEdit_status.StyleController = this.layoutControl1;
            this.checkEdit_status.TabIndex = 9;
            // 
            // simpleButton_cancel
            // 
            this.simpleButton_cancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton_cancel.ImageOptions.SvgImage")));
            this.simpleButton_cancel.Location = new System.Drawing.Point(263, 107);
            this.simpleButton_cancel.Name = "simpleButton_cancel";
            this.simpleButton_cancel.Size = new System.Drawing.Size(248, 36);
            this.simpleButton_cancel.StyleController = this.layoutControl1;
            this.simpleButton_cancel.TabIndex = 8;
            this.simpleButton_cancel.Text = "Cancelar";
            this.simpleButton_cancel.Click += new System.EventHandler(this.simpleButton_cancel_Click);
            // 
            // simpleButton_agree
            // 
            this.simpleButton_agree.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton_agree.ImageOptions.SvgImage")));
            this.simpleButton_agree.Location = new System.Drawing.Point(12, 107);
            this.simpleButton_agree.Name = "simpleButton_agree";
            this.simpleButton_agree.Size = new System.Drawing.Size(247, 36);
            this.simpleButton_agree.StyleController = this.layoutControl1;
            this.simpleButton_agree.TabIndex = 7;
            this.simpleButton_agree.Text = "Aceptar";
            this.simpleButton_agree.Click += new System.EventHandler(this.simpleButton_agree_Click);
            // 
            // lookUpEdit_cveLicenciatura
            // 
            this.lookUpEdit_cveLicenciatura.Location = new System.Drawing.Point(90, 83);
            this.lookUpEdit_cveLicenciatura.Name = "lookUpEdit_cveLicenciatura";
            this.lookUpEdit_cveLicenciatura.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_cveLicenciatura.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Licenciatura")});
            this.lookUpEdit_cveLicenciatura.Size = new System.Drawing.Size(421, 20);
            this.lookUpEdit_cveLicenciatura.StyleController = this.layoutControl1;
            this.lookUpEdit_cveLicenciatura.TabIndex = 6;
            // 
            // textEdit_descripcion
            // 
            this.textEdit_descripcion.Location = new System.Drawing.Point(90, 59);
            this.textEdit_descripcion.Name = "textEdit_descripcion";
            this.textEdit_descripcion.Size = new System.Drawing.Size(421, 20);
            this.textEdit_descripcion.StyleController = this.layoutControl1;
            this.textEdit_descripcion.TabIndex = 5;
            // 
            // textEdit_cveMateria
            // 
            this.textEdit_cveMateria.Location = new System.Drawing.Point(90, 35);
            this.textEdit_cveMateria.Name = "textEdit_cveMateria";
            this.textEdit_cveMateria.Size = new System.Drawing.Size(300, 20);
            this.textEdit_cveMateria.StyleController = this.layoutControl1;
            this.textEdit_cveMateria.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(523, 203);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit_cveMateria;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 23);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(382, 24);
            this.layoutControlItem1.Text = "Clave Materia";
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 135);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(503, 48);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textEdit_descripcion;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 47);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(503, 24);
            this.layoutControlItem2.Text = "Descripcion";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lookUpEdit_cveLicenciatura;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 71);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(503, 24);
            this.layoutControlItem3.Text = "Licenciatura";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.simpleButton_agree;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 95);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(251, 40);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButton_cancel;
            this.layoutControlItem5.Location = new System.Drawing.Point(251, 95);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(252, 40);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.checkEdit_status;
            this.layoutControlItem6.Location = new System.Drawing.Point(382, 23);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(121, 24);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.labelControl1;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(503, 23);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // DatosLicenciaturaMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 203);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("DatosLicenciaturaMaterias.IconOptions.SvgImage")));
            this.Name = "DatosLicenciaturaMaterias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Licenciatura Materias";
            this.Load += new System.EventHandler(this.DatosLicenciaturaMaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_cveLicenciatura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_descripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_cveMateria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit checkEdit_status;
        private DevExpress.XtraEditors.SimpleButton simpleButton_cancel;
        private DevExpress.XtraEditors.SimpleButton simpleButton_agree;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_cveLicenciatura;
        private DevExpress.XtraEditors.TextEdit textEdit_descripcion;
        private DevExpress.XtraEditors.TextEdit textEdit_cveMateria;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}