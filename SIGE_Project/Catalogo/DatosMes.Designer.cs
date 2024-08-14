namespace SIGE_Project.Catalogo
{
    partial class DatosMes
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
            this.simpleButton_cancelar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_aceptar = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit_descripcion = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_cveMes = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_descripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_cveMes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButton_cancelar);
            this.layoutControl1.Controls.Add(this.simpleButton_aceptar);
            this.layoutControl1.Controls.Add(this.textEdit_descripcion);
            this.layoutControl1.Controls.Add(this.textEdit_cveMes);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(487, 92);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButton_cancelar
            // 
            this.simpleButton_cancelar.ImageOptions.SvgImage = global::SIGE_Project.Properties.Resources.close2;
            this.simpleButton_cancelar.Location = new System.Drawing.Point(245, 36);
            this.simpleButton_cancelar.Name = "simpleButton_cancelar";
            this.simpleButton_cancelar.Size = new System.Drawing.Size(230, 36);
            this.simpleButton_cancelar.StyleController = this.layoutControl1;
            this.simpleButton_cancelar.TabIndex = 7;
            this.simpleButton_cancelar.Text = "Cancelar";
            this.simpleButton_cancelar.Click += new System.EventHandler(this.simpleButton_cancelar_Click);
            // 
            // simpleButton_aceptar
            // 
            this.simpleButton_aceptar.ImageOptions.SvgImage = global::SIGE_Project.Properties.Resources.save2;
            this.simpleButton_aceptar.Location = new System.Drawing.Point(12, 36);
            this.simpleButton_aceptar.Name = "simpleButton_aceptar";
            this.simpleButton_aceptar.Size = new System.Drawing.Size(229, 36);
            this.simpleButton_aceptar.StyleController = this.layoutControl1;
            this.simpleButton_aceptar.TabIndex = 6;
            this.simpleButton_aceptar.Text = "Aceptar";
            this.simpleButton_aceptar.Click += new System.EventHandler(this.simpleButton_aceptar_Click);
            // 
            // textEdit_descripcion
            // 
            this.textEdit_descripcion.Location = new System.Drawing.Point(268, 12);
            this.textEdit_descripcion.Name = "textEdit_descripcion";
            this.textEdit_descripcion.Size = new System.Drawing.Size(207, 20);
            this.textEdit_descripcion.StyleController = this.layoutControl1;
            this.textEdit_descripcion.TabIndex = 5;
            // 
            // textEdit_cveMes
            // 
            this.textEdit_cveMes.Location = new System.Drawing.Point(92, 12);
            this.textEdit_cveMes.Name = "textEdit_cveMes";
            this.textEdit_cveMes.Size = new System.Drawing.Size(92, 20);
            this.textEdit_cveMes.StyleController = this.layoutControl1;
            this.textEdit_cveMes.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(487, 92);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit_cveMes;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(176, 24);
            this.layoutControlItem1.Text = "Clave de mes:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textEdit_descripcion;
            this.layoutControlItem2.Location = new System.Drawing.Point(176, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(291, 24);
            this.layoutControlItem2.Text = "Descripción:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton_aceptar;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(233, 48);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.simpleButton_cancelar;
            this.layoutControlItem4.Location = new System.Drawing.Point(233, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(234, 48);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // DatosMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 92);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.SvgImage = global::SIGE_Project.Properties.Resources.actions_calendar3;
            this.Name = "DatosMes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del mes";
            this.Load += new System.EventHandler(this.DatosMes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_descripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_cveMes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit textEdit_cveMes;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit textEdit_descripcion;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton simpleButton_cancelar;
        private DevExpress.XtraEditors.SimpleButton simpleButton_aceptar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}