﻿namespace SIGE_Project.Catalogo
{
    partial class DatosDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosDepartamento));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButton_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_agree = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEdit_descripcion = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.checkEdit_status = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lookUpEdit_curp = new DevExpress.XtraEditors.LookUpEdit();
            this.textEdit_cveDepartamento = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_descripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_curp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_cveDepartamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textEdit_cveDepartamento);
            this.layoutControl1.Controls.Add(this.checkEdit_status);
            this.layoutControl1.Controls.Add(this.textEdit_descripcion);
            this.layoutControl1.Controls.Add(this.simpleButton_cancel);
            this.layoutControl1.Controls.Add(this.simpleButton_agree);
            this.layoutControl1.Controls.Add(this.lookUpEdit_curp);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(702, 268);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButton_cancel
            // 
            this.simpleButton_cancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton_cancel.ImageOptions.SvgImage")));
            this.simpleButton_cancel.Location = new System.Drawing.Point(353, 129);
            this.simpleButton_cancel.Name = "simpleButton_cancel";
            this.simpleButton_cancel.Size = new System.Drawing.Size(337, 36);
            this.simpleButton_cancel.StyleController = this.layoutControl1;
            this.simpleButton_cancel.TabIndex = 12;
            this.simpleButton_cancel.Text = "Cancelar";
            // 
            // simpleButton_agree
            // 
            this.simpleButton_agree.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton_agree.ImageOptions.SvgImage")));
            this.simpleButton_agree.Location = new System.Drawing.Point(12, 129);
            this.simpleButton_agree.Name = "simpleButton_agree";
            this.simpleButton_agree.Size = new System.Drawing.Size(337, 36);
            this.simpleButton_agree.StyleController = this.layoutControl1;
            this.simpleButton_agree.TabIndex = 11;
            this.simpleButton_agree.Text = "Aceptar";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem10,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(702, 268);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 48);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(682, 69);
            this.layoutControlGroup1.Text = "Encargado";
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.simpleButton_agree;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 117);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(341, 40);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.simpleButton_cancel;
            this.layoutControlItem8.Location = new System.Drawing.Point(341, 117);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(341, 40);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.lookUpEdit_curp;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(658, 24);
            this.layoutControlItem6.Text = "CURP";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(54, 13);
            // 
            // textEdit_descripcion
            // 
            this.textEdit_descripcion.Location = new System.Drawing.Point(78, 36);
            this.textEdit_descripcion.Name = "textEdit_descripcion";
            this.textEdit_descripcion.Size = new System.Drawing.Size(612, 20);
            this.textEdit_descripcion.StyleController = this.layoutControl1;
            this.textEdit_descripcion.TabIndex = 14;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.textEdit_descripcion;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem10.Text = "Descripcion";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(54, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 157);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(682, 91);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // checkEdit_status
            // 
            this.checkEdit_status.Location = new System.Drawing.Point(473, 12);
            this.checkEdit_status.Name = "checkEdit_status";
            this.checkEdit_status.Properties.Caption = "Activo";
            this.checkEdit_status.Size = new System.Drawing.Size(217, 20);
            this.checkEdit_status.StyleController = this.layoutControl1;
            this.checkEdit_status.TabIndex = 15;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.checkEdit_status;
            this.layoutControlItem1.Location = new System.Drawing.Point(461, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(221, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // lookUpEdit_curp
            // 
            this.lookUpEdit_curp.Location = new System.Drawing.Point(90, 93);
            this.lookUpEdit_curp.Name = "lookUpEdit_curp";
            this.lookUpEdit_curp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_curp.Properties.NullText = "";
            this.lookUpEdit_curp.Size = new System.Drawing.Size(588, 20);
            this.lookUpEdit_curp.StyleController = this.layoutControl1;
            this.lookUpEdit_curp.TabIndex = 9;
            // 
            // textEdit_cveDepartamento
            // 
            this.textEdit_cveDepartamento.Location = new System.Drawing.Point(78, 12);
            this.textEdit_cveDepartamento.Name = "textEdit_cveDepartamento";
            this.textEdit_cveDepartamento.Size = new System.Drawing.Size(391, 20);
            this.textEdit_cveDepartamento.StyleController = this.layoutControl1;
            this.textEdit_cveDepartamento.TabIndex = 16;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textEdit_cveDepartamento;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(461, 24);
            this.layoutControlItem2.Text = "Clave";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(54, 13);
            // 
            // DatosDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 268);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("DatosDepartamento.IconOptions.SvgImage")));
            this.Name = "DatosDepartamento";
            this.Text = "Datos del Departamento";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_descripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_curp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_cveDepartamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton simpleButton_cancel;
        private DevExpress.XtraEditors.SimpleButton simpleButton_agree;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.CheckEdit checkEdit_status;
        private DevExpress.XtraEditors.TextEdit textEdit_descripcion;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_curp;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit textEdit_cveDepartamento;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}