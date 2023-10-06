using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurat_soft
{
    internal class mainclass
    {
        public static readonly string credenciales = "server=LAPTOP-NHM1I0G4\\SQLEXPRESS;database=SoftRESTAURANT;integrated security=true";
        public static SqlConnection cnn = new SqlConnection(credenciales);
        

      public static bool validar(string user, string pass)
        {
            bool val = false;
            string consulta = "select * from acceso where username='" + user + "' and uspass= '" + pass + "'";
            SqlCommand cmd = new SqlCommand(consulta,cnn); 
            DataTable dt=new DataTable();
            SqlDataAdapter da= new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count>0)
            {
                val= true;  

            }
            return val;

        }


    }
}
