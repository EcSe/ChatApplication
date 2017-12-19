using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace CapaLogica
{
    public class Empleado
    {
        static string cadena = ConfigurationManager.ConnectionStrings["Cadena"].
                                ConnectionString;

        static SqlConnection conexion = new SqlConnection(cadena);

        public string aPaterno { get; set; }
        public string aMaterno { get; set; }
        public string Nombres { get; set; }

        //aqui vamos a intentar arreglar lo que necesitamos 

    }
}
