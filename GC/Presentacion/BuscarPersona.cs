using System
;
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
    public partial class BuscarPersona : Form
    {
        public BuscarPersona()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (CodigoAsesorComboBox.Text == "Identificacion")
                dataGridView1.DataSource = Consultas.devolverTabla("select Identificacion,CONCAT(PNombre,' ',SNombre,' ',PApellido,' ',SApellido) as Nombre,  Ciudad from Persona_Registrada where Identificacion like '%" + textBox1.Text + "%'");
            else
                dataGridView1.DataSource = Consultas.devolverTabla("select Identificacion,CONCAT(PNombre,' ',SNombre,' ',PApellido,' ',SApellido) as Nombre, Ciudad from Persona_Registrada where PNombre like '%" + textBox1.Text + "%'");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Variables.identPersona = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.Close();
        }

        private void BuscarPersona_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Consultas.devolverTabla("select Identificacion,CONCAT(PNombre,' ',SNombre,' ',PApellido,' ',SApellido) as Nombre,  Ciudad from Persona_Registrada where Identificacion like '%" + textBox1.Text + "%'");
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Variables.identPersona = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
