namespace SIGE_Project.Catalogo
{
    partial class DatosSemestres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosSemestres));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButton_cancelar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_aceptar = new DevExpress.XtraEditors.SimpleButton();
            this.memoEdit_descripcionSemestres = new DevExpress.XtraEditors.MemoEdit();
            this.checkEdit_estado = new DevExpress.XtraEditors.CheckEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit_descripcionSemestres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_estado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButton_cancelar);
            this.layoutControl1.Controls.Add(this.simpleButton_aceptar);
            this.layoutControl1.Controls.Add(this.memoEdit_descripcionSemestres);
            this.layoutControl1.Controls.Add(this.checkEdit_estado);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(423, 187);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButton_cancelar
            // 
            this.simpleButton_cancelar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton_cancelar.ImageOptions.SvgImage")));
            this.simpleButton_cancelar.Location = new System.Drawing.Point(213, 131);
            this.simpleButton_cancelar.Name = "simpleButton_cancelar";
            this.simpleButton_cancelar.Size = new System.Drawing.Size(198, 44);
            this.simpleButton_cancelar.StyleController = this.layoutControl1;
            this.simpleButton_cancelar.TabIndex = 7;
            this.simpleButton_cancelar.Text = "Cancelar";
            this.simpleButton_cancelar.Click += new System.EventHandler(this.simpleButton_cancelar_Click);
            // 
            // simpleButton_aceptar
            // 
            this.simpleButton_aceptar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton_aceptar.ImageOptions.SvgImage")));
            this.simpleButton_aceptar.Location = new System.Drawing.Point(12, 131);
            this.simpleButton_aceptar.Name = "simpleButton_aceptar";
            this.simpleButton_aceptar.Size = new System.Drawing.Size(197, 44);
            this.simpleButton_aceptar.StyleController = this.layoutControl1;
            this.simpleButton_aceptar.TabIndex = 6;
            this.simpleButton_aceptar.Text = "Aceptar";
            this.simpleButton_aceptar.Click += new System.EventHandler(this.simpleButton_aceptar_Click);
            // 
            // memoEdit_descripcionSemestres
            // 
            this.memoEdit_descripcionSemestres.Location = new System.Drawing.Point(94, 40);
            this.memoEdit_descripcionSemestres.Name = "memoEdit_descripcionSemestres";
            this.memoEdit_descripcionSemestres.Size = new System.Drawing.Size(317, 87);
            this.memoEdit_descripcionSemestres.StyleController = this.layoutControl1;
            this.memoEdit_descripcionSemestres.TabIndex = 5;
            // 
            // checkEdit_estado
            // 
            this.checkEdit_estado.Location = new System.Drawing.Point(315, 12);
            this.checkEdit_estado.Name = "checkEdit_estado";
            this.checkEdit_estado.Properties.Caption = "Activo";
            this.checkEdit_estado.Size = new System.Drawing.Size(96, 24);
            this.checkEdit_estado.StyleController = this.layoutControl1;
            this.checkEdit_estado.TabIndex = 4;
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
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(423, 187);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.checkEdit_estado;
            this.layoutControlItem1.Location = new System.Drawing.Point(303, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(100, 28);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(303, 28);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.memoEdit_descripcionSemestres;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(403, 91);
            this.layoutControlItem2.Text = "Descripción:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(70, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton_aceptar;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 119);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(201, 48);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.simpleButton_cancelar;
            this.layoutControlItem4.Location = new System.Drawing.Point(201, 119);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(202, 48);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // DatosSemestres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 187);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.SvgImage = global::SIGE_Project.Properties.Resources.actions_calendar;
            this.MaximizeBox = false;
            this.Name = "DatosSemestres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Semestres";
            this.Load += new System.EventHandler(this.DatosSemestres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit_descripcionSemestres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_estado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton simpleButton_cancelar;
        private DevExpress.XtraEditors.SimpleButton simpleButton_aceptar;
        private DevExpress.XtraEditors.MemoEdit memoEdit_descripcionSemestres;
        private DevExpress.XtraEditors.CheckEdit checkEdit_estado;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}