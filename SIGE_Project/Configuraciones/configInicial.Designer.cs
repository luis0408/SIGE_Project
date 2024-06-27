using DevExpress.Utils.Behaviors;

namespace SIGE_Project.Configuraciones
{
    partial class configInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(configInicial));
            this.simpleButton_testConex = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_saveConfig = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.textEdit_cadenaConexion = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_contrasenia = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_usuario = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_baseDatos = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_servidor = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_cadenaConexion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_contrasenia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_usuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_baseDatos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_servidor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton_testConex
            // 
            this.simpleButton_testConex.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton_testConex.ImageOptions.SvgImage")));
            this.simpleButton_testConex.Location = new System.Drawing.Point(24, 191);
            this.simpleButton_testConex.Name = "simpleButton_testConex";
            this.simpleButton_testConex.Size = new System.Drawing.Size(416, 36);
            this.simpleButton_testConex.StyleController = this.layoutControl1;
            this.simpleButton_testConex.TabIndex = 9;
            this.simpleButton_testConex.Text = "Probar conexión";
            this.simpleButton_testConex.Click += new System.EventHandler(this.simpleButton_testConex_Click);
            // 
            // simpleButton_saveConfig
            // 
            this.simpleButton_saveConfig.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton_saveConfig.ImageOptions.SvgImage")));
            this.simpleButton_saveConfig.Location = new System.Drawing.Point(12, 243);
            this.simpleButton_saveConfig.Name = "simpleButton_saveConfig";
            this.simpleButton_saveConfig.Size = new System.Drawing.Size(440, 36);
            this.simpleButton_saveConfig.StyleController = this.layoutControl1;
            this.simpleButton_saveConfig.TabIndex = 11;
            this.simpleButton_saveConfig.Text = "Guardar configuración";
            this.simpleButton_saveConfig.Click += new System.EventHandler(this.simpleButton_saveConfig_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlGroup1,
            this.layoutControlItem8});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(464, 366);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.simpleButton_saveConfig;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 231);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(444, 40);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(444, 231);
            this.layoutControlGroup1.Text = "Conexión a base de datos";
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 136);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(420, 10);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.simpleButton_testConex;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 146);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(420, 40);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 271);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(444, 75);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButton_saveConfig);
            this.layoutControl1.Controls.Add(this.simpleButton_testConex);
            this.layoutControl1.Controls.Add(this.textEdit_cadenaConexion);
            this.layoutControl1.Controls.Add(this.textEdit_contrasenia);
            this.layoutControl1.Controls.Add(this.textEdit_usuario);
            this.layoutControl1.Controls.Add(this.textEdit_baseDatos);
            this.layoutControl1.Controls.Add(this.textEdit_servidor);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(543, 186, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(464, 366);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // textEdit_cadenaConexion
            // 
            this.textEdit_cadenaConexion.Location = new System.Drawing.Point(24, 157);
            this.textEdit_cadenaConexion.Name = "textEdit_cadenaConexion";
            this.textEdit_cadenaConexion.Properties.ReadOnly = true;
            this.textEdit_cadenaConexion.Size = new System.Drawing.Size(416, 20);
            this.textEdit_cadenaConexion.StyleController = this.layoutControl1;
            this.textEdit_cadenaConexion.TabIndex = 8;
            // 
            // textEdit_contrasenia
            // 
            this.textEdit_contrasenia.EditValue = "123";
            this.textEdit_contrasenia.Location = new System.Drawing.Point(138, 117);
            this.textEdit_contrasenia.Name = "textEdit_contrasenia";
            this.textEdit_contrasenia.Properties.PasswordChar = '*';
            this.textEdit_contrasenia.Properties.ReadOnly = true;
            this.textEdit_contrasenia.Size = new System.Drawing.Size(302, 20);
            this.textEdit_contrasenia.StyleController = this.layoutControl1;
            this.textEdit_contrasenia.TabIndex = 7;
            // 
            // textEdit_usuario
            // 
            this.textEdit_usuario.EditValue = "adminPV";
            this.textEdit_usuario.Location = new System.Drawing.Point(138, 93);
            this.textEdit_usuario.Name = "textEdit_usuario";
            this.textEdit_usuario.Properties.ReadOnly = true;
            this.textEdit_usuario.Size = new System.Drawing.Size(302, 20);
            this.textEdit_usuario.StyleController = this.layoutControl1;
            this.textEdit_usuario.TabIndex = 6;
            // 
            // textEdit_baseDatos
            // 
            this.textEdit_baseDatos.EditValue = "PV_SoftSalePoint";
            this.textEdit_baseDatos.Location = new System.Drawing.Point(138, 69);
            this.textEdit_baseDatos.Name = "textEdit_baseDatos";
            this.textEdit_baseDatos.Properties.ReadOnly = true;
            this.textEdit_baseDatos.Size = new System.Drawing.Size(302, 20);
            this.textEdit_baseDatos.StyleController = this.layoutControl1;
            this.textEdit_baseDatos.TabIndex = 5;
            // 
            // textEdit_servidor
            // 
            this.textEdit_servidor.EditValue = "DESKTOP-DUQAPE3\\SERV08";
            this.textEdit_servidor.Location = new System.Drawing.Point(138, 45);
            this.textEdit_servidor.Name = "textEdit_servidor";
            this.textEdit_servidor.Properties.ReadOnly = true;
            this.textEdit_servidor.Size = new System.Drawing.Size(302, 20);
            this.textEdit_servidor.StyleController = this.layoutControl1;
            this.textEdit_servidor.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit_servidor;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(420, 24);
            this.layoutControlItem1.Text = "Servidor:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(102, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textEdit_baseDatos;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(420, 24);
            this.layoutControlItem2.Text = "Base de datos:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(102, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.textEdit_usuario;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(420, 24);
            this.layoutControlItem3.Text = "Usuario:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(102, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.textEdit_contrasenia;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(420, 24);
            this.layoutControlItem4.Text = "Contraseña:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(102, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.textEdit_cadenaConexion;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(420, 40);
            this.layoutControlItem5.Text = "Cadena de conexión:";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(102, 13);
            // 
            // configInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 366);
            this.Controls.Add(this.layoutControl1);
            this.MaximizeBox = false;
            this.Name = "configInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuración";
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_cadenaConexion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_contrasenia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_usuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_baseDatos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_servidor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton_saveConfig;
        private DevExpress.XtraEditors.SimpleButton simpleButton_testConex;
        private DevExpress.XtraEditors.TextEdit textEdit_cadenaConexion;
        private DevExpress.XtraEditors.TextEdit textEdit_contrasenia;
        private DevExpress.XtraEditors.TextEdit textEdit_usuario;
        private DevExpress.XtraEditors.TextEdit textEdit_baseDatos;
        private DevExpress.XtraEditors.TextEdit textEdit_servidor;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}