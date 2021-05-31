//Bibliotecas que se van a utilizar
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;
using System.Windows.Forms;


namespace Negocios
{
    public class conexionSQLN
    {
        // ---------------------->CODIGO PARA CONECTAR A LA BASE DE DATOS 

        //--ABRIR CONEXION
        ConexionSQL cn = new ConexionSQL();
        public string conSQL_cliente(string usuario, string contrasena)
        {
            return cn.consultalogin_cliente(usuario, contrasena);
        }


        //---AUTENTICAR ENTRENADOR
        public string conSQL_entrenador(string usuario, string contrasena)
        {
            return cn.consultalogin_entrenador(usuario, contrasena);
        }

        //---AUTENTICAR ADMINISTRADOR
        public string conSQL_administrador(string usuario, string contrasena)
        {
            return cn.consultalogin_administrador(usuario, contrasena);
        }

        /*
         * ---------------------->CODIGO PARA REGISTRAR USUARIOS
         * 
         */

        //----REGISTRAR USUARIO-CLIENTE
        public void Registrar_clienteUsuario(string usuario, string contrasena, string llave)
        {
            cn.Resgistar_cliente_usuario(usuario, contrasena, llave);
        }


        //_---REGISTRAR CLIENTE
        public void Registrar_cliente(string cedula, string nombre, string telefono, string correo, string sitio_web,
            string provincia, string canton, string distrito, string usuario)
        {
            cn.Resgistar_Cliente(cedula, nombre, telefono, correo, sitio_web, provincia, canton, distrito, usuario);
        }

        //---REGISTRAR UBICACION GOOGLEMAPS
        public void Registrar_GMap(string id_client, string Ubicacion, string Latitud, string Longitud)
        {
            cn.Resgistar_GMaps(id_client, Ubicacion, Latitud, Longitud);
        }

        //---REGISTAR USUARIO-ENTRENADOR
        public void Registrar_entrenadorUsuario(string usuario, string contrasena, string llave)
        {
            cn.Resgistar_entrenador_usuario(usuario, contrasena, llave);
        }

        //---REGISTAR REDES-ENTRENADOR
        public void Registrar_entrenador_red_social(string red_social, string usuario_red, string id)
        {
            cn.Resgistar_entrenador_red_social(red_social, usuario_red, id);
        }


        //----REGISTRAR ENTRENADOR
        public void Registrar_entrenador(string cedula, string nombre, string calificacion, string telefono, string correo, string sitio_web,
            string provincia, string canton, string distrito, string usuario)
        {
            cn.Resgistar_Entrenador(cedula, nombre, calificacion, telefono, correo, sitio_web, provincia, canton, distrito, usuario);
        }


        //----REGISTAR USUARIO-ADMINISTRADOR
        public void Registrar_administradorUsuario(string usuario, string contrasena, string llave)
        {
            cn.Resgistar_administrador_usuario(usuario, contrasena, llave);
        }

        /*
         *---------------------->CODIGO PARA CONSULTAS TABLA INTERMEDIA_MOV_POK_ENTRENADOR
         * 
         */
        //---MOSTAR TABLA MOVIMIENNTO
        public DataTable ConsultaDT()
        {
            return cn.ConsultarMov();
        }
        public int InsertarMovimiento(string id_entrenador, int id_pokemon, string cod_movimiento)
        {
            return cn.InsertarMovimiento(id_entrenador, id_pokemon, cod_movimiento);
        }

        //---MODIFICAR MOVIMIENTO TABLA MOVIMIENTO
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

        //---MOSTRAR TABLA POKEMON
        public DataTable ConsultaPokemonDT()
        {
            return cn.ConsultarPok();
        }

        //INSETAR POKEMON CAPA ADMI
        public int InsertarPokemonAdministrador(string nombre_pokemon, string id_tipo, string cod_tipo, string total,
            string salud, string ataque, string defensa, string ataque_especial, string defensa_especial, string velocidad,
            string generacion, string legendario, byte[] foto)
        {
            return cn.InsertarPokemonAdministrador(nombre_pokemon, id_tipo, cod_tipo, total, salud, ataque, defensa,
                ataque_especial, defensa_especial, velocidad, generacion, legendario, foto);
        }

