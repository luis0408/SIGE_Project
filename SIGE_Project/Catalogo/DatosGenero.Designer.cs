namespace SIGE_Project
{
    partial class DatosGenero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosGenero));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.checkEdit_estado = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButton_eliminar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_aceptar = new DevExpress.XtraEditors.SimpleButton();
            this.memoEdit_descripcion = new DevExpress.XtraEditors.MemoEdit();
            this.textEdit_claveGenero = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem_descripcionGenero = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_estado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit_descripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_claveGenero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_descripcionGenero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.checkEdit_estado);
            this.dataLayoutControl1.Controls.Add(this.simpleButton_eliminar);
            this.dataLayoutControl1.Controls.Add(this.simpleButton_aceptar);
            this.dataLayoutControl1.Controls.Add(this.memoEdit_descripcion);
            this.dataLayoutControl1.Controls.Add(this.textEdit_claveGenero);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(451, 170);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // checkEdit_estado
            // 
            this.checkEdit_estado.Location = new System.Drawing.Point(375, 14);
            this.checkEdit_estado.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.checkEdit_estado.Name = "checkEdit_estado";
            this.checkEdit_estado.Properties.Caption = "Activo";
            this.checkEdit_estado.Size = new System.Drawing.Size(62, 24);
            this.checkEdit_estado.StyleController = this.dataLayoutControl1;
            this.checkEdit_estado.TabIndex = 8;
            // 
            // simpleButton_eliminar
            // 
            this.simpleButton_eliminar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton_eliminar.ImageOptions.SvgImage")));
            this.simpleButton_eliminar.Location = new System.Drawing.Point(233, 100);
            this.simpleButton_eliminar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.simpleButton_eliminar.Name = "simpleButton_eliminar";
            this.simpleButton_eliminar.Size = new System.Drawing.Size(204, 44);
            this.simpleButton_eliminar.StyleController = this.dataLayoutControl1;
            this.simpleButton_eliminar.TabIndex = 7;
            this.simpleButton_eliminar.Text = "Cancelar";
            this.simpleButton_eliminar.Click += new System.EventHandler(this.simpleButton_eliminar_Click);
            // 
            // simpleButton_aceptar
            // 
            this.simpleButton_aceptar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton_aceptar.ImageOptions.SvgImage")));
            this.simpleButton_aceptar.Location = new System.Drawing.Point(14, 100);
            this.simpleButton_aceptar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.simpleButton_aceptar.Name = "simpleButton_aceptar";
            this.simpleButton_aceptar.Size = new System.Drawing.Size(215, 44);
            this.simpleButton_aceptar.StyleController = this.dataLayoutControl1;
            this.simpleButton_aceptar.TabIndex = 6;
            this.simpleButton_aceptar.Text = "Aceptar";
            this.simpleButton_aceptar.Click += new System.EventHandler(this.simpleButton_aceptar_Click);
            // 
            // memoEdit_descripcion
            // 
            this.memoEdit_descripcion.Location = new System.Drawing.Point(108, 42);
            this.memoEdit_descripcion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.memoEdit_descripcion.Name = "memoEdit_descripcion";
            this.memoEdit_descripcion.Size = new System.Drawing.Size(329, 54);
            this.memoEdit_descripcion.StyleController = this.dataLayoutControl1;
            this.memoEdit_descripcion.TabIndex = 5;
            // 
            // textEdit_claveGenero
            // 
            this.textEdit_claveGenero.Location = new System.Drawing.Point(108, 14);
            this.textEdit_claveGenero.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textEdit_claveGenero.Name = "textEdit_claveGenero";
            this.textEdit_claveGenero.Size = new System.Drawing.Size(263, 22);
            this.textEdit_claveGenero.StyleController = this.dataLayoutControl1;
            this.textEdit_claveGenero.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem_descripcionGenero,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(451, 170);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit_claveGenero;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(361, 28);
            this.layoutControlItem1.Text = "Clave genero:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(80, 16);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 134);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(427, 12);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem_descripcionGenero
            // 
            this.layoutControlItem_descripcionGenero.Control = this.memoEdit_descripcion;
            this.layoutControlItem_descripcionGenero.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem_descripcionGenero.Name = "layoutControlItem_descripcionGenero";
            this.layoutControlItem_descripcionGenero.Size = new System.Drawing.Size(427, 58);
            this.layoutControlItem_descripcionGenero.Text = "Descripcion:";
            this.layoutControlItem_descripcionGenero.TextSize = new System.Drawing.Size(80, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton_aceptar;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 86);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(219, 48);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.simpleButton_eliminar;
            this.layoutControlItem4.Location = new System.Drawing.Point(219, 86);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(208, 48);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.checkEdit_estado;
            this.layoutControlItem5.Location = new System.Drawing.Point(361, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(66, 28);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // DatosGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 170);
            this.Controls.Add(this.dataLayoutControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("DatosGenero.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.Name = "DatosGenero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos genero";
            this.Load += new System.EventHandler(this.DatosGenero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_estado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit_descripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_claveGenero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_descripcionGenero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.CheckEdit checkEdit_estado;
        private DevExpress.XtraEditors.SimpleButton simpleButton_eliminar;
        private DevExpress.XtraEditors.SimpleButton simpleButton_aceptar;
        private DevExpress.XtraEditors.MemoEdit memoEdit_descripcion;
        private DevExpress.XtraEditors.TextEdit textEdit_claveGenero;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem_descripcionGenero;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}