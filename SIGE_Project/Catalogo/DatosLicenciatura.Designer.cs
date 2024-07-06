namespace SIGE_Project.Catalogo
{
    partial class DatosLicenciatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosLicenciatura));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.textEdit_cveLicenciatura = new DevExpress.XtraEditors.TextEdit();
            this.memoEdit_descLicenciatura = new DevExpress.XtraEditors.MemoEdit();
            this.simpleButton_acept = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.checkEdit_estado = new DevExpress.XtraEditors.CheckEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_cveLicenciatura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit_descLicenciatura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_estado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textEdit_cveLicenciatura);
            this.layoutControl1.Controls.Add(this.memoEdit_descLicenciatura);
            this.layoutControl1.Controls.Add(this.simpleButton_acept);
            this.layoutControl1.Controls.Add(this.simpleButton_cancel);
            this.layoutControl1.Controls.Add(this.checkEdit_estado);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(2551, 135, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(471, 240);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // textEdit_cveLicenciatura
            // 
            this.textEdit_cveLicenciatura.Location = new System.Drawing.Point(138, 12);
            this.textEdit_cveLicenciatura.Name = "textEdit_cveLicenciatura";
            this.textEdit_cveLicenciatura.Size = new System.Drawing.Size(220, 20);
            this.textEdit_cveLicenciatura.StyleController = this.layoutControl1;
            this.textEdit_cveLicenciatura.TabIndex = 4;
            // 
            // memoEdit_descLicenciatura
            // 
            this.memoEdit_descLicenciatura.Location = new System.Drawing.Point(138, 36);
            this.memoEdit_descLicenciatura.Name = "memoEdit_descLicenciatura";
            this.memoEdit_descLicenciatura.Size = new System.Drawing.Size(321, 96);
            this.memoEdit_descLicenciatura.StyleController = this.layoutControl1;
            this.memoEdit_descLicenciatura.TabIndex = 5;
            // 
            // simpleButton_acept
            // 
            this.simpleButton_acept.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton_acept.ImageOptions.SvgImage")));
            this.simpleButton_acept.Location = new System.Drawing.Point(12, 136);
            this.simpleButton_acept.Name = "simpleButton_acept";
            this.simpleButton_acept.Size = new System.Drawing.Size(221, 36);
            this.simpleButton_acept.StyleController = this.layoutControl1;
            this.simpleButton_acept.TabIndex = 6;
            this.simpleButton_acept.Text = "Aceptar";
            this.simpleButton_acept.Click += new System.EventHandler(this.simpleButton_acept_Click);
            // 
            // simpleButton_cancel
            // 
            this.simpleButton_cancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton_cancel.ImageOptions.SvgImage")));
            this.simpleButton_cancel.Location = new System.Drawing.Point(237, 136);
            this.simpleButton_cancel.Name = "simpleButton_cancel";
            this.simpleButton_cancel.Size = new System.Drawing.Size(222, 36);
            this.simpleButton_cancel.StyleController = this.layoutControl1;
            this.simpleButton_cancel.TabIndex = 7;
            this.simpleButton_cancel.Text = "Cancelar";
            this.simpleButton_cancel.Click += new System.EventHandler(this.simpleButton_cancel_Click);
            // 
            // checkEdit_estado
            // 
            this.checkEdit_estado.Location = new System.Drawing.Point(362, 12);
            this.checkEdit_estado.Name = "checkEdit_estado";
            this.checkEdit_estado.Properties.Caption = "Activo";
            this.checkEdit_estado.Size = new System.Drawing.Size(97, 20);
            this.checkEdit_estado.StyleController = this.layoutControl1;
            this.checkEdit_estado.TabIndex = 8;
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
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(471, 240);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit_cveLicenciatura;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem1.CustomizationFormText = "Clave del medio de difusión:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(350, 24);
            this.layoutControlItem1.Text = "Clave de la licenciatura:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(114, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.memoEdit_descLicenciatura;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.CustomizationFormText = "Descripción:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(451, 100);
            this.layoutControlItem2.Text = "Descripción:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(114, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton_acept;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 124);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(225, 40);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.simpleButton_cancel;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(225, 124);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(226, 40);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 164);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(451, 56);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.checkEdit_estado;
            this.layoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(350, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(101, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // DatosLicenciatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 240);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("DatosLicenciatura.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.Name = "DatosLicenciatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de la licenciatura";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_cveLicenciatura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit_descLicenciatura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_estado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit textEdit_cveLicenciatura;
        private DevExpress.XtraEditors.MemoEdit memoEdit_descLicenciatura;
        private DevExpress.XtraEditors.SimpleButton simpleButton_acept;
        private DevExpress.XtraEditors.SimpleButton simpleButton_cancel;
        private DevExpress.XtraEditors.CheckEdit checkEdit_estado;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}