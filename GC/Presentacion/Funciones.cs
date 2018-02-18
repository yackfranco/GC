using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using Datos;

namespace Presentacion
{
    class Funciones
    {
        public void actualizarBaseDatos(string archivo)
        {
            string cadenaConexionExcel = "provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + archivo + "';Extended Properties=Excel 12.0;";
            OleDbConnection conexionExcel = new OleDbConnection(cadenaConexionExcel);


            //Traigo el Maximo IdPag que existe en la BD
            int MaxIdPag = 0;
            try
            {
                MaxIdPag = Convert.ToInt32(Consultas.DevolverUnString("select max(IdPag) as n from Diplo_Cursos"));
            }
            catch (Exception) { MaxIdPag = 0; }

            //Hago la consulta
            string consulta = "select * from [H1$] where ID> " + MaxIdPag + " and TITLE like '%Diplomado%' or TITLE like '%Curso%' order by ID";


            //Abro la conexion para el excel
            conexionExcel.Open();
            OleDbDataReader lector = null;
            OleDbCommand comandoExcel = new OleDbCommand(consulta, conexionExcel);
            lector = comandoExcel.ExecuteReader();

            //Traigo a partir del Maximo idpag de la bd lo que hay en el excel
            string IdPersona = "";
            while (lector.Read())
            {

                int idPag = Convert.ToInt32(lector["ID"].ToString());
                IdPersona = Consultas.DevolverUnString("select IdPersonaRegistrada as n from Persona_Registrada where Identificacion = '" + lector["Número de Identificación:"].ToString() + "' and Estado is null");
                if (IdPersona == "")
                {
                    //Insertar la persona
                    string identificacion = lector["Número de Identificación:"].ToString();
                    string pNombre = lector["Primer Nombre:"].ToString();
                    string sNombre = lector["Segundo Nombre:"].ToString();
                    string pApellido = lector["Primer Apellido:"].ToString();
                    string sApellido = lector["Segundo Apellido:"].ToString();
                    string Genero = lector["Genero:"].ToString();
                    string Pais = lector["País de Residencia:"].ToString();
                    string Ciudad = lector["Ciudad de Residencia:"].ToString();
                    string direccion = lector["Dirección de Residencia:"].ToString();
                    string Telefono = lector["Teléfono de Contacto:"].ToString();
                    string Correo = lector["Email:"].ToString();
                    IdPersona = Consultas.InsertDevovliendoId("insert into Persona_Registrada (Identificacion,PNombre,SNombre,PApellido,SApellido,Genero,Pais,Ciudad,Direccion,Telefono,Correo) values ('" + identificacion + "','" + pNombre + "','" + sNombre + "','" + pApellido + "','" + sApellido + "','" + Genero + "','" + Pais + "','" + Ciudad + "','" + direccion + "','" + Telefono + "','" + Correo + "')").ToString();
                }
                //Sigue el proceso
                
                int diplomado =0;
                int curso= 0; 
                try
                {
                    diplomado = Convert.ToInt32(lector["Nombre del Diplomado Virtual a realizar:"].ToString());
                }
                catch (Exception)
                {
                    curso = Convert.ToInt32(lector["Nombre del Curso a realizar:"].ToString());
                }


                //Se valida si el codigo de asesor es correcto
                int codAsesor = 0;
                try
                {
                    codAsesor = Convert.ToInt32(lector["Digite el Codigo del Asesor:"].ToString());
                }
                catch (Exception) { }
                
                //Consultas.HacerConsulta("insert into Diplo_Cursos (IdPag,IdPersonaRegistrada,IdDiplomado,CodAsesor, IdCursoG,Pagado, DateCreated) values (" + idPag + "," + IdPersona + "," + diplomado + "," + codAsesor + "," + curso + ",'false','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                try
                {
                    if (diplomado != 0)
                    {
                        if (codAsesor != 0)
                            Consultas.HacerConsulta("insert into Diplo_Cursos (IdPag,IdPersonaRegistrada,IdDiplomado,CodAsesor,Pagado, DateCreated) values (" + idPag + "," + IdPersona + "," + diplomado + "," + codAsesor + ",'false','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                        else
                            Consultas.HacerConsulta("insert into Diplo_Cursos (IdPag,IdPersonaRegistrada,IdDiplomado,Pagado, DateCreated) values (" + idPag + "," + IdPersona + "," + diplomado + ",'false','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                    }
                    else
                    {
                        Consultas.HacerConsulta("insert into Diplo_Cursos (IdPag,IdPersonaRegistrada, IdCursoG,Pagado, DateCreated) values (" + idPag + "," + IdPersona + "," + curso + ",'false','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                    }
                    Consultas.comando.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("Algun diplomado o Curso no esta registrado en la Base de datos");
                }
                
            }
        }
    }
}
