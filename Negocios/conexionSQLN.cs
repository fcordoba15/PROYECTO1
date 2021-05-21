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
        // CODIGO PARA CONECTAR A LA BASE DE DATOS 

        ConexionSQL cn = new ConexionSQL();
        public int conSQL(string usuario, string contrasena)
        {
            return cn.consultalogin(usuario, contrasena);
        }

        /*
         * CODIGO PARA REGISTRAR USUARIOS
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
        /*
         * CODIGO PARA CONSULTAS TABLA INTERMEDIA_MOV_POK_ENTRENADOR
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
         * CONSULTAS POKEMON ENTRENADOR
         * 
         */
        public DataTable ConsultaPokemonDT()
        {
            return cn.ConsultarPok();
        }
        public int InsertarPokemonEntrenador(string nombre_pokemon, string id_tipo, string cod_tipo, string total,
            string salud, string ataque, string defensa, string ataque_especial, string defensa_especial, string velocidad,
            string generacion, string legendario)
        {
            return cn.InsertarPokemonEntrenador(nombre_pokemon, id_tipo, cod_tipo, total, salud, ataque, defensa,
                ataque_especial, defensa_especial, velocidad, generacion, legendario);
        }

        public int ModificarPokemonEntrenador(int id, string nombre_pokemon, string id_tipo, string cod_tipo, string total,
            string salud, string ataque, string defensa, string ataque_especial, string defensa_especial, string velocidad,
            string generacion, string legendario)
        {
            return cn.ModificarPokemonEntrenador(id, nombre_pokemon, id_tipo, cod_tipo, total, salud, ataque, defensa,
                ataque_especial, defensa_especial, velocidad, generacion, legendario);
        }

        public int EliminarPokemonEntrenador(int id)
        {
            return cn.EliminarPokemonEntrenador(id);
        }

        public int InsertarBitacora(string fecha, string descripcion, int id_entrenador_bitacora)
        {
            return cn.InsertarBitacora(fecha, descripcion, id_entrenador_bitacora);
        }

    }






    


}
