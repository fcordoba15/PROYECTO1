using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;

namespace Datos
{
    public class ConexionSQL
    {
        static string conexionstring = "server= localhost\\SQLEXPRESS02; database= Proyecto; integrated security= true"; //Cambiar server segun SQL
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
            try
            {
               
                con.Open();
                string query = "EXEC [LoginUsuario] '" + usuario + "', 'Cliente', '" + contrasena + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                dato = Convert.ToString(cmd.ExecuteScalar());

                con.Close();
                return dato;
            }
            catch ( SqlException ex)
            {
                dato = "Error";
                Console.WriteLine("Error: " + ex.Message);
                return dato;

            }
        }

        public string consultalogin_entrenador(string usuario, string contrasena)
        {
            string dato;
            try
            {
                con.Open();
               
                string query = "EXEC [LoginUsuario] '" + usuario + "', 'Entrenador', '" + contrasena + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                dato = Convert.ToString(cmd.ExecuteScalar());

                con.Close();
                return dato;
                
            }
            catch (SqlException ex)
            {
                string dat;
                dat = "Error";
                Console.WriteLine("Error: " + ex.Message);
                return dat;

            }
        }

        public string consultalogin_administrador(string usuario, string contrasena)
        {

            try
            {
                string dato;
                con.Open();
                string query = "EXEC [LoginUsuario] '" + usuario + "', 'Administrador', '" + contrasena + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                dato = Convert.ToString(cmd.ExecuteScalar());

                con.Close();
                return dato;
            }
            catch (SqlException ex)
            {
                string dat;
                dat = "Error";
                Console.WriteLine("Error: " + ex.Message);
                return dat;
            }
        }


        public void Resgistar_cliente_usuario(string usuario, string contrasena, string llave)
        {
            try
            {
                string cadena = "EXEC InsertUs_clave '" + usuario + "','" + contrasena + "','" + llave + "', 'Cliente'";

                con.Open();

                SqlCommand comando = new SqlCommand(cadena, con);

                comando.ExecuteNonQuery();

                con.Close();
                
            }
            catch (SqlException ex)
            {
               
                Console.WriteLine("Error: " + ex.Message);
                
            }
        }

        public void Resgistar_Cliente(string cedula, string nombre, string telefono, string correo, string sitio_web,
            string provincia, string canton, string distrito, string usuario)
        {
            try
            {
                string cadena = "INSERT INTO cliente VALUES('" + cedula + "', '" + nombre + "','" + telefono + "', '" + correo + "','" + sitio_web + "'," +
                        "'" + provincia + "', '" + canton + "', '" + distrito + "', 'NULL', '" + usuario + "')";

                con.Open();

                SqlCommand comando = new SqlCommand(cadena, con);

                comando.ExecuteNonQuery();
                con.Close();
                
            }
            catch (SqlException ex)
            {
                
                Console.WriteLine("Error: " + ex.Message);
                

            }
        }

        public void Resgistar_entrenador_usuario(string usuario, string contrasena, string llave)
        {
            try
            {
                string cadena = "EXEC InsertUs_clave '" + usuario + "','" + contrasena + "','" + llave + "', 'Entrenador'";

                con.Open();

                SqlCommand comando = new SqlCommand(cadena, con);

                comando.ExecuteNonQuery();

                con.Close();
                
            }
            catch (SqlException ex)
            {

                
                Console.WriteLine("Error: " + ex.Message);
                
            }
        }

        public void Resgistar_Entrenador(string cedula, string nombre, string calificacion, string telefono, string correo, 
            string sitio_web, string provincia, string canton, string distrito, string usuario)
        {
            try
            {
                string cadena = "INSERT INTO entrenador VALUES('" + cedula + "', '" + nombre + "','" + calificacion + "','" + telefono + "', '" + correo + "','" + sitio_web + "'," +
                       "'" + provincia + "', '" + canton + "', '" + distrito + "', 'NULL', '" + usuario + "')";

                con.Open();

                SqlCommand comando = new SqlCommand(cadena, con);

                comando.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Error: " + ex.Message);
            }
        }


        public void Resgistar_administrador_usuario(string usuario, string contrasena, string llave)
        {
            try
            {
                string cadena = "EXEC InsertUs_clave '" + usuario + "','" + contrasena + "','" + llave + "', 'Administrador'";

                con.Open();

                SqlCommand comando = new SqlCommand(cadena, con);

                comando.ExecuteNonQuery();

                con.Close();
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Error: " + ex.Message);
            }
        }