        //MODIFICAR POKEMON CAPA ADMI
        public int ModificarPokemonAdministrador(int id, string nombre_pokemon, string id_tipo, string cod_tipo, string total,
            string salud, string ataque, string defensa, string ataque_especial, string defensa_especial, string velocidad,
            string generacion, string legendario, byte[] foto)
        {
            return cn.ModificarPokemonAdministrador(id, nombre_pokemon, id_tipo, cod_tipo, total, salud, ataque, defensa,
                ataque_especial, defensa_especial, velocidad, generacion, legendario, foto);
        }

        //ELMINAR POKEMON CAPA ADMI
        public int EliminarPokemonAdministrador(int id)
        {
            return cn.EliminarPokemonAdministrador(id);
        }

        //MOSTRAR ID POKEMON COMBO-BOX
        public void Cm_IdPokemon(ComboBox cb)
        {

            cn.cm_IdPokemon(cb);
        }


        //MOSTAR INFO POKEMON EN TEXTBOX 
        public string[] Info_pokemon(int id)
        {
            return cn.info_pokemon(id);
        }


        /*
         * 
         * 
         * 
        * 
        * ------------------------------->CONSULTAS ADMINISTRADOR GESTION USUARIOS
        * 
        */

        //MOSTRAR USUARIOS
        public DataTable ConsultaUsuariosMADT()
        {
            return cn.ConsultarUsuariosAdmin();
        }

        //INSERTAR USUARIO ADMI
        public int InsertarUsuarioAdmin(string nombre_usuario_MA, string password_usuario_MA, string rol_usuario_MA)
        {
            return cn.InsertarUsuarioAdmin(nombre_usuario_MA, password_usuario_MA, rol_usuario_MA);
        }

        //---MODIFICAR USUARIO-ADMI
        public int ModificarUsuarioAdmin(string nombre_usuario_MA, string password_usuario_MA, string rol_usuario_MA)
        {
            return cn.ModificarUsuarioAdmin(nombre_usuario_MA, password_usuario_MA, rol_usuario_MA);
        }

        //---ELIMINAR USUARIO ADMI
        public int EliminarUsuarioAdmin(string nombre_usuario_MA)
        {
            return cn.EliminarUsuarioAdmin(nombre_usuario_MA);
        }

        public void cm_Usuarios(ComboBox cb)
        {
            cn.cm_Usuarios(cb);
        }

        //---MOSTRAR INFO TEXTBOX
        public string[] Info_usuarios(string id)
            {
                return cn.info_usuarios(id);
            }
        /*
        * 
        * ------------------------------->CONSULTAS ADMINISTRADOR GESTION MOVIMIENTOS
        * 
        */

        //---MOSTRAR TABLA MOVIMIENTOS
        public DataTable ConsultaMovimientosAdmin()
        {
            return cn.ConsultarMovimientosAdmin();
        }

        //---INSERTAR MOVIMIENTO
        public int InsertarMovimientoAdmin(string codigoMovimiento, string descripcionMovimiento, string nombreMovimiento,
            string tipoMovimiento)
        {
            return cn.InsertarMovimientoAdmin(codigoMovimiento, descripcionMovimiento, nombreMovimiento, tipoMovimiento);
        }

        //----MODIFICAR MOVIMIENTO
        public int ModificarMovimientoAdmin(string codigoMovimiento, string descripcionMovimiento, string nombreMovimiento,
           string tipoMovimiento)
        {
            return cn.ModificarMovimientoAdmin(codigoMovimiento,  descripcionMovimiento,  nombreMovimiento,
            tipoMovimiento);
        }

        //---ELIMINAR MOVIMIENTO
        public int EliminarMovimientoAdmin(string codigoMovimiento)
        {
            return cn.EliminarMovimientoAdmin(codigoMovimiento);

        }

        //---MOSTRAR ID MOVIMIENTOS EN COMBOBOX
        public void Cm_IdMovimiento(ComboBox cb)
        {
            cn.cm_IdMovimiento(cb);
        }
         

