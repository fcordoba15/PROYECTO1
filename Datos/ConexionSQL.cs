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
        static string conexionstring = "server= SURFACEPROPEDRO\\SQLEXPRESS; database= Proyecto; integrated security= true"; //Cambiar server segun SQL


        SqlConnection con = new SqlConnection(conexionstring);

        public int consultalogin(string usuario, string contrasena)
        {

            int count;
            con.Open();
            string query = "Select Count(*) from usuario where nombre_usuario= '"+usuario+"'" +
                "and contraseña = '"+contrasena+"'";

            SqlCommand cmd = new SqlCommand(query, con);
            count = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();
            return count;
        }

       /* public int AgregarMovimiento(string cod_movimiento, string descripcion, string nombre, string tipo)
        {

        } */
        public DataTable ConsultarMov()
        {
            string query = "SELECT * FROM intermedia_PokemonMovimientoEntrenador";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }
    }
}
