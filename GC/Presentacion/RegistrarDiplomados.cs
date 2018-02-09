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
    public partial class RegistrarDiplomados : Form
    {
        public RegistrarDiplomados()
        {
            InitializeComponent();
        }
        public string accion = "";

        private void RegistrarDiplomados_Load(object sender, EventArgs e)
        {
            llenartabla();
            JuegoBotones();
        }


        public void llenartabla()
        {
            dataGridView1.DataSource = Consultas.devolverTabla("Select * From Diplomados");
        }

        public void NewOrUpdate(string boton)
        {
            panelDatos.Enabled = true;
            NuevoButton.Enabled = false;
            GuardarButton.Enabled = true;
            CancelarButton.Enabled = true;
            EditarButton.Enabled = false;
            EliminarButton.Enabled = false;
            BuscarButton.Enabled = false;
            dataGridView1.Enabled = false;
            if (boton== "nuevo")
            {
                accion = "nuevo";
                panelDatos.Enabled = true;
                NumeroDiplomadoTextBox.Enabled = true;
                NombreDiplomadoTextBox.Enabled = true;
                NumeroDiplomadoTextBox.Text = "";
                NombreDiplomadoTextBox.Text = "";
            }
            else
            {
                accion = "editar";
                panelDatos.Enabled = true;
                NumeroDiplomadoTextBox.Enabled = false;
                NombreDiplomadoTextBox.Enabled = true;
            }
        }

        public void JuegoBotones()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                NuevoButton.Enabled = true;
                GuardarButton.Enabled = false;
                CancelarButton.Enabled = false;
                EliminarButton.Enabled = true;
                BuscarButton.Enabled = true;
                EditarButton.Enabled = true;
            }
            else
            {
                NuevoButton.Enabled = true;
                GuardarButton.Enabled = false;
                CancelarButton.Enabled = false;
                EliminarButton.Enabled = false;
                BuscarButton.Enabled = false;
                EditarButton.Enabled = false;
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            NewOrUpdate("nuevo");
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (accion == "nuevo")
                {
                    if(Consultas.devolverUnEntero("select count(NumDiplomado) as n from Diplomados where NumDiplomado = "+NumeroDiplomadoTextBox.Text+"")!=0)
                    {
                        MessageBox.Show("El numero de Diplomado Ya esta registrado en la Base de Datos","Elige Otro Numero de Diplomado",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }
                    Consultas.HacerConsulta("insert into Diplomados (NumDiplomado, NombreDiplomado) values ("+Convert.ToInt32(NumeroDiplomadoTextBox.Text)+",'"+NombreDiplomadoTextBox.Text+"')");
                    Consultas.comando.ExecuteNonQuery();
                    llenartabla();
                }
                else
                {
                    Consultas.HacerConsulta("update Diplomados set NombreDiplomado = '"+NombreDiplomadoTextBox.Text+"' where NumDiplomado = "+NumeroDiplomadoTextBox.Text+"");
                    Consultas.comando.ExecuteNonQuery();
                    llenartabla();
                }
                JuegoBotones();
                dataGridView1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en Registrar Diplomados......"+ex);
            }
            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            NumeroDiplomadoTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            NombreDiplomadoTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            NewOrUpdate("Editar");
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            panelDatos.Enabled = false;
            dataGridView1.Enabled = true;
            NumeroDiplomadoTextBox.Enabled = true;
            NombreDiplomadoTextBox.Enabled = true;
            JuegoBotones();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta usted seguro que desea Eliminar el Diplomado con Numero " + NumeroDiplomadoTextBox.Text + "\n y de Nombre " + NombreDiplomadoTextBox.Text + "", "¡ CUIDADO !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Consultas.HacerConsulta("delete from Diplomados where NumDiplomado = "+NumeroDiplomadoTextBox.Text+"");
                Consultas.comando.ExecuteNonQuery();
                llenartabla();
                JuegoBotones();
            }
        }

    }
}
