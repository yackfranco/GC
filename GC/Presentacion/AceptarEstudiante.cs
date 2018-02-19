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
                dataGridView1.DataSource = Consultas.devolverTabla("SELECT        dbo.Persona_Registrada.Identificacion, CONCAT (dbo.Persona_Registrada.PNombre,' ',dbo.Persona_Registrada.SNombre,' ',dbo.Persona_Registrada.PApellido,' ',dbo.Persona_Registrada.SApellido) as NombreCompleto , dbo.Diplomados.NombreDiplomado, dbo.Diplo_Cursos.Pagado FROM  dbo.Diplo_Cursos INNER JOIN                          dbo.Diplomados ON dbo.Diplo_Cursos.IdDiplomado = dbo.Diplomados.NumDiplomado INNER JOIN                          dbo.Persona_Registrada ON dbo.Diplo_Cursos.IdPersonaRegistrada = dbo.Persona_Registrada.IdPersonaRegistrada WHERE        (dbo.Diplo_Cursos.Pagado = 'False') and dbo.PersonaRegistrada.Identificacion like '%"+textBox1.Text+"%'");
            //else
                //dataGridView1.DataSource = Consultas.devolverTabla("SELECT        dbo.Persona_Registrada.Identificacion, CONCAT (dbo.Persona_Registrada.PNombre,' ',dbo.Persona_Registrada.SNombre,' ',dbo.Persona_Registrada.PApellido,' ',dbo.Persona_Registrada.SApellido) as NombreCompleto , dbo.Diplomados.NombreDiplomado, dbo.Diplo_Cursos.Pagado FROM  dbo.Diplo_Cursos INNER JOIN                          dbo.Diplomados ON dbo.Diplo_Cursos.IdDiplomado = dbo.Diplomados.NumDiplomado INNER JOIN                          dbo.Persona_Registrada ON dbo.Diplo_Cursos.IdPersonaRegistrada = dbo.Persona_Registrada.IdPersonaRegistrada WHERE        (dbo.Diplo_Cursos.Pagado = 'False')");
        }

        private void AceptarEstudiante_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Consultas.devolverTabla("SELECT dbo.Persona_Registrada.Identificacion, CONCAT (dbo.Persona_Registrada.PNombre,' ',dbo.Persona_Registrada.SNombre,' ',dbo.Persona_Registrada.PApellido,' ',dbo.Persona_Registrada.SApellido) as NombreCompleto , dbo.Diplomados.NombreDiplomado, dbo.Diplo_Cursos.Pagado FROM  dbo.Diplo_Cursos INNER JOIN                          dbo.Diplomados ON dbo.Diplo_Cursos.IdDiplomado = dbo.Diplomados.NumDiplomado INNER JOIN                          dbo.Persona_Registrada ON dbo.Diplo_Cursos.IdPersonaRegistrada = dbo.Persona_Registrada.IdPersonaRegistrada WHERE        (dbo.Diplo_Cursos.Pagado = 'False')");
        }
    }
}
