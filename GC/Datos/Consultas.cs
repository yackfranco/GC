using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Windows.Forms;

namespace Datos
{
    public class Consultas
    {
        //Objetos de conexion
        public static SqlCommand comando = new SqlCommand();
        public static SqlCommand comando2 = new SqlCommand();
        //public static SqlConnection conexion = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=" + Application.StartupPath.ToString() + @"\DatosBD.mdf");
        public static SqlConnection conexion = new SqlConnection(Properties.Settings.Default.BDGC);
        public static SqlDataReader lector = null;  

        //Metodos en Logica
        public static void HacerConsulta(string texto)
        {
            try
            {
                comando.CommandText = texto;
                comando.Connection = conexion;
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
                conexion.Open();
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        public static int devolverUnEntero(string texto)
        {
            try
            {
                int id = 0;
                HacerConsulta(texto);
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    id = Convert.ToInt32(lector["n"].ToString());
                }
                return id;
            }
            catch (Exception)
            {
                return 0;
            }
           
        }

        public static int InsertDevovliendoId(string texto)
        {
            try
            {
                texto = texto + "Select @@Identity as id";
                int iddevuelve = 0;
                HacerConsulta(texto);
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    iddevuelve = Convert.ToInt32(lector["id"]);
                }
                return iddevuelve;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static DataTable devolverTabla(string consulta)
        {
            DataTable tabla = new DataTable();
            //SqlDataAdapter adaptador = new SqlDataAdapter();
            try
            {
                HacerConsulta(consulta);
                comando.ExecuteNonQuery();
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                tabla.Clear();
                adaptador.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                string exs = ex.ToString();
                throw;
            }
        }


        public static string DevolverUnString(string texto)
        {
            string dato="";
            HacerConsulta(texto);
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                 dato = lector["n"].ToString();
            }
            return dato;
            
        }
    }
}
