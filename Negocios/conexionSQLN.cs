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

        ConexionSQL cn = new ConexionSQL();
        public int conSQL(string usuario, string contrasena)
        {
            return cn.consultalogin(usuario, contrasena);
        } 

        public DataTable ConsultaDT()
        {
            return cn.ConsultarMov();
        }

        public DataTable ConsultaPok()
        {
            return cn.ConsultarPok();
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

    }

    


}
