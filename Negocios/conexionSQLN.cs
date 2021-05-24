using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Negocios
{
    public class conexionSQLN
    {
        // ---------------------->CODIGO PARA CONECTAR A LA BASE DE DATOS 

        ConexionSQL cn = new ConexionSQL();
        public string conSQL_cliente(string usuario, string contrasena)
        {
            return cn.consultalogin_cliente(usuario, contrasena);
        }

        public string conSQL_entrenador(string usuario, string contrasena)
        {
            return cn.consultalogin_entrenador(usuario, contrasena);
        }

        public string conSQL_administrador(string usuario, string contrasena)
        {
            return cn.consultalogin_administrador(usuario, contrasena);
        }

        /*
         * ---------------------->CODIGO PARA REGISTRAR USUARIOS
         * 
         */
        public void Registrar_clienteUsuario(string usuario, string contrasena, string llave)
        {
            cn.Resgistar_cliente_usuario(usuario, contrasena, llave);
        }

        public void Registrar_cliente(string cedula, string nombre, string telefono, string correo, string sitio_web,
            string provincia, string canton, string distrito, string ubicacion, string usuario)
        {
            cn.Resgistar_Cliente(cedula,nombre,telefono, correo,sitio_web,provincia,canton,distrito,ubicacion,usuario);
        }

        public void Registrar_GMap(string id, string Ubicacion, string Latitud, string Longitud)
        { 
            cn.Resgistar_GMaps(id, Ubicacion, Latitud, Longitud);
        }

        public void Registrar_entrenadorUsuario(string usuario, string contrasena, string llave)
        {
            cn.Resgistar_entrenador_usuario(usuario, contrasena, llave);
        }

        public void Registrar_entrenador(string cedula, string nombre,string calificacion, string telefono, string correo, string sitio_web,
            string provincia, string canton, string distrito, string ubicacion, string usuario)
        {
            cn.Resgistar_Entrenador(cedula, nombre, calificacion, telefono, correo, sitio_web, provincia, canton, distrito, ubicacion, usuario);
        }


        public void Registrar_administradorUsuario(string usuario, string contrasena, string llave)
        {
            cn.Resgistar_administrador_usuario(usuario, contrasena, llave);
        }

            /*
             *---------------------->CODIGO PARA CONSULTAS TABLA INTERMEDIA_MOV_POK_ENTRENADOR
             * 
             */
            public DataTable ConsultaDT()
        {
            return cn.ConsultarMov();
        }
        public int InsertarMovimiento(string id_entrenador, int id_pokemon, string cod_movimiento)
        {
            return cn.InsertarMovimiento(id_entrenador, id_pokemon, cod_movimiento);
        }

        public int ModificarMovimiento(string id_entrenador, int id_pokemon, string cod_movimiento)
        {
            return cn.ModificarMovimiento(id_entrenador, id_pokemon, cod_movimiento);
        }
        public int EliminarMovimiento(string id_entrenador, int id_pokemon, string cod_movimiento)
        {
            return cn.EliminarMovimiento(id_entrenador, id_pokemon, cod_movimiento);
        }

        /*
         * 
         * ------------------------------->CONSULTAS ADMINISTRADOR GESTION POKEMONES
         * 
         */
        public DataTable ConsultaPokemonDT()
        {
            return cn.ConsultarPok();
        }
        public int InsertarPokemonAdministrador(string nombre_pokemon, string id_tipo, string cod_tipo, string total,
            string salud, string ataque, string defensa, string ataque_especial, string defensa_especial, string velocidad,
            string generacion, string legendario)
        {
            return cn.InsertarPokemonAdministrador(nombre_pokemon, id_tipo, cod_tipo, total, salud, ataque, defensa,
                ataque_especial, defensa_especial, velocidad, generacion, legendario);
        }

        public int ModificarPokemonAdministrador(int id, string nombre_pokemon, string id_tipo, string cod_tipo, string total,
            string salud, string ataque, string defensa, string ataque_especial, string defensa_especial, string velocidad,
            string generacion, string legendario)
        {
            return cn.ModificarPokemonAdministrador(id, nombre_pokemon, id_tipo, cod_tipo, total, salud, ataque, defensa,
                ataque_especial, defensa_especial, velocidad, generacion, legendario);
        }

        public int EliminarPokemonAdministrador(int id)
        {
            return cn.EliminarPokemonAdministrador(id);
        }
        /*
        * 
        * ------------------------------->CONSULTAS ADMINISTRADOR GESTION USUARIOS
        * 
        */

        public DataTable ConsultaUsuariosMADT()
        {
            return cn.ConsultarUsuariosAdmin();
        }

        public int InsertarUsuarioAdmin(string nombre_usuario_MA, string password_usuario_MA, string rol_usuario_MA)
        {
            return cn.InsertarUsuarioAdmin(nombre_usuario_MA, password_usuario_MA, rol_usuario_MA);
        }

        public int ModificarUsuarioAdmin(string nombre_usuario_MA, string password_usuario_MA, string rol_usuario_MA)
        {
            return cn.ModificarUsuarioAdmin(nombre_usuario_MA, password_usuario_MA, rol_usuario_MA);
        }

        public int EliminarUsuarioAdmin(string nombre_usuario_MA)
        {
            return cn.EliminarUsuarioAdmin(nombre_usuario_MA);
        }

        /*
        * 
        * ------------------------------->CONSULTAS ADMINISTRADOR GESTION MOVIMIENTOS
        * 
        */

        public DataTable ConsultaMovimientosAdmin()
        {
            return cn.ConsultarMovimientosAdmin();
        }

        public int InsertarMovimientoAdmin(string codigoMovimiento, string descripcionMovimiento, string nombreMovimiento,
            string tipoMovimiento)
        {
            return cn.InsertarMovimientoAdmin(codigoMovimiento, descripcionMovimiento, nombreMovimiento, tipoMovimiento);
        }

        public int ModificarMovimientoAdmin(string codigoMovimiento, string descripcionMovimiento, string nombreMovimiento,
           string tipoMovimiento)
        {
            return cn.ModificarMovimientoAdmin(codigoMovimiento,  descripcionMovimiento,  nombreMovimiento,
            tipoMovimiento);
        }

        public int EliminarMovimientoAdmin(string codigoMovimiento)
        {
            return cn.EliminarMovimientoAdmin(codigoMovimiento);
        }

        /*
        * 
        * 
        * ------------------------------->CONSULTAS ADMINISTRADOR GESTION ENTRENADORES
        * 
        * 
        */

        public DataTable ConsultaEntrenadoresAdmin()
        {
            return cn.ConsultarEntrenadorAdmi();
        }

        public int ModificarEntrenadorAdmin(string id_entrenador_MA, string nombre_entrenador_MA, int calificacion
           , int telefono, string correo_electronico, string sitio_web, string provincia, string canton, string distrito,
           string ubicacion)
        {
            return cn.ModificarEntrenadorAdmin(id_entrenador_MA, nombre_entrenador_MA, calificacion, telefono, correo_electronico,
                sitio_web, provincia, canton, distrito, ubicacion);
        }

        public int EliminarEntrenadorAdministrador(int id_entrenador_MA)
        {
            return cn.EliminarEntrenadorAdministrador(id_entrenador_MA);

        }



        /*
        * 
        * ---------------------->CONSULTAS POKEMON ENTRENADOR
        * 
        */
        public int InsertarBitacora(string fecha, string descripcion, int id_entrenador_bitacora)
        {
            return cn.InsertarBitacora(fecha, descripcion, id_entrenador_bitacora);
        }

        public DataTable ConsultaPokemonesEntrenador()
        {
            return cn.ConsultarPokemonesEntrenador();
        }

        public int InsertarPokemonEntrenador(string id_entrenador_pokemon, int id_pokemon_entrenador, string estado)
        {
            return cn.InsertarPokemonEntrenador(id_entrenador_pokemon, id_pokemon_entrenador, estado);
        }

        public int ModificarPokemonEntrenador(string id_entrenador_pokemon, int id_pokemon_entrenador, string estado)
        {
            return cn.ModificarPokemonEntrenador(id_entrenador_pokemon, id_pokemon_entrenador, estado);
        }

        public int EliminarPokemonEntrenador(string id_entrenador_pokemon, int id_pokemon_entrenador)
        {
            int i = Convert.ToInt32(id_pokemon_entrenador);
            return cn.EliminarPokemonEntrenador(id_entrenador_pokemon, i);
        }
    }






    


}
