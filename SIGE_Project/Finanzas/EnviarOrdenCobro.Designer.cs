namespace SIGE_Project.Finanzas
{
    partial class EnviarOrdenCobro
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnviarOrdenCobro));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButton_send = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::SIGE_Project.WaitForm1), true, true);
            this.buttonEdit_Ruta = new DevExpress.XtraEditors.ButtonEdit();
            this.textEdit_correoAEnviar = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_curp = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit_Ruta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_correoAEnviar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_curp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.buttonEdit_Ruta);
            this.layoutControl1.Controls.Add(this.simpleButton_send);
            this.layoutControl1.Controls.Add(this.simpleButton_cancel);
            this.layoutControl1.Controls.Add(this.textEdit_correoAEnviar);
            this.layoutControl1.Controls.Add(this.textEdit_curp);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(659, 112);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButton_send
            // 
            this.simpleButton_send.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton_send.ImageOptions.SvgImage")));
            this.simpleButton_send.Location = new System.Drawing.Point(338, 64);
            this.simpleButton_send.Name = "simpleButton_send";
            this.simpleButton_send.Size = new System.Drawing.Size(309, 36);
            this.simpleButton_send.StyleController = this.layoutControl1;
            this.simpleButton_send.TabIndex = 8;
            this.simpleButton_send.Text = "Enviar";
            this.simpleButton_send.Click += new System.EventHandler(this.simpleButton_send_Click);
            // 
            // simpleButton_cancel
            // 
            this.simpleButton_cancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton_cancel.ImageOptions.SvgImage")));
            this.simpleButton_cancel.Location = new System.Drawing.Point(12, 64);
            this.simpleButton_cancel.Name = "simpleButton_cancel";
            this.simpleButton_cancel.Size = new System.Drawing.Size(322, 36);
            this.simpleButton_cancel.StyleController = this.layoutControl1;
            this.simpleButton_cancel.TabIndex = 7;
            this.simpleButton_cancel.Text = "Cancelar";
            this.simpleButton_cancel.Click += new System.EventHandler(this.simpleButton_cancel_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(659, 112);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.simpleButton_cancel;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(326, 40);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButton_send;
            this.layoutControlItem5.Location = new System.Drawing.Point(326, 52);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(313, 40);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // buttonEdit_Ruta
            // 
            this.buttonEdit_Ruta.Location = new System.Drawing.Point(103, 36);
            this.buttonEdit_Ruta.Name = "buttonEdit_Ruta";
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.buttonEdit_Ruta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.buttonEdit_Ruta.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.buttonEdit_Ruta.Size = new System.Drawing.Size(544, 24);
            this.buttonEdit_Ruta.StyleController = this.layoutControl1;
            this.buttonEdit_Ruta.TabIndex = 9;
            this.buttonEdit_Ruta.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit_Ruta_ButtonClick);
            // 
            // textEdit_correoAEnviar
            // 
            this.textEdit_correoAEnviar.Location = new System.Drawing.Point(429, 12);
            this.textEdit_correoAEnviar.Name = "textEdit_correoAEnviar";
            this.textEdit_correoAEnviar.Properties.ReadOnly = true;
            this.textEdit_correoAEnviar.Size = new System.Drawing.Size(218, 20);
            this.textEdit_correoAEnviar.StyleController = this.layoutControl1;
            this.textEdit_correoAEnviar.TabIndex = 5;
            // 
            // textEdit_curp
            // 
            this.textEdit_curp.Location = new System.Drawing.Point(103, 12);
            this.textEdit_curp.Name = "textEdit_curp";
            this.textEdit_curp.Properties.ReadOnly = true;
            this.textEdit_curp.Size = new System.Drawing.Size(231, 20);
            this.textEdit_curp.StyleController = this.layoutControl1;
            this.textEdit_curp.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit_curp;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(326, 24);
            this.layoutControlItem1.Text = "CURP";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textEdit_correoAEnviar;
            this.layoutControlItem2.Location = new System.Drawing.Point(326, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(313, 24);
            this.layoutControlItem2.Text = "Correo a enviar:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.buttonEdit_Ruta;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(639, 28);
            this.layoutControlItem6.Text = "Ruta archivo:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(79, 13);
            // 
            // EnviarOrdenCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 112);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("EnviarOrdenCobro.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.Name = "EnviarOrdenCobro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adjuntar y enviar orden de cobro";
            this.Load += new System.EventHandler(this.EnviarOrdenCobro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit_Ruta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_correoAEnviar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_curp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit textEdit_correoAEnviar;
        private DevExpress.XtraEditors.TextEdit textEdit_curp;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton simpleButton_send;
        private DevExpress.XtraEditors.SimpleButton simpleButton_cancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit_Ruta;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}