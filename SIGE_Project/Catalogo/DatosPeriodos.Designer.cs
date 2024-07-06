namespace SIGE_Project.Catalogo
{
    partial class DatosPeriodos
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
            this.textEdit_idCicloEscolar = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton_cancelar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_aceptar = new DevExpress.XtraEditors.SimpleButton();
            this.dateEdit_inicio = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit_fin = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_idCicloEscolar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_inicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_inicio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_fin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_fin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textEdit_idCicloEscolar);
            this.layoutControl1.Controls.Add(this.simpleButton_cancelar);
            this.layoutControl1.Controls.Add(this.simpleButton_aceptar);
            this.layoutControl1.Controls.Add(this.dateEdit_inicio);
            this.layoutControl1.Controls.Add(this.dateEdit_fin);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(507, 0, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(355, 108);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // textEdit_idCicloEscolar
            // 
            this.textEdit_idCicloEscolar.Location = new System.Drawing.Point(98, 12);
            this.textEdit_idCicloEscolar.Name = "textEdit_idCicloEscolar";
            this.textEdit_idCicloEscolar.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit_idCicloEscolar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEdit_idCicloEscolar.Size = new System.Drawing.Size(245, 20);
            this.textEdit_idCicloEscolar.StyleController = this.layoutControl1;
            this.textEdit_idCicloEscolar.TabIndex = 10;
            // 
            // simpleButton_cancelar
            // 
            this.simpleButton_cancelar.ImageOptions.SvgImage = global::SIGE_Project.Properties.Resources.close;
            this.simpleButton_cancelar.Location = new System.Drawing.Point(179, 60);
            this.simpleButton_cancelar.Name = "simpleButton_cancelar";
            this.simpleButton_cancelar.Size = new System.Drawing.Size(164, 36);
            this.simpleButton_cancelar.StyleController = this.layoutControl1;
            this.simpleButton_cancelar.TabIndex = 9;
            this.simpleButton_cancelar.Text = "Cancelar";
            this.simpleButton_cancelar.Click += new System.EventHandler(this.simpleButton_cancelar_Click);
            // 
            // simpleButton_aceptar
            // 
            this.simpleButton_aceptar.ImageOptions.SvgImage = global::SIGE_Project.Properties.Resources.save;
            this.simpleButton_aceptar.Location = new System.Drawing.Point(12, 60);
            this.simpleButton_aceptar.Name = "simpleButton_aceptar";
            this.simpleButton_aceptar.Size = new System.Drawing.Size(163, 36);
            this.simpleButton_aceptar.StyleController = this.layoutControl1;
            this.simpleButton_aceptar.TabIndex = 8;
            this.simpleButton_aceptar.Text = "Aceptar";
            this.simpleButton_aceptar.Click += new System.EventHandler(this.simpleButton_aceptar_Click);
            // 
            // dateEdit_inicio
            // 
            this.dateEdit_inicio.EditValue = null;
            this.dateEdit_inicio.Location = new System.Drawing.Point(98, 36);
            this.dateEdit_inicio.Name = "dateEdit_inicio";
            this.dateEdit_inicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_inicio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_inicio.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
            this.dateEdit_inicio.Properties.DisplayFormat.FormatString = "Y";
            this.dateEdit_inicio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit_inicio.Properties.EditFormat.FormatString = "Y";
            this.dateEdit_inicio.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit_inicio.Properties.MaskSettings.Set("mask", "y");
            this.dateEdit_inicio.Properties.UseMaskAsDisplayFormat = true;
            this.dateEdit_inicio.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView;
            this.dateEdit_inicio.Size = new System.Drawing.Size(77, 20);
            this.dateEdit_inicio.StyleController = this.layoutControl1;
            this.dateEdit_inicio.TabIndex = 4;
            // 
            // dateEdit_fin
            // 
            this.dateEdit_fin.EditValue = null;
            this.dateEdit_fin.Location = new System.Drawing.Point(265, 36);
            this.dateEdit_fin.Name = "dateEdit_fin";
            this.dateEdit_fin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_fin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_fin.Properties.DisplayFormat.FormatString = "";
            this.dateEdit_fin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit_fin.Properties.EditFormat.FormatString = "";
            this.dateEdit_fin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit_fin.Properties.MaskSettings.Set("mask", "MM/yyyy");
            this.dateEdit_fin.Properties.UseMaskAsDisplayFormat = true;
            this.dateEdit_fin.Size = new System.Drawing.Size(78, 20);
            this.dateEdit_fin.StyleController = this.layoutControl1;
            this.dateEdit_fin.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(355, 108);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dateEdit_inicio;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(167, 24);
            this.layoutControlItem1.Text = "Inicio:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButton_aceptar;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(167, 40);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.simpleButton_cancelar;
            this.layoutControlItem6.Location = new System.Drawing.Point(167, 48);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(168, 40);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.textEdit_idCicloEscolar;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(335, 24);
            this.layoutControlItem7.Text = "Id ciclo escolar:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dateEdit_fin;
            this.layoutControlItem2.Location = new System.Drawing.Point(167, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(168, 24);
            this.layoutControlItem2.Text = "Fin:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(74, 13);
            // 
            // DatosPeriodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 108);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.SvgImage = global::SIGE_Project.Properties.Resources.actions_calendar;
            this.MaximizeBox = false;
            this.Name = "DatosPeriodos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de periodos";
            this.Load += new System.EventHandler(this.DatosPeriodos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_idCicloEscolar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_inicio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_inicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_fin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_fin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton simpleButton_cancelar;
        private DevExpress.XtraEditors.SimpleButton simpleButton_aceptar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.TextEdit textEdit_idCicloEscolar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.DateEdit dateEdit_inicio;
        private DevExpress.XtraEditors.DateEdit dateEdit_fin;
    }
}