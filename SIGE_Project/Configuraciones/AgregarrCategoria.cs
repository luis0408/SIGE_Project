using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SIGE_Project.Configuraciones
{
    
    public partial class AgregarrCategoria : DevExpress.XtraEditors.XtraForm
    {
        string idGrupo, nombreGrupo;
        public AgregarrCategoria()
        {
            InitializeComponent();
        }

        private void AgregarrCategoria_Load(object sender, EventArgs e)
        {
            ///Si es difenre de nulo o vacio quiere decir que trae un valor y se va a editar
            ////Se cargan datos para editar
            if (!string.IsNullOrEmpty(idGrupo))
            {
                textEdit_idMenu.Text = idGrupo;
                textEdit_idMenu.ReadOnly = true;
                textEdit_decripcion.Text = nombreGrupo;
            }
        }

        private void simpleButton_aceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void simpleButton_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        public AgregarrCategoria(string _idGrupo, string _nombreGrupo)
        {
            InitializeComponent();
            idGrupo=_idGrupo;
            nombreGrupo=_nombreGrupo;
        }
    }
}