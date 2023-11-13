using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public static int SQL(string qry,Hashtable ht)
        {
            int res = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(qry,cnn);
                cmd.CommandType= CommandType.Text;


                foreach (DictionaryEntry item in ht)
                {

                    cmd.Parameters.AddWithValue(item.Key.ToString(),item.Value);

                }
                if (cnn.State== ConnectionState.Closed)
                {
                    cnn.Open();

                }
                res= cmd.ExecuteNonQuery(); 

                if (cnn.State== ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());    
                cnn.Close();
                
            }

            return res;

        }
   




    }
}