        //---MOSTRAR DATOS MOVIMIENTO ID
         public string[] Info_movimiento(string id)
        {
            return cn.info_movimiento(id);
        }

        /*
        * 
        * 
        * ------------------------------->CONSULTAS ADMINISTRADOR GESTION ENTRENADORES
        * 
        * 
        */
        //---MOSTRAR TABLA ENTRENADOR

        public DataTable ConsultaEntrenadoresAdmin()
        {
            return cn.ConsultarEntrenadorAdmi();
        }


        //----MODIFICAR ENTRENADOR
        public int ModificarEntrenadorAdmin(string id_entrenador_MA, string nombre_entrenador_MA, string calificacion
           , string telefono, string correo_electronico, string sitio_web, string provincia, string canton, string distrito,
           string ubicacion)
        {
            return cn.ModificarEntrenadorAdmin(id_entrenador_MA, nombre_entrenador_MA, calificacion, telefono, correo_electronico,
                sitio_web, provincia, canton, distrito, ubicacion);
        }

        //--ELIMINAR ENTRENADOR
        public int EliminarEntrenadorAdministrador(int id_entrenador_MA)
        {
            return cn.EliminarEntrenadorAdministrador(id_entrenador_MA);

        }



        /*
        * 
        * ---------------------->CONSULTAS POKEMON ENTRENADOR
        * 
        */

        //INSERTAR BITÁCORRA
        public int InsertarBitacora(string fecha, string descripcion, string id_entrenador_bitacora)
        {
            return cn.InsertarBitacora(fecha, descripcion, id_entrenador_bitacora);
        }

        //MOSTAR TABLA POKEMON-ENTRENADOR
        public DataTable ConsultaPokemonesEntrenador()
        {
            return cn.ConsultarPokemonesEntrenador();
        }

        //---INSERTAR POKEMON-ENTRENADOR
        public int InsertarPokemonEntrenador(string id_entrenador_pokemon, int id_pokemon_entrenador, string estado)
        {
            return cn.InsertarPokemonEntrenador(id_entrenador_pokemon, id_pokemon_entrenador, estado);
        }

        //--MODIFICAR POKEMON
        public int ModificarPokemonEntrenador(string id_entrenador_pokemon, int id_pokemon_entrenador, string estado)
        {
            return cn.ModificarPokemonEntrenador(id_entrenador_pokemon, id_pokemon_entrenador, estado);
        }

        //---ELIMINAR POKEMON
        public int EliminarPokemonEntrenador(string id_entrenador_pokemon, int id_pokemon_entrenador)
        {
            int i = Convert.ToInt32(id_pokemon_entrenador);
            return cn.EliminarPokemonEntrenador(id_entrenador_pokemon, i);
        }

        //---MOSTRAR IMAGEN
        public void Imagen_Mostrar( PictureBox pb,int id)
        {
           cn.Imagen_Mostrar( pb,id);
           
        }

        //---MOSTAR ID ENTRENADOR COMBOBOX
        public void Cm_Identrenador(ComboBox cb)
        {
            cn.cm_Identrenador(cb);

        }


        //---MOSTRAR DATOS DE ENTRENADOR
        public string[] Info_Entrenador(string id)
        {
            return cn.info_Entrenador(id);
        }
            /*
            *---------------------->CODIGO PARA CONSULTAS MODULO CLIENTE
            * 
            */

        //-----MOSTAR TABLA CLIENTE POKEMON
            public DataTable Cliente_pokemon(string categoria, string tipo)
        {
            return cn.Cliente_Pokemon(categoria,tipo);
        }


        //----TABLA RESULTADO DE LA BUSQUEDA FILTRO-MOVIMIENTO
        public DataTable Cliente_movimiento(string tipo)
        {
            return cn.Cliente_Movimiento(tipo);
        }

        //---TABLA RESULTADO DE LA BUSQUEDA FILTRO-ENTRENADOR
        public DataTable Cliente_entrenador(string ubicacion, string nombre)
        {
            return cn.Cliente_Entrenador(ubicacion,nombre);
        }
    }








    


}
