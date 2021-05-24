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
        static string conexionstring = "server= SURFACEPROPEDRO\\SQLEXPRESS; database= BASEACTUALIZADA; integrated security= true"; //Cambiar server segun SQL
        //SURFACEPROPEDRO\\SQLEXPRESS

        SqlConnection con = new SqlConnection(conexionstring);

        /*
         * 
         * ------------------------- CODIGO LOGIN, REGISTRO USUARIO Y ENTRENADORES
         * 
         */
        public string consultalogin_cliente(string usuario, string contrasena)
        {
            String dato;
            con.Open();
            string query = "EXEC [LoginUsuario] '"+usuario+"', 'Cliente', '"+contrasena+"'";

            SqlCommand cmd = new SqlCommand(query, con);
            dato = Convert.ToString(cmd.ExecuteScalar());

            con.Close();
            return dato;
        }

        public string consultalogin_entrenador(string usuario, string contrasena)
        {

            String dato;
            con.Open();
            string query = "EXEC [LoginUsuario] '" + usuario + "', 'Entrenador', '" + contrasena + "'";

            SqlCommand cmd = new SqlCommand(query, con);
            dato = Convert.ToString(cmd.ExecuteScalar());

            con.Close();
            return dato;
        }

        public string consultalogin_administrador(string usuario, string contrasena)
        {

            string dato;
            con.Open();
            string query = "EXEC [LoginUsuario] '" + usuario + "', 'Administrador', '" + contrasena + "'";

            SqlCommand cmd = new SqlCommand(query, con);
            dato = Convert.ToString(cmd.ExecuteScalar());

            con.Close();
            return dato;
        }


        public void Resgistar_cliente_usuario(string usuario, string contrasena, string llave)
        {
            string cadena = "EXEC InsertUs_clave '" + usuario + "','" + contrasena + "','" + llave + "', 'Cliente'";

            con.Open();

            SqlCommand comando = new SqlCommand(cadena, con);

            comando.ExecuteNonQuery();
//<<<<<<< HEAD
            
//=======
            con.Close();
//>>>>>>> 8a233196ee952df0fc25b0845d6ae69061c2e5eb
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

        public void Resgistar_entrenador_usuario(string usuario, string contrasena, string llave)
        {
            string cadena = "EXEC InsertUs_clave '" + usuario + "','" + contrasena + "','" + llave + "', 'Entrenador'";

            con.Open();

            SqlCommand comando = new SqlCommand(cadena, con);

            comando.ExecuteNonQuery();

            con.Close();
        }

        public void Resgistar_Entrenador(string cedula, string nombre, string calificacion, string telefono, string correo, 
            string sitio_web, string provincia, string canton, string distrito, string ubicacion, string usuario)
        {
            string cadena = "INSERT INTO entrenador VALUES('" + cedula + "', '" + nombre + "','"+calificacion+"','" + telefono + "', '" + correo + "','" + sitio_web + "'," +
                "'" + provincia + "', '" + canton + "', '" + distrito + "', '" + ubicacion + "', '" + usuario + "')";

            con.Open();

            SqlCommand comando = new SqlCommand(cadena, con);

            comando.ExecuteNonQuery();
            con.Close();
        }


        public void Resgistar_administrador_usuario(string usuario, string contrasena, string llave)
        {
            string cadena = "EXEC InsertUs_clave '" + usuario + "','" + contrasena + "','" + llave + "', 'Administrador'";

            con.Open();

            SqlCommand comando = new SqlCommand(cadena, con);

            comando.ExecuteNonQuery();

            con.Close();
        }



        /*
         * 
         * ---------------------------------------CODIGO PARA REGISTRO GMAPS
         * 
         */
        public void Resgistar_GMaps(string id_client, string Ubicacion, string Latitud, string Longitud )
        {
            string cadena = "INSERT INTO Resgistar_GMaps values( '"+ id_client + "', '" + Ubicacion + "','" + Latitud + "',  '"+ Longitud +"')";

            con.Open();

            SqlCommand comando = new SqlCommand(cadena, con);

            comando.ExecuteNonQuery();
            con.Close();
        }

        /* 
         * 
         * 
         * ------------------------CODIGO CONSULTAS TABLA INTERMEDIA_MOV_POK_ENTRENADOR
         * 
         * 
         */
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
       
        public int InsertarMovimiento(string id_entrenador, int id_pokemon, string cod_movimiento)
        {
            int flag = 0;

            con.Open();
            string query = "INSERT INTO intermedia_PokemonMovimientoEntrenador VALUES ('" + id_entrenador + "', '" + id_pokemon + "'," +
                "'" + cod_movimiento + "')";
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
                + id_pokemon + "', cod_movimiento = '" + cod_movimiento + "' WHERE id_entrenador = '" + id_entrenador + "' and id_pokemon = '" + id_pokemon + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();

            return flag;
        }

        public int EliminarMovimiento(string id_entrenador, int id_pokemon, string cod_movimiento)
        {
            int flag = 0;

            con.Open();
            string query = "DELETE FROM intermedia_PokemonMovimientoEntrenador WHERE id_entrenador = '" + id_entrenador + "' and id_pokemon = '" + id_pokemon + "' and cod_movimiento = '" + cod_movimiento + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();

            return flag;
        }

        /*
        * 
        * 
        * -------------------------CONSULTAS POKEMONES MODULO ADMINISTRADOR
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

        public int InsertarPokemonAdministrador(string nombre_pokemon, string id_tipo, string cod_tipo, string total,
            string salud, string ataque, string defensa, string ataque_especial, string defensa_especial, string velocidad,
            string generacion, string legendario)
        {
            int flag = 0;

            con.Open();
            string query = "INSERT INTO pokemon(nombre, id_tipo, cod_tipo, total, salud, ataque, defensa, ataque_especial, defensa_especial," +
                "velocidad, generacion, legendario)" +
                " VALUES ('"+ nombre_pokemon + "','"+id_tipo+"','"+cod_tipo+"','"+total+"'," +
                "'"+salud+"','"+ataque+"','"+defensa+"'," +
                "'"+ataque_especial+"','"+defensa_especial+"','"+velocidad+"','"+generacion+"','"+legendario+"')";
            SqlCommand cmd = new SqlCommand(query, con);
            //cmd.Parameters.AddWithValue("cod_tipo",Convert.ToInt32(cod_tipo));
            flag = cmd.ExecuteNonQuery();
            con.Close();

            return flag;
        }

        public int ModificarPokemonAdministrador(int id, string nombre_pokemon, string id_tipo, string cod_tipo, string total,
            string salud, string ataque, string defensa, string ataque_especial, string defensa_especial, string velocidad,
            string generacion, string legendario)
        {
            int flag = 0;

            con.Open();
            string query = "UPDATE pokemon SET nombre = '"
                + nombre_pokemon + "', id_tipo = '" + id_tipo + "', cod_tipo = '"+cod_tipo+"',total = '"+total+"', salud = '"+salud+"'" +
                ", ataque = '"+ataque+"', defensa = '"+defensa+"', ataque_especial = '"+ataque_especial+"'" +
                ", defensa_especial = '"+defensa_especial+"', velocidad = '"+velocidad+"'" +
                ", generacion = '"+generacion+"', legendario = '"+legendario+"' WHERE id = '"+id+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();

            return flag;
        }

        public DataTable ConsultarPokEliminar()
        {
            string query = "SELECT * FROM pokemon";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }

        public int EliminarPokemonAdministrador(int id)
        {
            int flag = 0;

            con.Open();
            string query = "DELETE FROM pokemon WHERE id = '"+id+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();

            return flag;

        }

        /*
       * 
       * 
       * -------------------------CONSULTAS ENTRENADORES MODULO ADMINISTRADOR
       * 
       * 
       */
        public DataTable ConsultarEntrenadorAdmi()
        {
            string query = "SELECT * FROM entrenador";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }

        public int ModificarEntrenadorAdmin(string id_entrenador_MA, string nombre_entrenador_MA, int calificacion
            , int telefono, string correo_electronico, string sitio_web, string provincia, string canton, string distrito, 
            string ubicacion)
        {
            int flag = 0;

            con.Open();
            string query = "UPDATE entrenador SET nombre_entrenador = '"
                + nombre_entrenador_MA + "', calificacion = '" + calificacion + "', telefono_entrenador = '" + telefono + "',correo_electrónico = '" + correo_electronico + "', " +
                "sitio_web = '" + sitio_web + "'" +
                ", provincia = '" + provincia + "', cantón = '" + canton + "', distrito = '" + distrito + "'" +
                ", ubicación = '" + ubicacion + "' WHERE id_entrenador = '" + id_entrenador_MA + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();

            return flag;
        }

        public int EliminarEntrenadorAdministrador(int id_entrenador_MA)
        {
            int flag = 0;

            con.Open();
            string query = "DELETE FROM entrenador WHERE id_entrenador = '" + id_entrenador_MA + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();

            return flag;

        }



        /*
         * 
         * ----------------------------CODIGO BITACORA ENTRENADOR
         * 
         */
        public int InsertarBitacora(string fecha, string descripcion, int id_entrenador_bitacora)
        {
            int flag = 0;

            con.Open();
            string query = "INSERT INTO bitacora VALUES ('" + fecha + "', '" + descripcion + "'," +
                "'" + id_entrenador_bitacora + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();

            return flag;
        }
        /*
         * 
         * 
         * ------------------------------CODIGO GESTION POKEMONES ENTRENADOR
         * 
         * 
         */

        public DataTable ConsultarPokemonesEntrenador()
        {
            string query = "SELECT * FROM intermedia_EntrenadorPokemon";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }
        public int InsertarPokemonEntrenador(string id_entrenador_pokemon, int id_pokemon_entrenador, string estado)
        {
            int flag = 0;

            con.Open();
            string query = "INSERT INTO intermedia_EntrenadorPokemon VALUES ('" + id_entrenador_pokemon + "', " +
                "'" + id_pokemon_entrenador + "','"+estado+"')";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();

            return flag;
        }

        public int ModificarPokemonEntrenador(string id_entrenador_pokemon, int id_pokemon_entrenador, string estado)
        {
            int flag = 0;

            con.Open();
            string query = "UPDATE intermedia_EntrenadorPokemon SET id_entrenador = '" + id_entrenador_pokemon + "'," +
                " id_pokemon = '" + id_pokemon_entrenador + "', estado = '" + estado + "'" +
                " WHERE id_entrenador = '" + id_entrenador_pokemon + "' and id_pokemon = '" + id_pokemon_entrenador + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();

            return flag;
        }

        public int EliminarPokemonEntrenador(string id_entrenador_pokemon, int id_pokemon_entrenador)
        {
            int flag = 0;

            con.Open();
            string query = "DELETE FROM intermedia_EntrenadorPokemon WHERE id_entrenador = '" + id_entrenador_pokemon+ "'" +
                " and id_pokemon = '"+ id_pokemon_entrenador + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();

            return flag;
        }
        /*
         * 
         * 
         * ------------------------------CODIGO ADMINISTRADOR GESTION USUARIOS
         * 
         * 
         */

        //MA = MODULO ADMINISTRADOR

        public DataTable ConsultarUsuariosAdmin()
        {
            string query = "SELECT * FROM usuario";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }

        public int InsertarUsuarioAdmin(string nombre_usuario_MA, string password_usuario_MA, string rol_usuario_MA)
        {
            int flag = 0;

            con.Open();
            string query = "INSERT INTO usuario VALUES ('" + nombre_usuario_MA + "', " +
                "'" + password_usuario_MA + "','" + rol_usuario_MA + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();

            return flag;
        }

        public int ModificarUsuarioAdmin(string nombre_usuario_MA, string password_usuario_MA, string rol_usuario_MA)
        {
            int flag = 0;

            con.Open();
            string query = "UPDATE usuario SET nombre_usuario = '" + nombre_usuario_MA + "'," +
                " contraseña = '" + password_usuario_MA + "', rol = '" + rol_usuario_MA + "'" +
                " WHERE nombre_usuario = '" + nombre_usuario_MA + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();

            return flag;
        }

        public int EliminarUsuarioAdmin(string nombre_usuario_MA)
        {
            int flag = 0;

            con.Open();
            string query = "DELETE FROM usuario WHERE nombre_usuario = '" + nombre_usuario_MA + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();

            return flag;
        }

        /*
        * 
        * 
        * ------------------------------CODIGO ADMINISTRADOR GESTION MOVIMIENTOS
        * 
        * 
        */

        public DataTable ConsultarMovimientosAdmin()
        {
            string query = "SELECT * FROM movimiento";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
        
            data.Fill(tabla);

            return tabla;


        }
        public int InsertarMovimientoAdmin(string codigoMovimiento, string descripcionMovimiento, string nombreMovimiento, 
            string tipoMovimiento)
        {
            int flag = 0;

            con.Open();
            string query = "INSERT INTO movimiento VALUES('"+codigoMovimiento+"', '"+descripcionMovimiento+"'," +
                " '"+nombreMovimiento+"', '"+tipoMovimiento+"') ";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();

            return flag;
        }

        public int ModificarMovimientoAdmin(string codigoMovimiento, string descripcionMovimiento, string nombreMovimiento,
            string tipoMovimiento)
        {
            int flag = 0;

            con.Open();
            string query = "UDPATE movimiento SET descripcion = '"+descripcionMovimiento+"', nombre = '"+nombreMovimiento+"', " +
                " tipo = '' WHERE cod_movimiento = '"+codigoMovimiento+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();

            return flag;
        }

        public int EliminarMovimientoAdmin(string codigoMovimiento)
        {
            int flag = 0;

            con.Open();
            string query = "DELETE FROM movimiento WHERE cod_movimiento = '"+codigoMovimiento+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();

            return flag;
        }

    }

}
