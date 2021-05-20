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

        public void Registrar_clienteUsuario(string usuario, string contrasena, string llave)
        {
            cn.Resgistar_cliente_usuario(usuario, contrasena, llave);
        }

        public void Registrar_cliente(string cedula, string nombre, string telefono, string correo, string sitio_web,
            string provincia, string canton, string distrito, string ubicacion, string usuario)
        {
            cn.Resgistar_Cliente(cedula,nombre,telefono, correo,sitio_web,provincia,canton,distrito,ubicacion,usuario);
        }

        public DataTable ConsultaDT()
        {
            return cn.ConsultarMov();
        }

        public void Registrar_GMap(string id, string Ubicacion, string Latitud, string Longitud)
        { cn.Resgistar_GMaps(id, Ubicacion, Latitud, Longitud); }

    }




    


}
