using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.ServiceModel;
using System.Windows.Forms;

namespace Restaurat_soft
{
    public  class mainclass
    {
        public static readonly string credenciales = "server=SEBASTIAN_DURAN\\SQLSERVER_SEBAS;database=SoftRESTAURANT;integrated security=true";
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
        public static DataTable TB_compras()
        {
            string consulta = "select *from compras";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, cnn);
            DataTable dt= new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public static void añadircompra(int cantidad,string producto,double precio ,string tipodepago,double preciotoal)
        {
            try
            {
            cnn.Open();
            string conslta = "insert into compras(cantidad,Producto,precio,Tipo_Pago,Precio_Final) values(" + cantidad + ",´" + producto + "´," + precio + ",'" + tipodepago + "'," + preciotoal + ")";
            SqlCommand comand = new SqlCommand(conslta, cnn);
            comand.ExecuteNonQuery();
                cnn.Close();
            }
            catch(Exception ex)
            {
                cnn.Close();
            }
            
        }
   




    }
}