        /*
         * 
         * ---------------------------------------CODIGO PARA REGISTRO GMAPS
         * 
         */
        public void Resgistar_GMaps(string id_client, string Ubicacion, string Latitud, string Longitud )
        {
            try
            {
                string cadena = "INSERT INTO Registrar_GMaps values( '" + id_client + "', '" + Ubicacion + "','" + Latitud + "',  '" + Longitud + "')";

                con.Open();

                SqlCommand comando = new SqlCommand(cadena, con);

                comando.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Error: " + ex.Message);
            }
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
            try
            {
                

                con.Open();
                string query = "INSERT INTO intermedia_PokemonMovimientoEntrenador VALUES ('" + id_entrenador + "', '" + id_pokemon + "'," +
                    "'" + cod_movimiento + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                flag = cmd.ExecuteNonQuery();
                con.Close();

                return flag;
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Error: " + ex.Message);
                flag = 1;
                return flag;
            }
        }

        public int ModificarMovimiento(string id_entrenador, int id_pokemon, string cod_movimiento)
        {
            int flag = 0;
            try
            {
                

                con.Open();
                string query = "UPDATE intermedia_PokemonMovimientoEntrenador SET id_entrenador = '" + id_entrenador + "', id_pokemon = '"
                    + id_pokemon + "', cod_movimiento = '" + cod_movimiento + "' WHERE id_entrenador = '" + id_entrenador + "' and id_pokemon = '" + id_pokemon + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                flag = cmd.ExecuteNonQuery();
                con.Close();
                return flag;
                
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Error: " + ex.Message);
                flag = 1;
                return flag;
            }
        }

        public int EliminarMovimiento(string id_entrenador, int id_pokemon, string cod_movimiento)
        {
            int flag = 0;
            try
            {
                

                con.Open();
                string query = "DELETE FROM intermedia_PokemonMovimientoEntrenador WHERE id_entrenador = '" + id_entrenador + "' and id_pokemon = '" + id_pokemon + "' and cod_movimiento = '" + cod_movimiento + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                flag = cmd.ExecuteNonQuery();
                con.Close();

                return flag;
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Error: " + ex.Message);
                flag = 1;
                return flag;
            }
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
            string generacion, string legendario, byte[] foto)
        {
            int flag = 0;
            try
            {
                

                con.Open();
                string query = "INSERT INTO pokemon(nombre, id_tipo, cod_tipo, total, salud, ataque, defensa, ataque_especial, defensa_especial," +
                    "velocidad, generacion, legendario,foto)" +
                    " VALUES ('" + nombre_pokemon + "','" + id_tipo + "','" + cod_tipo + "','" + total + "'," +
                    "'" + salud + "','" + ataque + "','" + defensa + "'," +
                    "'" + ataque_especial + "','" + defensa_especial + "','" + velocidad + "','" + generacion + "','" + legendario + "','" + foto + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                //cmd.Parameters.AddWithValue("cod_tipo",Convert.ToInt32(cod_tipo));
                flag = cmd.ExecuteNonQuery();
                con.Close();

                return flag;
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Error: " + ex.Message);
                flag = 1;
                return flag;
            }
        }

        public int ModificarPokemonAdministrador(int id, string nombre_pokemon, string id_tipo, string cod_tipo, string total,
            string salud, string ataque, string defensa, string ataque_especial, string defensa_especial, string velocidad,
            string generacion, string legendario, byte[] foto)
        {
            int flag = 0;
            try
            {
                

                con.Open();
                string query = "UPDATE pokemon SET nombre = '"
                    + nombre_pokemon + "', id_tipo = '" + id_tipo + "', cod_tipo = '" + cod_tipo + "',total = '" + total + "', salud = '" + salud + "'" +
                    ", ataque = '" + ataque + "', defensa = '" + defensa + "', ataque_especial = '" + ataque_especial + "'" +
                    ", defensa_especial = '" + defensa_especial + "', velocidad = '" + velocidad + "'" +
                    ", generacion = '" + generacion + "', legendario = '" + legendario + "', foto = '" + foto + "'  WHERE id = '" + id + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                flag = cmd.ExecuteNonQuery();
                con.Close();

                return flag;
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Error: " + ex.Message);
                 flag = 1;
                return flag;
            }
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
            try
            {
                

                con.Open();
                string query = "DELETE FROM pokemon WHERE id = '" + id + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                flag = cmd.ExecuteNonQuery();
                con.Close();

                return flag;
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Error: " + ex.Message);
                 flag = 1;
                return flag;
            }

        }

