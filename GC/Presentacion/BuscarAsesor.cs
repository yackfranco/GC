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
    public partial class BuscarAsesor : Form
    {
        public BuscarAsesor()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(CodigoAsesorComboBox.Text == "Codigo")
            dataGridView1.DataSource = Consultas.devolverTabla("select * from Asesores where CodAsesor like '%"+textBox1.Text+"%'");
            else
                dataGridView1.DataSource = Consultas.devolverTabla("select * from Asesores where Identificacion like '%" + textBox1.Text + "%'");

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Variables.codigoAsesor = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.Close();
        }

        private void BuscarAsesor_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Consultas.devolverTabla("select * from Asesores where Identificacion like '%" + textBox1.Text + "%'");
        }
    }
}
