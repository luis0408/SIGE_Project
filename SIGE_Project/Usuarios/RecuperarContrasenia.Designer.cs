namespace SIGE_Project.Usuarios1
{
    partial class RecuperarContrasenia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarContrasenia));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.textEdit_Correo = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem_Correo = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.textEdit_NuevaContrasenia = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem_NuevaContrasenia = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEdit_ConfirmarContrasenia = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem_ConfirmarContrasenia = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButton_AceptarRestaurarContrasenia = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButton_CancelarRestauracionContresenia = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl_TablaUsuarios = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Correo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_Correo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_NuevaContrasenia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_NuevaContrasenia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_ConfirmarContrasenia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_ConfirmarContrasenia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_TablaUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl_TablaUsuarios);
            this.layoutControl1.Controls.Add(this.simpleButton_CancelarRestauracionContresenia);
            this.layoutControl1.Controls.Add(this.simpleButton_AceptarRestaurarContrasenia);
            this.layoutControl1.Controls.Add(this.textEdit_ConfirmarContrasenia);
            this.layoutControl1.Controls.Add(this.textEdit_NuevaContrasenia);
            this.layoutControl1.Controls.Add(this.textEdit_Correo);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(960, 632);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem_Correo,
            this.emptySpaceItem1,
            this.layoutControlItem_NuevaContrasenia,
            this.layoutControlItem_ConfirmarContrasenia,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(960, 632);
            this.Root.TextVisible = false;
            // 
            // textEdit_Correo
            // 
            this.textEdit_Correo.Location = new System.Drawing.Point(685, 12);
            this.textEdit_Correo.Name = "textEdit_Correo";
            this.textEdit_Correo.Size = new System.Drawing.Size(263, 22);
            this.textEdit_Correo.StyleController = this.layoutControl1;
            this.textEdit_Correo.TabIndex = 4;
            // 
            // layoutControlItem_Correo
            // 
            this.layoutControlItem_Correo.Control = this.textEdit_Correo;
            this.layoutControlItem_Correo.Location = new System.Drawing.Point(537, 0);
            this.layoutControlItem_Correo.Name = "layoutControlItem_Correo";
            this.layoutControlItem_Correo.Size = new System.Drawing.Size(403, 26);
            this.layoutControlItem_Correo.Text = "Correo ";
            this.layoutControlItem_Correo.TextSize = new System.Drawing.Size(124, 16);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(741, 126);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(199, 486);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // textEdit_NuevaContrasenia
            // 
            this.textEdit_NuevaContrasenia.Location = new System.Drawing.Point(685, 38);
            this.textEdit_NuevaContrasenia.Name = "textEdit_NuevaContrasenia";
            this.textEdit_NuevaContrasenia.Size = new System.Drawing.Size(263, 22);
            this.textEdit_NuevaContrasenia.StyleController = this.layoutControl1;
            this.textEdit_NuevaContrasenia.TabIndex = 6;
            // 
            // layoutControlItem_NuevaContrasenia
            // 
            this.layoutControlItem_NuevaContrasenia.Control = this.textEdit_NuevaContrasenia;
            this.layoutControlItem_NuevaContrasenia.Location = new System.Drawing.Point(537, 26);
            this.layoutControlItem_NuevaContrasenia.Name = "layoutControlItem_NuevaContrasenia";
            this.layoutControlItem_NuevaContrasenia.Size = new System.Drawing.Size(403, 26);
            this.layoutControlItem_NuevaContrasenia.Text = "Nueva contraseña";
            this.layoutControlItem_NuevaContrasenia.TextSize = new System.Drawing.Size(124, 16);
            // 
            // textEdit_ConfirmarContrasenia
            // 
            this.textEdit_ConfirmarContrasenia.Location = new System.Drawing.Point(685, 64);
            this.textEdit_ConfirmarContrasenia.Name = "textEdit_ConfirmarContrasenia";
            this.textEdit_ConfirmarContrasenia.Size = new System.Drawing.Size(263, 22);
            this.textEdit_ConfirmarContrasenia.StyleController = this.layoutControl1;
            this.textEdit_ConfirmarContrasenia.TabIndex = 7;
            // 
            // layoutControlItem_ConfirmarContrasenia
            // 
            this.layoutControlItem_ConfirmarContrasenia.Control = this.textEdit_ConfirmarContrasenia;
            this.layoutControlItem_ConfirmarContrasenia.Location = new System.Drawing.Point(537, 52);
            this.layoutControlItem_ConfirmarContrasenia.Name = "layoutControlItem_ConfirmarContrasenia";
            this.layoutControlItem_ConfirmarContrasenia.Size = new System.Drawing.Size(403, 26);
            this.layoutControlItem_ConfirmarContrasenia.Text = "Confirmar contraseña";
            this.layoutControlItem_ConfirmarContrasenia.TextSize = new System.Drawing.Size(124, 16);
            // 
            // simpleButton_AceptarRestaurarContrasenia
            // 
            this.simpleButton_AceptarRestaurarContrasenia.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton_AceptarRestaurarContrasenia.Location = new System.Drawing.Point(549, 90);
            this.simpleButton_AceptarRestaurarContrasenia.Name = "simpleButton_AceptarRestaurarContrasenia";
            this.simpleButton_AceptarRestaurarContrasenia.Size = new System.Drawing.Size(200, 44);
            this.simpleButton_AceptarRestaurarContrasenia.StyleController = this.layoutControl1;
            this.simpleButton_AceptarRestaurarContrasenia.TabIndex = 8;
            this.simpleButton_AceptarRestaurarContrasenia.Text = "Aceptar";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButton_AceptarRestaurarContrasenia;
            this.layoutControlItem5.Location = new System.Drawing.Point(537, 78);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(204, 534);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // simpleButton_CancelarRestauracionContresenia
            // 
            this.simpleButton_CancelarRestauracionContresenia.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton_CancelarRestauracionContresenia.Location = new System.Drawing.Point(753, 90);
            this.simpleButton_CancelarRestauracionContresenia.Name = "simpleButton_CancelarRestauracionContresenia";
            this.simpleButton_CancelarRestauracionContresenia.Size = new System.Drawing.Size(195, 44);
            this.simpleButton_CancelarRestauracionContresenia.StyleController = this.layoutControl1;
            this.simpleButton_CancelarRestauracionContresenia.TabIndex = 9;
            this.simpleButton_CancelarRestauracionContresenia.Text = "Cancelar";
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.simpleButton_CancelarRestauracionContresenia;
            this.layoutControlItem6.Location = new System.Drawing.Point(741, 78);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(199, 48);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // gridControl_TablaUsuarios
            // 
            this.gridControl_TablaUsuarios.Location = new System.Drawing.Point(12, 12);
            this.gridControl_TablaUsuarios.MainView = this.gridView1;
            this.gridControl_TablaUsuarios.Name = "gridControl_TablaUsuarios";
            this.gridControl_TablaUsuarios.Size = new System.Drawing.Size(533, 608);
            this.gridControl_TablaUsuarios.TabIndex = 10;
            this.gridControl_TablaUsuarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl_TablaUsuarios;
            this.gridView1.Name = "gridView1";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl_TablaUsuarios;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(537, 612);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // RecuperarContrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 632);
            this.Controls.Add(this.layoutControl1);
            this.Name = "RecuperarContrasenia";
            this.Text = "RecuperarContrasenia";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Correo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_Correo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_NuevaContrasenia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_NuevaContrasenia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_ConfirmarContrasenia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_ConfirmarContrasenia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_TablaUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton simpleButton_CancelarRestauracionContresenia;
        private DevExpress.XtraEditors.SimpleButton simpleButton_AceptarRestaurarContrasenia;
        private DevExpress.XtraEditors.TextEdit textEdit_ConfirmarContrasenia;
        private DevExpress.XtraEditors.TextEdit textEdit_NuevaContrasenia;
        private DevExpress.XtraEditors.TextEdit textEdit_Correo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem_Correo;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem_NuevaContrasenia;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem_ConfirmarContrasenia;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.GridControl gridControl_TablaUsuarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}