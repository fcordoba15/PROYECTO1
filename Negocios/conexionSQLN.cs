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



    }

    


}
