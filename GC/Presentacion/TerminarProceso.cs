using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class TerminarProceso : Form
    {
        public TerminarProceso()
        {
            InitializeComponent();
        }

        private void TerminarProceso_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        public void CargarTabla()
        {
            //"SELECT dbo.Diplomado_pagado.IdDiploPagado, dbo.Persona_Registrada.Identificacion, CONCAT( dbo.Persona_Registrada.PNombre,' ',dbo.Persona_Registrada.SNombre,' ', dbo.Persona_Registrada.PApellido,' ', dbo.Persona_Registrada.SApellido) as NombreCompleto,  dbo.Diplomados.NombreDiplomado, dbo.Diplomado_pagado.Observacion FROM            dbo.Diplomado_pagado INNER JOIN dbo.Persona_Registrada ON dbo.Diplomado_pagado.IdPersonaRegistrada = dbo.Persona_Registrada.IdPersonaRegistrada INNER JOIN dbo.Diplomados ON dbo.Diplomado_pagado.IdDiploPagado = dbo.Diplomados.NumDiplomado where dbo.Diplomado_pagado.Estado is null"

            //SELECT dbo.Diplomado_pagado.IdDiploPagado, dbo.Persona_Registrada.Identificacion, CONCAT( dbo.Persona_Registrada.PNombre,' ',dbo.Persona_Registrada.SNombre,' ', dbo.Persona_Registrada.PApellido,' ', dbo.Persona_Registrada.SApellido) as NombreCompleto,  dbo.Diplomados.NombreDiplomado, dbo.Diplomado_pagado.Observacion FROM            dbo.Diplomado_pagado INNER JOIN dbo.Persona_Registrada ON dbo.Diplomado_pagado.IdPersonaRegistrada = dbo.Persona_Registrada.IdPersonaRegistrada INNER JOIN dbo.Diplomados ON dbo.Diplomado_pagado.IdDiploPagado = dbo.Diplomados.NumDiplomado where dbo.Diplomado_pagado.Estado is null and (Identificacion like '%" + BuscarTextBox.Text + "%' or dbo.Persona_Registrada.PNombre like '%" + BuscarTextBox.Text + "%' or dbo.Persona_Registrada.SNombre like '%" + BuscarTextBox.Text + "%'or dbo.Persona_Registrada.PApellido like '%" + BuscarTextBox.Text + "%' or dbo.Persona_Registrada.SApellido like '%" + BuscarTextBox.Text + "%')
            dataGridView1.DataSource = Consultas.devolverTabla("SELECT dbo.Diplomado_pagado.IdDiploPagado,dbo.Diplomado_pagado.IdDiplomado,dbo.Diplomado_pagado.IdPersonaRegistrada, dbo.Persona_Registrada.Identificacion, CONCAT( dbo.Persona_Registrada.PNombre,' ',dbo.Persona_Registrada.SNombre,' ', dbo.Persona_Registrada.PApellido,' ', dbo.Persona_Registrada.SApellido) as NombreCompleto,  dbo.Diplomados.NombreDiplomado, dbo.Diplomado_pagado.Observacion FROM            dbo.Diplomado_pagado INNER JOIN dbo.Persona_Registrada ON dbo.Diplomado_pagado.IdPersonaRegistrada = dbo.Persona_Registrada.IdPersonaRegistrada INNER JOIN dbo.Diplomados ON dbo.Diplomado_pagado.IdDiploPagado = dbo.Diplomados.NumDiplomado where dbo.Diplomado_pagado.Estado is null and (Identificacion like '%" + BuscarTextBox.Text + "%' or dbo.Persona_Registrada.PNombre like '%" + BuscarTextBox.Text + "%' or dbo.Persona_Registrada.SNombre like '%" + BuscarTextBox.Text + "%'or dbo.Persona_Registrada.PApellido like '%" + BuscarTextBox.Text + "%' or dbo.Persona_Registrada.SApellido like '%" + BuscarTextBox.Text + "%')");
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
        }

        private void BuscarTextBox_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Consultas.devolverTabla("SELECT dbo.Diplomado_pagado.IdDiploPagado,dbo.Diplomado_pagado.IdDiplomado,dbo.Diplomado_pagado.IdPersonaRegistrada, dbo.Persona_Registrada.Identificacion, CONCAT( dbo.Persona_Registrada.PNombre,' ',dbo.Persona_Registrada.SNombre,' ', dbo.Persona_Registrada.PApellido,' ', dbo.Persona_Registrada.SApellido) as NombreCompleto,  dbo.Diplomados.NombreDiplomado, dbo.Diplomado_pagado.Observacion FROM            dbo.Diplomado_pagado INNER JOIN dbo.Persona_Registrada ON dbo.Diplomado_pagado.IdPersonaRegistrada = dbo.Persona_Registrada.IdPersonaRegistrada INNER JOIN dbo.Diplomados ON dbo.Diplomado_pagado.IdDiploPagado = dbo.Diplomados.NumDiplomado where dbo.Diplomado_pagado.Estado is null and (Identificacion like '%" + BuscarTextBox.Text + "%' or dbo.Persona_Registrada.PNombre like '%" + BuscarTextBox.Text + "%' or dbo.Persona_Registrada.SNombre like '%" + BuscarTextBox.Text + "%'or dbo.Persona_Registrada.PApellido like '%" + BuscarTextBox.Text + "%' or dbo.Persona_Registrada.SApellido like '%" + BuscarTextBox.Text + "%')");
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
        }

        private void CertificarButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Esta seguro que el estudiante " + dataGridView1.CurrentRow.Cells[4].Value.ToString() + " con la cedula " + dataGridView1.CurrentRow.Cells[3].Value.ToString() + " se Certificó ?", "ATENCION", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Consultas.HacerConsulta("update Diplomado_pagado set Estado = 'Certificado' where IdDiploPagado = " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "");
                Consultas.comando.ExecuteNonQuery();
                Consultas.HacerConsulta("insert into LibroActa (IdPersonaRegistrada,IdDiplomado,FechaCreated,NumConsecutivo,NumActa) "
                + "values (" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "," + dataGridView1.CurrentRow.Cells[1].Value.ToString() + ",'"+DateTime.Now.ToString("yyyy-MM-dd")+"',1,'hola')");
                Consultas.comando.ExecuteNonQuery();
                CargarTabla();
            }
        }
    }
}

