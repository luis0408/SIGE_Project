using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using DevExpress.DataAccess.ConnectionParameters;

namespace SIGE_Project
{
     class Utilerias
    {
        public SqlConnection con;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand comando;
        public DataTable dt;
        string cadena = "";

        //llamamos la cadena de conexion
        public void Conectar()
        {
            cadena = Properties.Settings.Default.CadenaConexion;
            con = new SqlConnection(cadena);
        }
        //constructor
        public Utilerias()
        {
            Conectar();
        }
        public static DataSet consultarProcedimiento(string procedimiento, object[] datos, string[] parametros)
        {
            string procedure;
            procedure = procedimiento;
            SqlDataAdapter sqladapter = new SqlDataAdapter();
            DataSet ds = new DataSet();

            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.CadenaConexion);
            SqlCommand cmd = new SqlCommand(procedure, cnn);

            cmd.CommandType = CommandType.StoredProcedure;
            for (int x = 0; x < parametros.Length; x++)
            {
                cmd.Parameters.AddWithValue(parametros[x], datos[x]);
            }
            try
            {
                cmd.CommandTimeout = 0;
                sqladapter.SelectCommand = cmd;

                cnn.Open();
                sqladapter.Fill(ds, procedure);


            }
            catch (Exception ex)
            { }
            finally
            {
                cnn.Close();
            }
            return ds;

        }
        public static int ejecutarprocedimiento(string procedimiento, object[] datos, string[] parametros)
        {

            int result;
            bool success = false;

            string sql = procedimiento;

            int Valor_Retornado = 0;
            string cadenaconexion = Properties.Settings.Default.CadenaConexion;
            SqlTransaction LaTransaccion = null;
            SqlConnection LaConexion = null;
            try
            {
                LaConexion = new SqlConnection();
                LaConexion.ConnectionString = cadenaconexion;

                LaConexion.Open();

                LaTransaccion = LaConexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                //especificamos el comando, en este caso el nombre del Procedimiento Almacenado
                SqlCommand comando = new SqlCommand(sql, LaConexion, LaTransaccion);
                //se indica al tipo de comando que es de tipo procedimiento almacenado
                comando.CommandType = CommandType.StoredProcedure;
                //se limpian los parámetros
                comando.Parameters.Clear();
                comando.CommandTimeout = 0;
                //comenzamos a mandar cada uno de los parámetros, deben de enviarse en el
                //tipo de datos que coincida en sql server por ejemplo c# es string en sql server es varchar()
                for (int x = 0; x < parametros.Length; x++)
                {
                    comando.Parameters.AddWithValue(parametros[x], datos[x]);
                }

                //declaramos el parámetro de retorno
                SqlParameter ValorRetorno = new SqlParameter("@Comprobacion", SqlDbType.Int);
                //asignamos el valor de retorno
                ValorRetorno.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ValorRetorno);
                //executamos la consulta
                comando.ExecuteNonQuery();
                // traemos el valor de retorno
                Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);
                //dependiendo del valor de retorno se asigna la variable success
                //si el procedimiento retorna un 1 la operación se realizó con éxito
                //de no ser así se mantiene en false y pr lo tanto falló la operación
                if (Valor_Retornado == 1)
                    success = true;
            }
            catch (Exception exc)
            {
                //al ocurrir un error mostramos un mensaje
                MessageBox.Show("Error en la operación consulte el log de operacion. Error:" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //si el procedimeinto se efectuó con éxito
                if (success)
                {
                    //se realiza la transacción
                    LaTransaccion.Commit();
                    //cerramos la conexión
                    LaConexion.Close();
                    //mensaje de operación satisfactoria
                    //MessageBox.Show("Formula guardada\nsatisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    result = 1;
                }
                //si se presentó algun error
                else
                {
                    //se deshace la transacción
                    LaTransaccion.Rollback();
                    //cerramos la conexión
                    LaConexion.Close();
                    result = 0;
                }
            }
            return result;
        }
        public static int ejecutarprocedimientoReturnIdentity(string procedimiento, object[] datos, string[] parametros)
        {

            int result;
            bool success = false;

            string sql = procedimiento;

            int Valor_Retornado = 0;
            string cadenaconexion = Properties.Settings.Default.CadenaConexion;
            SqlTransaction LaTransaccion = null;
            SqlConnection LaConexion = null;
            try
            {
                LaConexion = new SqlConnection();
                LaConexion.ConnectionString = cadenaconexion;

                LaConexion.Open();

                LaTransaccion = LaConexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                //especificamos el comando, en este caso el nombre del Procedimiento Almacenado
                SqlCommand comando = new SqlCommand(sql, LaConexion, LaTransaccion);
                //se indica al tipo de comando que es de tipo procedimiento almacenado
                comando.CommandType = CommandType.StoredProcedure;
                //se limpian los parámetros
                comando.Parameters.Clear();
                comando.CommandTimeout = 0;
                //comenzamos a mandar cada uno de los parámetros, deben de enviarse en el
                //tipo de datos que coincida en sql server por ejemplo c# es string en sql server es varchar()
                for (int x = 0; x < parametros.Length; x++)
                {
                    comando.Parameters.AddWithValue(parametros[x], datos[x]);
                }

                //declaramos el parámetro de retorno
                SqlParameter ValorRetorno = new SqlParameter("@Comprobacion", SqlDbType.Int);
                //asignamos el valor de retorno
                ValorRetorno.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ValorRetorno);
                //executamos la consulta
                comando.ExecuteNonQuery();
                // traemos el valor de retorno
                Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);
                //dependiendo del valor de retorno se asigna la variable success
                //si el procedimiento retorna un 1 la operación se realizó con éxito
                //de no ser así se mantiene en false y pr lo tanto falló la operación
                if (Valor_Retornado != 0)
                    success = true;
            }
            catch (Exception x)
            {
                //al ocurrir un error mostramos un mensaje
                MessageBox.Show("Error en la operación consulte el log de operacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //si el procedimeinto se efectuó con éxito
                if (success)
                {
                    //se realiza la transacción
                    LaTransaccion.Commit();
                    //cerramos la conexión
                    LaConexion.Close();
                    //mensaje de operación satisfactoria
                    //MessageBox.Show("Formula guardada\nsatisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    result = Valor_Retornado;
                }
                //si se presentó algun error
                else
                {
                    //se deshace la transacción
                    LaTransaccion.Rollback();
                    //cerramos la conexión
                    LaConexion.Close();
                    result = 0;
                }
            }
            return result;
        }
        public static MsSqlConnectionParameters GetConnectionParametersBase()
        {

            var sqlConnection = new SqlConnection(Properties.Settings.Default.CadenaConexion);
            var sqlConnectionStringBuilder = new SqlConnectionStringBuilder(sqlConnection.ConnectionString);
            var dataConnectionParametersBase = new MsSqlConnectionParameters
            {
                ServerName = sqlConnectionStringBuilder.DataSource,
                DatabaseName = sqlConnectionStringBuilder.InitialCatalog,
                UserName = sqlConnectionStringBuilder.UserID,
                Password = sqlConnectionStringBuilder.Password,
                AuthorizationType = sqlConnectionStringBuilder.IntegratedSecurity ?
                 MsSqlAuthorizationType.Windows : MsSqlAuthorizationType.SqlServer,

            };
            //  var sqlDataSource = new SqlDataSource(dataConnectionParametersBase);
            return dataConnectionParametersBase;
        }
        public void llamarform(Form formulario, Form mdi)
        {
            Form frmx = null;
            bool escargado = false;
            try
            {

                foreach (Form frm in mdi.MdiChildren)
                {
                    if (frm.GetType() == formulario.GetType()
                        && frm != formulario)
                    {
                        escargado = true;

                        frmx = frm;

                        //Sale del loop si es verdadero
                        break;
                        frm.Close();
                    }
                }


                if (!escargado)
                {
                    //Carga el formulario si no esta llamado
                    formulario.MdiParent = mdi;
                    formulario.Show();

                }
                else if (escargado)
                {
                    //Enfoca el objeto
                    formulario.WindowState = FormWindowState.Normal;
                    formulario.Select();
                    formulario.Focus();
                    formulario.BringToFront();

                    frmx.Select();
                    frmx.Focus();
                    frmx.BringToFront();

                }

                //Nada que hacer, toca colocar la exception
            }
            catch (Exception ex)
            {
                //Mostrar mensaje
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Limpiar todo
            formulario = null;
            //   frm = null;
        }
        public DataSet ejecutarQueryDataset(string vista, string sql)
        {
            con = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.CadenaConexion);
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql, con);
            System.Data.SqlClient.SqlDataAdapter objadapter = new System.Data.SqlClient.SqlDataAdapter();
            objadapter.SelectCommand = cmd;

            con.Open();
            DataSet objDS = new DataSet();

            objadapter.Fill(objDS, vista);
            con.Close();
            return objDS;
        }
        public int EjecutarQueryNonQuery(string query)
        {

            int resultado = 0;
            using (System.Data.SqlClient.SqlConnection conexionSQL = new System.Data.SqlClient.SqlConnection(cadena))
            {
                try
                {
                    conexionSQL.Open();
                    using (System.Data.SqlClient.SqlCommand comandoSQL = new System.Data.SqlClient.SqlCommand(query, conexionSQL))
                    {
                        int r = 0;
                        r = comandoSQL.ExecuteNonQuery();
                        resultado = r;
                    }
                    conexionSQL.Close();
                }
                catch (Exception ex)
                {
                    //object[] datos = { DateTime.Now, Variables.varUSER, "", "", GetLocalIPAddress(), Application.ProductVersion, ex.Message };
                    //string[] parametros = { "@FechaHoraSistema", "@Id_Usuario", "@Modulo", "@Metodo", "@Id_equipo", "@Version", "@Descripcion" };

                    //Util.consultarprocedimiento("usp_Error_LogGuardar", datos, parametros);

                    resultado = 0;

                }

            }
            return resultado;
        }
        public bool Consultar1(string tabla, string campo1, string campo2, string campo3, string campo4)
        {
            string sql = "SELECT * FROM " + tabla + " WHERE " + campo1 + "='" + campo2 + "'AND " + campo3 + "='" + campo4 + "' and statusUsuario=1";
            con.Open();
            da = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static DataTable llenarlookupeditvalue(string consulta)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);
                string consult = consulta;
                SqlCommand comando = new SqlCommand(consult, conexion);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }


        }
    }
}
