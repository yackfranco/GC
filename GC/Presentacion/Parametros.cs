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
    public partial class Parametros : Form
    {
        public Parametros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Desea Guardar los Cambios ?", "GUARDAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (Consultas.devolverUnEntero("select count(*) as n from configurar") > 0)
                {
                    Consultas.HacerConsulta("update configurar set RangoPago = " + textBoxRangoPago.Text + ", ValorDiplomado=" + textBoxValorDiplomado.Text + ", primeraVenta="+textBoxComisionPrimeraVez.Text+", SegundaVenta="+textBoxComisionMasDeUnaVenta.Text+"");
                    Consultas.comando.ExecuteNonQuery();
                }
                else
                {
                    Consultas.HacerConsulta("insert into configurar (RangoPago,ValorDiplomado,primeraVenta, SegundaVenta) values (" + textBoxRangoPago.Text + ", " + textBoxValorDiplomado.Text + ", " + textBoxComisionPrimeraVez.Text + "," + textBoxComisionMasDeUnaVenta.Text + ")");
                    Consultas.comando.ExecuteNonQuery();
                }
            }
            this.Close();
        }

        private void Parametros_Load(object sender, EventArgs e)
        {
            Consultas.HacerConsulta("select * from configurar");
            Consultas.lector = Consultas.comando.ExecuteReader();
            while (Consultas.lector.Read())
            {
                textBoxRangoPago.Text = Consultas.lector["RangoPago"].ToString();
                textBoxValorDiplomado.Text = Consultas.lector["ValorDiplomado"].ToString();
                textBoxComisionPrimeraVez.Text = Consultas.lector["primeraVenta"].ToString();
                textBoxComisionMasDeUnaVenta.Text = Consultas.lector["SegundaVenta"].ToString();
            }
        }
    }
}
