using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class VerDetallesAsesor : Form
    {
        public VerDetallesAsesor()
        {
            InitializeComponent();
        }

        private void VerDetallesAsesor_Load(object sender, EventArgs e)
        {
            labelNombreAsesor.Text = Datos.Variables.nombreAsesor;
            labelCodigoAsesor.Text += Datos.Variables.codigoAsesor;
            dataGridView1.DataSource = Consultas.devolverTabla("SELECT        dbo.Persona_Registrada.Identificacion, CONCAT(dbo.Persona_Registrada.PNombre, ' ',dbo.Persona_Registrada.SNombre, ' ', dbo.Persona_Registrada.PApellido,' ',  dbo.Persona_Registrada.SApellido) as NombreCliente , dbo.Diplomados.NombreDiplomado,  dbo.Diplomado_pagado.ValorDiplomado, dbo.Diplomado_pagado.ComisionAsesor, dbo.Diplomado_pagado.FechaPagoAsesor as FechaPagado FROM            dbo.Asesores INNER JOIN dbo.Diplomado_pagado ON dbo.Asesores.CodAsesor = dbo.Diplomado_pagado.CodigoAsesor INNER JOIN dbo.Persona_Registrada ON dbo.Diplomado_pagado.IdPersonaRegistrada = dbo.Persona_Registrada.IdPersonaRegistrada INNER JOIN dbo.Diplomados ON dbo.Diplomado_pagado.IdDiplomado = dbo.Diplomados.NumDiplomado WHERE        (dbo.Diplomado_pagado.estadoLiquidacion IS NULL) AND (dbo.Asesores.CodAsesor = "+Datos.Variables.codigoAsesor+")");
            double sumavalorDiplo = 0,sumaComisionAs = 0;
            for (int i = 0; i <dataGridView1.Rows.Count ; i++)
			{
			 sumavalorDiplo += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value.ToString());
                sumaComisionAs+= Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value.ToString());
			}
            labelValorDiplo.Text = sumavalorDiplo.ToString("C",new CultureInfo("es-CO"));
            labelComisionAsesor.Text = sumaComisionAs.ToString("C", new CultureInfo("es-CO"));
        }
    }
}
