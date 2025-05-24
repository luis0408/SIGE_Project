namespace SIGE_Project.Catalogo
{
    partial class DatosGeneracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosGeneracion));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit_status = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButton_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_agree = new DevExpress.XtraEditors.SimpleButton();
            this.dateEdit_anioInicio = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit_anioFin = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEdit_idGeneracion = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_anioInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_anioInicio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_anioFin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_anioFin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_idGeneracion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.textEdit_idGeneracion);
            this.dataLayoutControl1.Controls.Add(this.labelControl1);
            this.dataLayoutControl1.Controls.Add(this.checkEdit_status);
            this.dataLayoutControl1.Controls.Add(this.simpleButton_cancel);
            this.dataLayoutControl1.Controls.Add(this.simpleButton_agree);
            this.dataLayoutControl1.Controls.Add(this.dateEdit_anioInicio);
            this.dataLayoutControl1.Controls.Add(this.dateEdit_anioFin);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(2498, 0, 650, 400);
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(530, 170);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(189, 19);
            this.labelControl1.StyleController = this.dataLayoutControl1;
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Datos de la Generación";
            // 
            // checkEdit_status
            // 
            this.checkEdit_status.Location = new System.Drawing.Point(377, 35);
            this.checkEdit_status.Name = "checkEdit_status";
            this.checkEdit_status.Properties.Caption = "Activo";
            this.checkEdit_status.Size = new System.Drawing.Size(141, 20);
            this.checkEdit_status.StyleController = this.dataLayoutControl1;
            this.checkEdit_status.TabIndex = 8;
            // 
            // simpleButton_cancel
            // 
            this.simpleButton_cancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton_cancel.ImageOptions.SvgImage")));
            this.simpleButton_cancel.Location = new System.Drawing.Point(262, 107);
            this.simpleButton_cancel.Name = "simpleButton_cancel";
            this.simpleButton_cancel.Size = new System.Drawing.Size(256, 36);
            this.simpleButton_cancel.StyleController = this.dataLayoutControl1;
            this.simpleButton_cancel.TabIndex = 7;
            this.simpleButton_cancel.Text = "Cancelar";
            this.simpleButton_cancel.Click += new System.EventHandler(this.simpleButton_cancel_Click);
            // 
            // simpleButton_agree
            // 
            this.simpleButton_agree.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton_agree.ImageOptions.SvgImage")));
            this.simpleButton_agree.Location = new System.Drawing.Point(12, 107);
            this.simpleButton_agree.Name = "simpleButton_agree";
            this.simpleButton_agree.Size = new System.Drawing.Size(246, 36);
            this.simpleButton_agree.StyleController = this.dataLayoutControl1;
            this.simpleButton_agree.TabIndex = 6;
            this.simpleButton_agree.Text = "Aceptar";
            this.simpleButton_agree.Click += new System.EventHandler(this.simpleButton_agree_Click);
            // 
            // dateEdit_anioInicio
            // 
            this.dateEdit_anioInicio.EditValue = null;
            this.dateEdit_anioInicio.Location = new System.Drawing.Point(71, 59);
            this.dateEdit_anioInicio.Name = "dateEdit_anioInicio";
            this.dateEdit_anioInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_anioInicio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_anioInicio.Properties.DisplayFormat.FormatString = "";
            this.dateEdit_anioInicio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit_anioInicio.Properties.EditFormat.FormatString = "";
            this.dateEdit_anioInicio.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit_anioInicio.Properties.MaskSettings.Set("mask", "yyyy");
            this.dateEdit_anioInicio.Properties.ShowMonthHeaders = false;
            this.dateEdit_anioInicio.Properties.ShowToday = false;
            this.dateEdit_anioInicio.Properties.UseMaskAsDisplayFormat = true;
            this.dateEdit_anioInicio.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView;
            this.dateEdit_anioInicio.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearsGroupView;
            this.dateEdit_anioInicio.Size = new System.Drawing.Size(302, 20);
            this.dateEdit_anioInicio.StyleController = this.dataLayoutControl1;
            this.dateEdit_anioInicio.TabIndex = 4;
            // 
            // dateEdit_anioFin
            // 
            this.dateEdit_anioFin.EditValue = null;
            this.dateEdit_anioFin.Location = new System.Drawing.Point(71, 83);
            this.dateEdit_anioFin.Name = "dateEdit_anioFin";
            this.dateEdit_anioFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_anioFin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_anioFin.Properties.DisplayFormat.FormatString = "";
            this.dateEdit_anioFin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit_anioFin.Properties.EditFormat.FormatString = "";
            this.dateEdit_anioFin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit_anioFin.Properties.MaskSettings.Set("mask", "yyyy");
            this.dateEdit_anioFin.Properties.ShowMonthHeaders = false;
            this.dateEdit_anioFin.Properties.ShowToday = false;
            this.dateEdit_anioFin.Properties.UseMaskAsDisplayFormat = true;
            this.dateEdit_anioFin.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView;
            this.dateEdit_anioFin.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearsGroupView;
            this.dateEdit_anioFin.Size = new System.Drawing.Size(302, 20);
            this.dateEdit_anioFin.StyleController = this.dataLayoutControl1;
            this.dateEdit_anioFin.TabIndex = 5;
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
            this.emptySpaceItem2,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.emptySpaceItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(530, 170);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dateEdit_anioInicio;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 47);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(365, 24);
            this.layoutControlItem1.Text = "Año Inicio";
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 135);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(510, 15);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dateEdit_anioFin;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 71);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(365, 24);
            this.layoutControlItem2.Text = "Año Fin";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton_agree;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 95);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(250, 40);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.simpleButton_cancel;
            this.layoutControlItem4.Location = new System.Drawing.Point(250, 95);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(260, 40);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.checkEdit_status;
            this.layoutControlItem5.Location = new System.Drawing.Point(365, 23);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(145, 48);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.Location = new System.Drawing.Point(365, 71);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(145, 24);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.labelControl1;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(510, 23);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // textEdit_idGeneracion
            // 
            this.textEdit_idGeneracion.Location = new System.Drawing.Point(71, 35);
            this.textEdit_idGeneracion.Name = "textEdit_idGeneracion";
            this.textEdit_idGeneracion.Properties.ReadOnly = true;
            this.textEdit_idGeneracion.Size = new System.Drawing.Size(119, 20);
            this.textEdit_idGeneracion.StyleController = this.dataLayoutControl1;
            this.textEdit_idGeneracion.TabIndex = 10;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.textEdit_idGeneracion;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 23);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(182, 24);
            this.layoutControlItem7.Text = "Id:";
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.Location = new System.Drawing.Point(182, 23);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(183, 24);
            // 
            // DatosGeneracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 170);
            this.Controls.Add(this.dataLayoutControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("DatosGeneracion.IconOptions.SvgImage")));
            this.Name = "DatosGeneracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Generacion";
            this.Load += new System.EventHandler(this.DatosGeneracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_anioInicio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_anioInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_anioFin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_anioFin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_idGeneracion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton simpleButton_cancel;
        private DevExpress.XtraEditors.SimpleButton simpleButton_agree;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit checkEdit_status;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.DateEdit dateEdit_anioInicio;
        private DevExpress.XtraEditors.DateEdit dateEdit_anioFin;
        private DevExpress.XtraEditors.TextEdit textEdit_idGeneracion;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}