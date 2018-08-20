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
    public partial class Liquidar_Asesores : Form
    {
        public Liquidar_Asesores()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        double LimiteVentas = 0;
        private void Liquidar_Asesores_Load(object sender, EventArgs e)
        {
            LimiteVentas = Convert.ToDouble(Consultas.DevolverUnString("select RangoPago as n from configurar"));
            Cargartablas();
        }

        public void Cargartablas()
        {


            Consultas.HacerConsulta("SELECT        dbo.Asesores.Identificacion, dbo.Asesores.CodAsesor, CONCAT(dbo.Asesores.PNombre,' ',dbo.Asesores.SNombre ,' ', dbo.Asesores.PApellido,' ',dbo.Asesores.SApellido) as NombreAsesor , SUM(dbo.Diplomado_pagado.ValorDiplomado) AS Vendido, SUM(dbo.Diplomado_pagado.ComisionAsesor) as comision FROM            dbo.Asesores INNER JOIN dbo.Diplomado_pagado ON dbo.Asesores.CodAsesor = dbo.Diplomado_pagado.CodigoAsesor WHERE        (dbo.Diplomado_pagado.estadoLiquidacion IS NULL) GROUP BY dbo.Asesores.Identificacion, dbo.Asesores.CodAsesor, dbo.Asesores.PNombre, dbo.Asesores.PApellido, dbo.Asesores.SNombre, dbo.Asesores.SApellido");
            Consultas.lector = Consultas.comando.ExecuteReader();
            while (Consultas.lector.Read())
            {
                string nombre = Consultas.lector["NombreAsesor"].ToString();
                string identificacion = Consultas.lector["Identificacion"].ToString();
                string CodAsesor = Consultas.lector["CodAsesor"].ToString();
                double Vendido = Convert.ToDouble(Consultas.lector["Vendido"].ToString());
                double comision = Convert.ToDouble(Consultas.lector["comision"].ToString());
                if (Vendido >= LimiteVentas)
                {
                    dataGridViewLiquidar.Rows.Add(identificacion,CodAsesor,nombre,Vendido,comision);
                }
                else
                {
                    dataGridViewTodos.Rows.Add(identificacion, CodAsesor, nombre, Vendido,comision);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewLiquidar.Rows.Count > 0)
            {
                Datos.Variables.codigoAsesor = dataGridViewLiquidar.CurrentRow.Cells[1].Value.ToString();
                Datos.Variables.nombreAsesor = dataGridViewLiquidar.CurrentRow.Cells[2].Value.ToString();
                VerDetallesAsesor vda = new VerDetallesAsesor();
                vda.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningun Asesor");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridViewTodos.Rows.Count > 0)
            {
                Datos.Variables.codigoAsesor = dataGridViewTodos.CurrentRow.Cells[1].Value.ToString();
                Datos.Variables.nombreAsesor = dataGridViewTodos.CurrentRow.Cells[2].Value.ToString();
                VerDetallesAsesor vda = new VerDetallesAsesor();
                vda.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningun Asesor");
            }
        }

    }
}
