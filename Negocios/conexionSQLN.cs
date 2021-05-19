using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos; 

namespace Negocios
{
    public class conexionSQLN
    {

        ConexionSQL cn = new ConexionSQL();
            public int conSQL(string usuario, string contrasena)
        {
            return cn.consultalogin(usuario, contrasena);
        }
    }


}
