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
    public partial class RegistrarCursos : Form
    {
        public RegistrarCursos()
        {
            InitializeComponent();
        }

        public string accion = "";

        public void NewOrUpdate(string boton)
        {
            panelDatos.Enabled = true;
            NuevoButton.Enabled = false;
            GuardarButton.Enabled = true;
            CancelarButton.Enabled = true;
            EditarButton.Enabled = false;
            EliminarButton.Enabled = false;
            //            BuscarButton.Enabled = false;
            dataGridView1.Enabled = false;
            if (boton == "nuevo")
            {
                accion = "nuevo";
                panelDatos.Enabled = true;
                NumeroCursoTextBox.Enabled = true;
                NombreCursoTextBox.Enabled = true;
                NumeroCursoTextBox.Text = "";
                NombreCursoTextBox.Text = "";
            }
            else
            {
                accion = "editar";
                panelDatos.Enabled = true;
                NumeroCursoTextBox.Enabled = false;
                NombreCursoTextBox.Enabled = true;
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
                //       BuscarButton.Enabled = true;
                EditarButton.Enabled = true;
            }
            else
            {
                NuevoButton.Enabled = true;
                GuardarButton.Enabled = false;
                CancelarButton.Enabled = false;
                EliminarButton.Enabled = false;
                //     BuscarButton.Enabled = false;
                EditarButton.Enabled = false;
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            NewOrUpdate("nuevo");
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            NewOrUpdate("editar");
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (accion == "nuevo")
                {
                    if (Consultas.devolverUnEntero("select count(numeroCurso) as n from Cursos_Gratuitos where NumeroCurso = " + NumeroCursoTextBox.Text + "") != 0)
                    {
                        MessageBox.Show("El numero de Curso Ya esta registrado en la Base de Datos", "Elige Otro Numero de Curso Gratuito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Consultas.HacerConsulta("insert into Cursos_Gratuitos (NumeroCurso, NombreCurso) values (" + Convert.ToInt32(NumeroCursoTextBox.Text) + ",'" + NombreCursoTextBox.Text + "')");
                    Consultas.comando.ExecuteNonQuery();
                    llenartabla();
                }
                else
                {
                    Consultas.HacerConsulta("update Cursos_Gratuitos set NombreCurso = '" + NombreCursoTextBox.Text + "' where NumeroCurso = " + NumeroCursoTextBox.Text + "");
                    Consultas.comando.ExecuteNonQuery();
                    llenartabla();
                }
                JuegoBotones();
                panelDatos.Enabled = false;
                dataGridView1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en Registrar Cursos Gratuitos......" + ex);
            }
         
        }
        public void llenartabla()
        {  
            dataGridView1.DataSource = Consultas.devolverTabla("Select * From Cursos_Gratuitos");
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            panelDatos.Enabled = false;
            dataGridView1.Enabled = true;
            NumeroCursoTextBox.Enabled = true;
            NombreCursoTextBox.Enabled = true;
            JuegoBotones();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta usted seguro que desea Eliminar el Diplomado con Numero " + NumeroCursoTextBox.Text + "\n y de Nombre " +NombreCursoTextBox.Text + "", "¡ CUIDADO !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Consultas.HacerConsulta("delete from Cursos_Gratuitos where NumeroCurso = " + NumeroCursoTextBox.Text + "");
                Consultas.comando.ExecuteNonQuery();
                llenartabla();
                JuegoBotones();
            }
        }

        private void RegistrarCursos_Load(object sender, EventArgs e)
        {
            llenartabla();
            JuegoBotones();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            NumeroCursoTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            NombreCursoTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }


    }
}
