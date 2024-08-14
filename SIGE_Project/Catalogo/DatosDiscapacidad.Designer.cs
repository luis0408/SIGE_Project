namespace SIGE_Project.Catalogo
{
    partial class DatosDiscapacidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosDiscapacidad));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButton_cancelar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_aceptar = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.memoEdit_descripcion = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.checkEdit_estado = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit_descripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_estado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.checkEdit_estado);
            this.layoutControl1.Controls.Add(this.memoEdit_descripcion);
            this.layoutControl1.Controls.Add(this.simpleButton_cancelar);
            this.layoutControl1.Controls.Add(this.simpleButton_aceptar);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(635, 222);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButton_cancelar
            // 
            this.simpleButton_cancelar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton_cancelar.ImageOptions.SvgImage")));
            this.simpleButton_cancelar.Location = new System.Drawing.Point(313, 150);
            this.simpleButton_cancelar.Name = "simpleButton_cancelar";
            this.simpleButton_cancelar.Size = new System.Drawing.Size(306, 56);
            this.simpleButton_cancelar.StyleController = this.layoutControl1;
            this.simpleButton_cancelar.TabIndex = 7;
            this.simpleButton_cancelar.Text = "Cancelar";
            this.simpleButton_cancelar.Click += new System.EventHandler(this.simpleButton_cancelar_Click);
            // 
            // simpleButton_aceptar
            // 
            this.simpleButton_aceptar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton_aceptar.ImageOptions.SvgImage")));
            this.simpleButton_aceptar.Location = new System.Drawing.Point(16, 150);
            this.simpleButton_aceptar.Name = "simpleButton_aceptar";
            this.simpleButton_aceptar.Size = new System.Drawing.Size(291, 56);
            this.simpleButton_aceptar.StyleController = this.layoutControl1;
            this.simpleButton_aceptar.TabIndex = 6;
            this.simpleButton_aceptar.Text = "Aceptar";
            this.simpleButton_aceptar.Click += new System.EventHandler(this.simpleButton_aceptar_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(635, 222);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(516, 37);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton_aceptar;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 134);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(297, 62);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.simpleButton_cancelar;
            this.layoutControlItem4.Location = new System.Drawing.Point(297, 134);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(312, 62);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // memoEdit_descripcion
            // 
            this.memoEdit_descripcion.Location = new System.Drawing.Point(119, 53);
            this.memoEdit_descripcion.Name = "memoEdit_descripcion";
            this.memoEdit_descripcion.Size = new System.Drawing.Size(500, 91);
            this.memoEdit_descripcion.StyleController = this.layoutControl1;
            this.memoEdit_descripcion.TabIndex = 9;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.memoEdit_descripcion;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 37);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(609, 97);
            this.layoutControlItem2.Text = "Descripcion:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(87, 19);
            // 
            // checkEdit_estado
            // 
            this.checkEdit_estado.Location = new System.Drawing.Point(532, 16);
            this.checkEdit_estado.Name = "checkEdit_estado";
            this.checkEdit_estado.Properties.Caption = "Estado";
            this.checkEdit_estado.Size = new System.Drawing.Size(87, 31);
            this.checkEdit_estado.StyleController = this.layoutControl1;
            this.checkEdit_estado.TabIndex = 10;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.checkEdit_estado;
            this.layoutControlItem5.Location = new System.Drawing.Point(516, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(93, 37);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // DatosDiscapacidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 222);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("DatosDiscapacidad.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.Name = "DatosDiscapacidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discapacidades";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit_descripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_estado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton simpleButton_cancelar;
        private DevExpress.XtraEditors.SimpleButton simpleButton_aceptar;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.MemoEdit memoEdit_descripcion;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.CheckEdit checkEdit_estado;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}