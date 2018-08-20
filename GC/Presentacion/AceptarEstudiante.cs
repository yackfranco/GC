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
        public double primeraVenta=0,SegundaVenta = 0;
        private void AceptarEstudiante_Load(object sender, EventArgs e)
        {
            primeraVenta = Convert.ToDouble(Consultas.DevolverUnString("select primeraVenta as n from configurar"));
            SegundaVenta = Convert.ToDouble(Consultas.DevolverUnString("select SegundaVenta as n from configurar"));
            dataGridView1.DataSource = Consultas.devolverTabla("SELECT dbo.Persona_Registrada.Identificacion, CONCAT (dbo.Persona_Registrada.PNombre,' ',dbo.Persona_Registrada.SNombre,' ',dbo.Persona_Registrada.PApellido,' ',dbo.Persona_Registrada.SApellido) as NombreCompleto , dbo.Diplomados.NombreDiplomado FROM  dbo.Diplo_Cursos INNER JOIN                          dbo.Diplomados ON dbo.Diplo_Cursos.IdDiplomado = dbo.Diplomados.NumDiplomado INNER JOIN                          dbo.Persona_Registrada ON dbo.Diplo_Cursos.IdPersonaRegistrada = dbo.Persona_Registrada.IdPersonaRegistrada WHERE        (dbo.Diplo_Cursos.Pagado = 'False')");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelBuscar.Enabled = false;
            panel2.Visible = true;
            dataGridView1.Enabled = false;
            textBox3.Text = Consultas.DevolverUnString("select ValorDiplomado as n from configurar");
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.Location = new Point(pic.Location.X-5, pic.Location.Y-5);
            pic.Size = new Size(pic.Size.Width+5,pic.Size.Height+5);
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.Location = new Point(pic.Location.X + 5, pic.Location.Y + 5);
            pic.Size = new Size(pic.Size.Width - 5, pic.Size.Height - 5);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("El valor Pagado no puede estar en blanco");
                return;
            }
            
            if (MessageBox.Show("Esta seguro que la persona con cedula " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + " ha pagado el diplomado?", "¿ Esta seguro ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;

            int idPersona = 0, idDiplomado = 0, idDiplo_Cursos = 0;
            string codigoAsesor = "";

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
            while (Consultas.lector.Read())
            {
                codigoAsesor = Consultas.lector["CodAsesor"].ToString();
                idDiplo_Cursos = Convert.ToInt32(Consultas.lector["IdDiplo_Cursos"].ToString());
            }

            int contarPersonaRegistrada = Consultas.devolverUnEntero("select count(*) as n from Diplo_Cursos where IdPersonaRegistrada = " + Consultas.DevolverUnString("select IdPersonaRegistrada as n from Persona_Registrada where Identificacion = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'") + "");
            double comisionAsesor = (contarPersonaRegistrada == 1) ? primeraVenta : SegundaVenta;

            if (codigoAsesor == "")
            {
                Consultas.HacerConsulta("Insert into Diplomado_Pagado (IdDiplomado,IdPersonaRegistrada,FechaPagoAsesor,Observacion,ValorDiplomado) values (" + idDiplomado + "," + idPersona + ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + textBox2.Text + "',"+textBox3.Text+")");
                Consultas.comando.ExecuteNonQuery();
            }
            else
            {
                Consultas.HacerConsulta("Insert into Diplomado_Pagado (IdDiplomado,IdPersonaRegistrada,CodigoAsesor,FechaPagoAsesor,Observacion,ValorDiplomado,ComisionAsesor) values (" + idDiplomado + "," + idPersona + "," + codigoAsesor + ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + textBox2.Text + "'," + textBox3.Text + "," + comisionAsesor + ")");
                Consultas.comando.ExecuteNonQuery();
            }
            Consultas.HacerConsulta("Update Diplo_Cursos SET Pagado = 'true' where IdDiplo_Cursos = " + idDiplo_Cursos + "");
            Consultas.comando.ExecuteNonQuery();
            dataGridView1.DataSource = Consultas.devolverTabla("SELECT dbo.Persona_Registrada.Identificacion, CONCAT (dbo.Persona_Registrada.PNombre,' ',dbo.Persona_Registrada.SNombre,' ',dbo.Persona_Registrada.PApellido,' ',dbo.Persona_Registrada.SApellido) as NombreCompleto , dbo.Diplomados.NombreDiplomado FROM  dbo.Diplo_Cursos INNER JOIN                          dbo.Diplomados ON dbo.Diplo_Cursos.IdDiplomado = dbo.Diplomados.NumDiplomado INNER JOIN                          dbo.Persona_Registrada ON dbo.Diplo_Cursos.IdPersonaRegistrada = dbo.Persona_Registrada.IdPersonaRegistrada WHERE        (dbo.Diplo_Cursos.Pagado = 'False')");
            limpiar();
        }

        public void limpiar()
        {
            panel2.Visible = false;
            textBox2.Text = "";
            textBox3.Text = "";
            dataGridView1.Enabled = true;
            panelBuscar.Enabled = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }

       
    }
}
