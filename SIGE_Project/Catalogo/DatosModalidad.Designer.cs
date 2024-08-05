namespace SIGE_Project.Catalogo
{
    partial class DatosModalidad
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
            this.simpleButton_cencelar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_aceptar = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit_descripcion = new DevExpress.XtraEditors.TextEdit();
            this.checkEdit_estado = new DevExpress.XtraEditors.CheckEdit();
            this.textEdit_cveModalidad = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_descripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_estado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_cveModalidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButton_cencelar);
            this.layoutControl1.Controls.Add(this.simpleButton_aceptar);
            this.layoutControl1.Controls.Add(this.textEdit_descripcion);
            this.layoutControl1.Controls.Add(this.checkEdit_estado);
            this.layoutControl1.Controls.Add(this.textEdit_cveModalidad);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(446, 126);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButton_cencelar
            // 
            this.simpleButton_cencelar.ImageOptions.SvgImage = global::SIGE_Project.Properties.Resources.close3;
            this.simpleButton_cencelar.Location = new System.Drawing.Point(225, 60);
            this.simpleButton_cencelar.Name = "simpleButton_cencelar";
            this.simpleButton_cencelar.Size = new System.Drawing.Size(209, 36);
            this.simpleButton_cencelar.StyleController = this.layoutControl1;
            this.simpleButton_cencelar.TabIndex = 8;
            this.simpleButton_cencelar.Text = "Cancelar";
            this.simpleButton_cencelar.Click += new System.EventHandler(this.simpleButton_cencelar_Click);
            // 
            // simpleButton_aceptar
            // 
            this.simpleButton_aceptar.ImageOptions.SvgImage = global::SIGE_Project.Properties.Resources.save3;
            this.simpleButton_aceptar.Location = new System.Drawing.Point(12, 60);
            this.simpleButton_aceptar.Name = "simpleButton_aceptar";
            this.simpleButton_aceptar.Size = new System.Drawing.Size(209, 36);
            this.simpleButton_aceptar.StyleController = this.layoutControl1;
            this.simpleButton_aceptar.TabIndex = 7;
            this.simpleButton_aceptar.Text = "Aceptar";
            this.simpleButton_aceptar.Click += new System.EventHandler(this.simpleButton_aceptar_Click);
            // 
            // textEdit_descripcion
            // 
            this.textEdit_descripcion.Location = new System.Drawing.Point(121, 36);
            this.textEdit_descripcion.Name = "textEdit_descripcion";
            this.textEdit_descripcion.Size = new System.Drawing.Size(313, 20);
            this.textEdit_descripcion.StyleController = this.layoutControl1;
            this.textEdit_descripcion.TabIndex = 6;
            // 
            // checkEdit_estado
            // 
            this.checkEdit_estado.Location = new System.Drawing.Point(364, 12);
            this.checkEdit_estado.Name = "checkEdit_estado";
            this.checkEdit_estado.Properties.Caption = "Estado";
            this.checkEdit_estado.Size = new System.Drawing.Size(70, 20);
            this.checkEdit_estado.StyleController = this.layoutControl1;
            this.checkEdit_estado.TabIndex = 5;
            // 
            // textEdit_cveModalidad
            // 
            this.textEdit_cveModalidad.Location = new System.Drawing.Point(121, 12);
            this.textEdit_cveModalidad.Name = "textEdit_cveModalidad";
            this.textEdit_cveModalidad.Size = new System.Drawing.Size(239, 20);
            this.textEdit_cveModalidad.StyleController = this.layoutControl1;
            this.textEdit_cveModalidad.TabIndex = 4;
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
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(446, 126);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit_cveModalidad;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(352, 24);
            this.layoutControlItem1.Text = "Clave de modalidad:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(97, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(213, 88);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(213, 18);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.checkEdit_estado;
            this.layoutControlItem2.Location = new System.Drawing.Point(352, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(74, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.textEdit_descripcion;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(426, 24);
            this.layoutControlItem3.Text = "Descripción";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(97, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.simpleButton_aceptar;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(213, 58);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButton_cencelar;
            this.layoutControlItem5.Location = new System.Drawing.Point(213, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(213, 40);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // DatosModalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 126);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.SvgImage = global::SIGE_Project.Properties.Resources.groupbyresource1;
            this.Name = "DatosModalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de modalidad";
            this.Load += new System.EventHandler(this.DatosModalidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_descripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_estado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_cveModalidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.CheckEdit checkEdit_estado;
        private DevExpress.XtraEditors.TextEdit textEdit_cveModalidad;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton simpleButton_cencelar;
        private DevExpress.XtraEditors.SimpleButton simpleButton_aceptar;
        private DevExpress.XtraEditors.TextEdit textEdit_descripcion;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}