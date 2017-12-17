using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;

namespace CapaLogica
{
   public  class Usuario
    {
        static string cadena = ConfigurationManager.ConnectionStrings["Cadena"].
                                 ConnectionString;

        static SqlConnection conexion = new SqlConnection(cadena);

        public string userName { get; set; }
        public string contrasena { get; set; }
        public Empleado empleado { get; set; }
        private string mensaje;
        public string Mensaje { get {return mensaje;} }

        public bool validarUsuario()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spLoginUser", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserName", userName);
                cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                conexion.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                DataRow fila = tabla.Rows[0];

                byte i = Convert.ToByte(fila["CodError"]);
                mensaje = fila["Mensaje"].ToString();
                if (i == 1) return true;
                else return false;
            }
            catch (Exception ex)
            {
                mensaje = "Error: " + ex.Message;
                return false;
            }
            finally
            {
                conexion.Close();
            }
        
        }
    }
}
