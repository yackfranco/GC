using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace Presentacion
{
    public partial class AceptarEstudiante : Form
    {
        public AceptarEstudiante()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (CodigoAsesorComboBox.Text == "Identificacion")
                dataGridView1.DataSource = Consultas.devolverTabla("SELECT dbo.Persona_Registrada.Identificacion, CONCAT (dbo.Persona_Registrada.PNombre,' ',dbo.Persona_Registrada.SNombre,' ',dbo.Persona_Registrada.PApellido,' ',dbo.Persona_Registrada.SApellido) as NombreCompleto , dbo.Diplomados.NombreDiplomado FROM  dbo.Diplo_Cursos INNER JOIN  dbo.Diplomados ON dbo.Diplo_Cursos.IdDiplomado = dbo.Diplomados.NumDiplomado INNER JOIN dbo.Persona_Registrada ON dbo.Diplo_Cursos.IdPersonaRegistrada = dbo.Persona_Registrada.IdPersonaRegistrada WHERE dbo.Diplo_Cursos.Pagado = 'False' and dbo.Persona_Registrada.Identificacion like '" + textBox1.Text + "%'");
            else
                dataGridView1.DataSource = Consultas.devolverTabla("SELECT dbo.Persona_Registrada.Identificacion, CONCAT (dbo.Persona_Registrada.PNombre,' ',dbo.Persona_Registrada.SNombre,' ',dbo.Persona_Registrada.PApellido,' ',dbo.Persona_Registrada.SApellido) as NombreCompleto , dbo.Diplomados.NombreDiplomado FROM  dbo.Diplo_Cursos INNER JOIN  dbo.Diplomados ON dbo.Diplo_Cursos.IdDiplomado = dbo.Diplomados.NumDiplomado INNER JOIN dbo.Persona_Registrada ON dbo.Diplo_Cursos.IdPersonaRegistrada = dbo.Persona_Registrada.IdPersonaRegistrada WHERE dbo.Diplo_Cursos.Pagado = 'False' and CONCAT(dbo.Persona_Registrada.PNombre,' ',dbo.Persona_Registrada.SNombre,' ',dbo.Persona_Registrada.PApellido,' ',dbo.Persona_Registrada.SApellido) like '%" + textBox1.Text + "%'");
        }

        private void AceptarEstudiante_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Consultas.devolverTabla("SELECT dbo.Persona_Registrada.Identificacion, CONCAT (dbo.Persona_Registrada.PNombre,' ',dbo.Persona_Registrada.SNombre,' ',dbo.Persona_Registrada.PApellido,' ',dbo.Persona_Registrada.SApellido) as NombreCompleto , dbo.Diplomados.NombreDiplomado FROM  dbo.Diplo_Cursos INNER JOIN                          dbo.Diplomados ON dbo.Diplo_Cursos.IdDiplomado = dbo.Diplomados.NumDiplomado INNER JOIN                          dbo.Persona_Registrada ON dbo.Diplo_Cursos.IdPersonaRegistrada = dbo.Persona_Registrada.IdPersonaRegistrada WHERE        (dbo.Diplo_Cursos.Pagado = 'False')");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que la persona con cedula " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + " ha pagado el diplomado?", "¿ Esta seguro ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;
            
            int idPersona = 0, idDiplomado = 0, idDiplo_Cursos = 0;
            string codigoAsesor ="";

            if (dataGridView1.Rows.Count > 0)
            {
                if (dataGridView1.CurrentRow.Cells[0].Value.ToString() == "" || dataGridView1.CurrentRow.Cells[1].Value.ToString() == "" || dataGridView1.CurrentRow.Cells[2].Value.ToString() == "")
                {
                    MessageBox.Show("alguno de los datos esta incompleto");
                    return;
                }
                idPersona = Consultas.devolverUnEntero("select IdPersonaRegistrada as n from Persona_Registrada where Identificacion = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'");
                idDiplomado = Consultas.devolverUnEntero("select NumDiplomado as n from Diplomados where NombreDiplomado = '" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "'");
            }

            else
            {
                MessageBox.Show("No se encuentran estudiantes para el pago");
                return;
            }
            Consultas.HacerConsulta("select * from Diplo_Cursos where IdDiplomado = " + idDiplomado + " and IdPersonaRegistrada = " + idPersona + "");
            Consultas.lector = Consultas.comando.ExecuteReader();
            while(Consultas.lector.Read())
            {
                codigoAsesor = Consultas.lector["CodAsesor"].ToString();
                idDiplo_Cursos = Convert.ToInt32(Consultas.lector["IdDiplo_Cursos"].ToString());
            }
            if (codigoAsesor == "")
            {
                Consultas.HacerConsulta("Insert into Diplomado_Pagado (IdDiplomado,IdPersonaRegistrada,FechaPagoAsesor) values (" + idDiplomado + "," + idPersona + ",'"+DateTime.Now.ToString("yyyy-MM-dd")+"')");
                Consultas.comando.ExecuteNonQuery();
            }
            else
            {
                Consultas.HacerConsulta("Insert into Diplomado_Pagado (IdDiplomado,IdPersonaRegistrada,CodigoAsesor,FechaPagoAsesor) values (" + idDiplomado + "," + idPersona + "," + codigoAsesor + ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                Consultas.comando.ExecuteNonQuery();
            }
            Consultas.HacerConsulta("Update Diplo_Cursos SET Pagado = 'true' where IdDiplo_Cursos = "+idDiplo_Cursos+"");
            Consultas.comando.ExecuteNonQuery();
            dataGridView1.DataSource = Consultas.devolverTabla("SELECT dbo.Persona_Registrada.Identificacion, CONCAT (dbo.Persona_Registrada.PNombre,' ',dbo.Persona_Registrada.SNombre,' ',dbo.Persona_Registrada.PApellido,' ',dbo.Persona_Registrada.SApellido) as NombreCompleto , dbo.Diplomados.NombreDiplomado FROM  dbo.Diplo_Cursos INNER JOIN                          dbo.Diplomados ON dbo.Diplo_Cursos.IdDiplomado = dbo.Diplomados.NumDiplomado INNER JOIN                          dbo.Persona_Registrada ON dbo.Diplo_Cursos.IdPersonaRegistrada = dbo.Persona_Registrada.IdPersonaRegistrada WHERE        (dbo.Diplo_Cursos.Pagado = 'False')");
        }
    }
}
