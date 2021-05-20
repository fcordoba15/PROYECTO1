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
        /*
         * 
         * 
         * Consultas movimientos de tabla intermedia
         * 
         * 
         */
        public int InsertarMovimiento(string id_entrenador, int id_pokemon, string cod_movimiento)
        {
            int flag = 0;

            con.Open();
            string query = "INSERT INTO intermedia_PokemonMovimientoEntrenador VALUES ('"+id_entrenador+"', '"+id_pokemon+"'," +
                "'"+cod_movimiento+"')";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();

            return flag;
        } 

        public int ModificarMovimiento(string id_entrenador, int id_pokemon, string cod_movimiento)
        {
            int flag = 0;

            con.Open();
            string query = "UPDATE intermedia_PokemonMovimientoEntrenador SET id_entrenador = '" + id_entrenador + "', id_pokemon = '"
                + id_pokemon + "', cod_movimiento = '" + cod_movimiento + "' WHERE id_entrenador = '" + id_entrenador + "' and id_pokemon = '"+id_pokemon+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public int EliminarMovimiento(string id_entrenador, int id_pokemon, string cod_movimiento)
        {
            int flag = 0;

            con.Open();
            string query = "DELETE FROM intermedia_PokemonMovimientoEntrenador WHERE id_entrenador = '"+id_entrenador+"' and id_pokemon = '"+id_pokemon+"' and cod_movimiento = '"+cod_movimiento+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();

            return flag;
        }
        public DataTable ConsultarMov()
        {
            string query = "SELECT * FROM intermedia_PokemonMovimientoEntrenador";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }
        /*
         * 
         * 
         * Consultas pokemones modulo entrenador
         * 
         * 
         */
        public DataTable ConsultarPok()
        {
            string query = "SELECT * FROM pokemon";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }

    }
}
