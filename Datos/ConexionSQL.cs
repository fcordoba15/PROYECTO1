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
        static string conexionstring = "server= localhost\\SQLEXPRESS02; database= Proyecto; integrated security= true"; //Cambiar server segun SQL


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


        public void Resgistar_cliente_usuario(string usuario, string contrasena, string llave)
        {
            string cadena = "EXEC InsertUs_clave '" + usuario + "','" + contrasena + "','" + llave + "', 'Cliente'";

            con.Open();

            SqlCommand comando = new SqlCommand(cadena, con);

            comando.ExecuteNonQuery();
            con.Close();
        }

        public void Resgistar_Cliente(string cedula, string nombre, string telefono, string correo, string sitio_web,
            string provincia, string canton, string distrito, string ubicacion, string usuario)
        {
            string cadena = "INSERT INTO cliente VALUES('"+cedula+"', '"+nombre+"','"+telefono+"', '"+correo+"','"+sitio_web+"'," +
                "'"+provincia+"', '"+canton+"', '"+distrito+"', '"+ubicacion+"', '"+usuario+"')";

            con.Open();

            SqlCommand comando = new SqlCommand(cadena, con);

            comando.ExecuteNonQuery();
            con.Close();
        }

        /* public int AgregarMovimiento(string cod_movimiento, string descripcion, string nombre, string tipo)
         {

         } */

        public void Resgistar_GMaps(string id_client, string Ubicacion, string Latitud, string Longitud )
        {
            string cadena = "INSERT INTO Resgistar_GMaps values( '"+ id_client + "', '" + Ubicacion + "','" + Latitud + "',  '"+ Longitud +"')";

            con.Open();

            SqlCommand comando = new SqlCommand(cadena, con);

            comando.ExecuteNonQuery();
            con.Close();
        }

        public DataTable ConsultarMov()
        {
            string query = "SELECT * FROM intermedia_PokemonMovimientoEntrenador";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            con.Close();
            return tabla;


        }
    }
}