        public DataRow Imagen_Mostrar(int id)
        {
            
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT foto FROM pokemon where id = " + id, con);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ad.Fill(ds, "img");

                byte[] datos = new byte[0];
                DataRow dr = ds.Tables["img"].Rows[0];
                con.Close();

                return dr;
            
            

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
            try
            {
                

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
            catch (SqlException ex)
            {

                Console.WriteLine("Error: " + ex.Message);
                flag = 1;
                return flag;
            }
        }

        public int EliminarEntrenadorAdministrador(int id_entrenador_MA)
        {
            int flag = 0;
            try
            {


                con.Open();
                string query = "DELETE FROM entrenador WHERE id_entrenador = '" + id_entrenador_MA + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                flag = cmd.ExecuteNonQuery();
                con.Close();

                return flag;
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Error: " + ex.Message);
                flag = 1;
                return flag;
            }

        }



        /*
         * 
         * ----------------------------CODIGO BITACORA ENTRENADOR
         * 
         */
        public int InsertarBitacora(string fecha, string descripcion, int id_entrenador_bitacora)
        {
            int flag = 0;
            try
            {
                

                con.Open();
                string query = "INSERT INTO bitacora VALUES ('" + fecha + "', '" + descripcion + "'," +
                    "'" + id_entrenador_bitacora + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                flag = cmd.ExecuteNonQuery();
                con.Close();

                return flag;
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Error: " + ex.Message);
                flag = 1;
                return flag;
            }
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
            try
            {


                con.Open();
                string query = "INSERT INTO intermedia_EntrenadorPokemon VALUES ('" + id_entrenador_pokemon + "', " +
                    "'" + id_pokemon_entrenador + "','" + estado + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                flag = cmd.ExecuteNonQuery();
                con.Close();

                return flag;
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Error: " + ex.Message);
                flag = 1;
                return flag;
            }
        }

        public int ModificarPokemonEntrenador(string id_entrenador_pokemon, int id_pokemon_entrenador, string estado)
        {
            int flag = 0;
            try
            {


                con.Open();
                string query = "UPDATE intermedia_EntrenadorPokemon SET id_entrenador = '" + id_entrenador_pokemon + "'," +
                    " id_pokemon = '" + id_pokemon_entrenador + "', estado = '" + estado + "'" +
                    " WHERE id_entrenador = '" + id_entrenador_pokemon + "' and id_pokemon = '" + id_pokemon_entrenador + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                flag = cmd.ExecuteNonQuery();
                con.Close();

                return flag;
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Error: " + ex.Message);
                flag = 1;
                return flag;
            }
        }

        public int EliminarPokemonEntrenador(string id_entrenador_pokemon, int id_pokemon_entrenador)
        {
            int flag = 0;
            try
            {
                

                con.Open();
                string query = "DELETE FROM intermedia_EntrenadorPokemon WHERE id_entrenador = '" + id_entrenador_pokemon + "'" +
                    " and id_pokemon = '" + id_pokemon_entrenador + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                flag = cmd.ExecuteNonQuery();
                con.Close();

                return flag;
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Error: " + ex.Message);
                flag = 1;
                return flag;
            }
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
            try
            {
                

                con.Open();
                string query = "INSERT INTO usuario VALUES ('" + nombre_usuario_MA + "', " +
                    "'" + password_usuario_MA + "','" + rol_usuario_MA + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                flag = cmd.ExecuteNonQuery();
                con.Close();

                return flag;
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Error: " + ex.Message);
                flag = 1;
                return flag;
            }
        }

        public int ModificarUsuarioAdmin(string nombre_usuario_MA, string password_usuario_MA, string rol_usuario_MA)
        {
            int flag = 0;
            try
            {
                

                con.Open();
                string query = "UPDATE usuario SET nombre_usuario = '" + nombre_usuario_MA + "'," +
                    " contraseña = '" + password_usuario_MA + "', rol = '" + rol_usuario_MA + "'" +
                    " WHERE nombre_usuario = '" + nombre_usuario_MA + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                flag = cmd.ExecuteNonQuery();
                con.Close();

                return flag;
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Error: " + ex.Message);
                flag = 1;
                return flag;
            }
        }

        public int EliminarUsuarioAdmin(string nombre_usuario_MA)
        {
            int flag = 0;
            try
            {


                con.Open();
                string query = "DELETE FROM usuario WHERE nombre_usuario = '" + nombre_usuario_MA + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                flag = cmd.ExecuteNonQuery();
                con.Close();

                return flag;
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Error: " + ex.Message);
                flag = 1;
                return flag;
            }
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
            try
            {
                

                con.Open();
                string query = "INSERT INTO movimiento VALUES('" + codigoMovimiento + "', '" + descripcionMovimiento + "'," +
                    " '" + nombreMovimiento + "', '" + tipoMovimiento + "') ";
                SqlCommand cmd = new SqlCommand(query, con);
                flag = cmd.ExecuteNonQuery();
                con.Close();

                return flag;
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Error: " + ex.Message);
                flag = 1;
                return flag;
            }
        }

        public int ModificarMovimientoAdmin(string codigoMovimiento, string descripcionMovimiento, string nombreMovimiento,
            string tipoMovimiento)
        {
            int flag = 0;
            try
            {


                con.Open();
                string query = "UDPATE movimiento SET descripcion = '" + descripcionMovimiento + "', nombre = '" + nombreMovimiento + "', " +
                    " tipo = '' WHERE cod_movimiento = '" + codigoMovimiento + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                flag = cmd.ExecuteNonQuery();
                con.Close();

                return flag;
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Error: " + ex.Message);
                flag = 1;
                return flag;

            }
        }

        public int EliminarMovimientoAdmin(string codigoMovimiento)
        {
            int flag = 0;
            try
            {
                

                con.Open();
                string query = "DELETE FROM movimiento WHERE cod_movimiento = '" + codigoMovimiento + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                flag = cmd.ExecuteNonQuery();
                con.Close();

                return flag;
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Error: " + ex.Message);
                flag = 1;
                return flag;
            }
        }


        /*
        * 
        * 
        * ------------------------------CODIGO ADMINISTRADOR GESTION MOVIMIENTOS
        * 
        * 
        */

        public DataTable Cliente_Pokemon(string categoria, string tipo)
        {
            string query;
            if (tipo == "Todos" && categoria == "Todas")
            {
                query = "SELECT id,nombre,total FROM pokemon;";
            }
            else if (tipo != "Todos" && categoria == "Todas")
            {
                query = "SELECT id,nombre,total FROM pokemon where id_tipo= '" + tipo + "';";
            }
            else if (tipo == "Todos" && categoria != "Todas")
            {
                query = "SELECT id,nombre,total FROM pokemon where cod_tipo= '" + categoria + "';";
            }
            else
            {
                query = "SELECT id,nombre,total FROM pokemon where id_tipo= '" + tipo + "' and cod_tipo= '" + categoria + "';";
            }

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }


        public DataTable Cliente_Movimiento(string tipo)
        {
            string query;
            if (tipo == "Todos")
            {
                query = "SELECT nombre,tipo,descripcion FROM movimiento;";
            }
            else
            {
                query = "SELECT nombre,tipo,descripcion FROM movimiento where tipo= '" + tipo + "';";
            }
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }



        public DataTable Cliente_Entrenador(string ubicacion,string nombre)
        {
            string query;
            if (ubicacion == "Todas" && nombre == "Todos")
            {
                query = "SELECT id_entrenador,nombre_entrenador,ubicacion FROM entrenador;";
            }
            else if (ubicacion == "Todas" && nombre != "Todos")
            {
                query = "SELECT id_entrenador,nombre_entrenador,ubicacion FROM entrenador where nombre_entrenador= '"+nombre+"';";
            }
            else if (ubicacion!= "Todas" && nombre == "Todos")
            {
                query = "SELECT id_entrenador,nombre_entrenador,ubicacion FROM entrenador where ubicacion='" + ubicacion+"';";
            }
            else
            {
                query = "SELECT id_entrenador,nombre_entrenador,ubicacion FROM entrenador where ubicacion = '"+ubicacion+"' and nombre_entrenador= '"+nombre+"';";
            }

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }


    }

}



