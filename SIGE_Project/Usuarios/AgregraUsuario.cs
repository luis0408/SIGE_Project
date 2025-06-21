using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGE_Project.Usuarios
{
    public partial class AgregraUsuario : DevExpress.XtraEditors.XtraForm
    {
        bool esNuevo = true;
        bool editando = false;
        public AgregraUsuario()
        {
            InitializeComponent();
            consultarUsuarios();
        }

        object[] datos;
        string[] parametros;

        private void AgregraUsuario_Load(object sender, EventArgs e)
        {
            bloquearControles();
        }
        private void bloquearControles()
        {
            textEdit_nomUsuario.Enabled = false;
            textEdit_contrasenia.Enabled = false;
            simpleButton_visible.Enabled = false;
            textEdit_correoElectronico.Enabled = false;
            lookUpEdit_tipoUsuario.Enabled = false; 
            buttonEdit_curp.Enabled = false;
            simpleButton_guardar,.Enabled = false;  
            simpleButton_cancelar.Enabled = false;
        }
        private void activarControles()
        {
            textEdit_nomUsuario.Enabled = true;
            textEdit_contrasenia.Enabled = true;
            simpleButton_visible.Enabled = true;
            textEdit_correoElectronico.Enabled = true;
            lookUpEdit_tipoUsuario.Enabled = true;
            buttonEdit_curp.Enabled = true;
            simpleButton_guardar,.Enabled = true;
            simpleButton_cancelar.Enabled = true;
        }
        private void consultarUsuarios()
        {
            datos = new object[] { };
            parametros = new string[] { };  
            DataSet dsUsuarios= Utilerias.consultarProcedimiento("SIGE_CONSULTAR_USUARIOS", datos,parametros);
            gridControl_usuarios.DataSource = dsUsuarios.Tables[0];

        }
        private void guardarUsuario()
        {
            if (string.IsNullOrEmpty(textEdit_nomUsuario.Text))
            {
                XtraMessageBox.Show("Ingrese el nombre del usuario.", "Acción denegada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(textEdit_contrasenia.Text))
            {
                XtraMessageBox.Show("Ingrese la contraseña del usuario..", "Acción denegada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(textEdit_correoElectronico.Text))
            {
                XtraMessageBox.Show("Ingrese el nombre del usuario.", "Acción denegada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(buttonEdit_curp.Text))
            {
                XtraMessageBox.Show("Seleccione la CURP del usuario para obtener sus datos.", "Acción denegada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (usuarioExistente(textEdit_nomUsuario.Text,buttonEdit_curp.Text)==true)
            {
                XtraMessageBox.Show("El usuario o la CURP ingresadas ya han sido registradas.", "Acción denegada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            datos = new object[] { };
            parametros = new string[] { };
            int result = Utilerias.ejecutarprocedimiento("", datos, parametros);
            if (result != 0)
            {
                XtraMessageBox.Show("La información se guardó correctamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarCampos();
            }
            else
            {
                XtraMessageBox.Show("Se generó un error al ingresar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void limpiarCampos()
        {

        }


        }private void insertarUsuario()
        {

        }
        private void eliminarUsuario()
        {

        }
        private void actualizarUsuario()
        {

        }
        private bool usuarioExistente(string usuario,string curp)
        {
            try
            {
                datos = new object[] { };
                parametros = new string[] { };
                int result = Utilerias.ejecutarprocedimiento("", datos, parametros);
                if (result==1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch(Exception xc)
            {
                XtraMessageBox.Show("Ocurrio un error al validar el usuario ingresado. Detalles: "+xc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }

        }

        private void buttonEdit_curp_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (lookUpEdit_tipoUsuario.EditValue==null)
            {
                XtraMessageBox.Show("Seleccione un tipo de usuario para poder mostrar el listado de personal disponible.", "Acción denegada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void gridControl_usuarios_Click(object sender, EventArgs e)
        {
            ///SE CARGAN LOS DATOS
            if (editando==true)
            {
                XtraMessageBox.Show("Se esta editando un registro y aun no se guardan los cambios.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                textEdit_nomUsuario.Text= gridView_usuarios.GetRowCellValue(gridView_usuarios.FocusedRowHandle, "cuentaUsuario").ToString();
                textEdit_contrasenia.Text= gridView_usuarios.GetRowCellValue(gridView_usuarios.FocusedRowHandle, "contrasenia").ToString();
                textEdit_correoElectronico.Text= gridView_usuarios.GetRowCellValue(gridView_usuarios.FocusedRowHandle, "correoElectronico").ToString();
                lookUpEdit_tipoUsuario.EditValue= gridView_usuarios.GetRowCellValue(gridView_usuarios.FocusedRowHandle, "cveTipoUsuario").ToString();
                buttonEdit_curp.Text= gridView_usuarios.GetRowCellValue(gridView_usuarios.FocusedRowHandle, "CURP").ToString();
            }
            catch (Exception xc) 
            {
                XtraMessageBox.Show("Se generó un error al obtener los datos del usuario. Detalles: "+xc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void simpleButton_editar_Click(object sender, EventArgs e)
        {
            editando = true;
            activarControles();

            simpleButton_agrega.Enabled = false;
            simpleButton_eliminar.Enabled = false;
        }

        private void simpleButton_cancelar_Click(object sender, EventArgs e)
        {
            if (editando)
            {
                if (XtraMessageBox.Show("Aún no se guardan los cambios realizados, ¿desea salir sin guardar cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    limpiarCampos();
                    bloquearControles();
                    simpleButton_eliminar.Enabled= true;
                    simpleButton_agrega.Enabled= true;
                    simpleButton_editar.Enabled= true;
                }

            }
            else
            {
                if (XtraMessageBox.Show("Aún no se guarda el registro nuevo, ¿desea salir sin guardarlo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    limpiarCampos();
                    bloquearControles();
                    simpleButton_eliminar.Enabled = true;
                    simpleButton_agrega.Enabled = true;
                    simpleButton_editar.Enabled = true;
                }
            }    
            editando= false;    
        }
    }
}