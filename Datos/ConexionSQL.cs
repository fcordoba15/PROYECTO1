using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class ConexionSQL
    {
        static string conexionstring = "server= LAPTOP-OC2ENCL7; database= Proyecto; integrated security= true";


        SqlConnection con = new SqlConnection(conexionstring);

        public int consultalogin(string usuario, string contrasena)
        {

            int count;
            con.Open();
            string query = "Select Count(*) from usuario where nombre_usuario= '"+usuario+"'" +
                "and contrasena = '"+contrasena+"'";

            SqlCommand cmd = new SqlCommand(query, con);
            count = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();
            return count;
        }
    }
}
