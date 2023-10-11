using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Restaurat_soft
{
    class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public void CONEXION()
        {

            try
            {
                cn = new SqlConnection("Data Source=LAPTOP-NHM1I0G4\\SQLEXPRESS;Initial Catalog=EMPLEADOS;Integrated Security=True");
                cn.Open();
                MessageBox.Show("CONECTADO");

            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE CONECTO CON LA BASE DE DATOS " + ex.ToString());
                throw;
            }


        }
        public  string insert(int id, string nombre, string apellido, int telefono, int salario, string categoria)
        {

            string salida = "si se inserto";

            try
            {
                cmd = new SqlCommand("insert into empleados(ID,NOMBRE,APELLIDOS,TELEFONO,SALARIO,categorio) values("+id+",'"+nombre+"','"+apellido+"',"+telefono+","+salario+","+categoria+")",cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "NO SE CONECTO: " + ex.ToString();
                
            }
            return salida;

        }
        //public int PERSONAREGISTRADA(int id)
        //{

        //    int CONTADOR = 0;

        //    try
        //    {
        //        cmd = new SqlCommand("select * from empleados where ID="+id+"", cn);
        //        dr = cmd.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            CONTADOR++;


        //        }
        //        dr.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("NO SE PUDO CONSULTAR BIEN"+ ex.ToString());

        //    }
        //    return CONTADOR;

        
    }
}
