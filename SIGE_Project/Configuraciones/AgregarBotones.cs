using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGE_Project.Configuraciones
{
    public partial class AgregarBotones : DevExpress.XtraEditors.XtraForm
    {
        decimal idPestania = -1;
        decimal idCategoria, idBoton;
        string nombreBoton, nombreAplicacion;

        private void AgregarBotones_Load(object sender, EventArgs e)
        {
            try
            {
                pictureEdit_imgBoton.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
                pictureEdit_imgBoton.Size = pictureEdit_imgBoton.Image.Size;
            }
            catch (Exception ex)
            {
                //XtraMessageBox.Show("Se generó un error: "+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            if (idPestania > -1)
            {
                ////Se cargan datos ya que al entrar al "if" indica que se esta editando un registro
                textEdit_idBoton.Text = Convert.ToString(idBoton);

                textEdit_idBoton.ReadOnly = true;
                textEdit_nombreBoton.Text = nombreBoton;
                textEdit_aplicacion.Text = nombreAplicacion;
                cargaImagen("select imagen  from PV_CONF_Menus where idpestaña=" + idPestania + " and idcat=" + idCategoria + " and iditem=" + idBoton);
            }
        }

        public AgregarBotones()
        {
            InitializeComponent();
        }

        private void simpleButton_save_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void simpleButton_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        public AgregarBotones(decimal _idPes, decimal _idCat, decimal _idBoton, string _nombreBoton, string _nombreAplicacion)
        {
            idPestania = _idPes;
            idCategoria = _idCat;
            idBoton = _idBoton;
            nombreBoton = _nombreBoton;
            nombreAplicacion = _nombreAplicacion;
            InitializeComponent();
        }
        private void cargaImagen(string query)
        {
            Utilerias utilerias = new Utilerias();
            System.Data.SqlClient.SqlConnection cn = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.CadenaConexion);
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, cn);

            cn.Open();
            System.Data.SqlClient.SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {

                if (rd["imagen"] != DBNull.Value)
                {
                    Image img = utilerias.Bytes2Image((byte[])rd["imagen"]);
                    if (img != null)
                    {
                        this.pictureEdit_imgBoton.Image = img;
                    }
                }
            }
            cn.Close();


        }
    }
}