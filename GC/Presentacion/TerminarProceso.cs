using Datos;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
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
        string observacion="";
        private void TerminarProceso_Load(object sender, EventArgs e)
        {
            CargarTabla();
            this.reportViewer1.RefreshReport();
        }

        public void CargarTabla()
        {
            //"SELECT dbo.Diplomado_pagado.IdDiploPagado, dbo.Persona_Registrada.Identificacion, CONCAT( dbo.Persona_Registrada.PNombre,' ',dbo.Persona_Registrada.SNombre,' ', dbo.Persona_Registrada.PApellido,' ', dbo.Persona_Registrada.SApellido) as NombreCompleto,  dbo.Diplomados.NombreDiplomado, dbo.Diplomado_pagado.Observacion FROM            dbo.Diplomado_pagado INNER JOIN dbo.Persona_Registrada ON dbo.Diplomado_pagado.IdPersonaRegistrada = dbo.Persona_Registrada.IdPersonaRegistrada INNER JOIN dbo.Diplomados ON dbo.Diplomado_pagado.IdDiploPagado = dbo.Diplomados.NumDiplomado where dbo.Diplomado_pagado.Estado is null"

            //SELECT dbo.Diplomado_pagado.IdDiploPagado, dbo.Persona_Registrada.Identificacion, CONCAT( dbo.Persona_Registrada.PNombre,' ',dbo.Persona_Registrada.SNombre,' ', dbo.Persona_Registrada.PApellido,' ', dbo.Persona_Registrada.SApellido) as NombreCompleto,  dbo.Diplomados.NombreDiplomado, dbo.Diplomado_pagado.Observacion FROM            dbo.Diplomado_pagado INNER JOIN dbo.Persona_Registrada ON dbo.Diplomado_pagado.IdPersonaRegistrada = dbo.Persona_Registrada.IdPersonaRegistrada INNER JOIN dbo.Diplomados ON dbo.Diplomado_pagado.IdDiploPagado = dbo.Diplomados.NumDiplomado where dbo.Diplomado_pagado.Estado is null and (Identificacion like '%" + BuscarTextBox.Text + "%' or dbo.Persona_Registrada.PNombre like '%" + BuscarTextBox.Text + "%' or dbo.Persona_Registrada.SNombre like '%" + BuscarTextBox.Text + "%'or dbo.Persona_Registrada.PApellido like '%" + BuscarTextBox.Text + "%' or dbo.Persona_Registrada.SApellido like '%" + BuscarTextBox.Text + "%')
            
            //SELECT        dbo.Persona_Registrada.Identificacion,  CONCAT(dbo.Persona_Registrada.PNombre,' ',dbo.Persona_Registrada.SNombre,' ',dbo.Persona_Registrada.PApellido, ' ',dbo.Persona_Registrada.SApellido) as NombreCompleto,dbo.Diplomados.NombreDiplomado,  dbo.Diplomado_pagado.Observacion FROM            dbo.Diplomado_pagado INNER JOIN dbo.Diplomados ON dbo.Diplomado_pagado.IdDiplomado = dbo.Diplomados.NumDiplomado INNER JOIN dbo.Persona_Registrada ON dbo.Diplomado_pagado.IdPersonaRegistrada = dbo.Persona_Registrada.IdPersonaRegistrada
            
            //dataGridView1.DataSource = Consultas.devolverTabla("SELECT dbo.Diplomado_pagado.IdDiploPagado,dbo.Diplomado_pagado.IdDiplomado,dbo.Diplomado_pagado.IdPersonaRegistrada, dbo.Persona_Registrada.Identificacion, CONCAT( dbo.Persona_Registrada.PNombre,' ',dbo.Persona_Registrada.SNombre,' ', dbo.Persona_Registrada.PApellido,' ', dbo.Persona_Registrada.SApellido) as NombreCompleto,  dbo.Diplomados.NombreDiplomado, dbo.Diplomado_pagado.Observacion FROM            dbo.Diplomado_pagado INNER JOIN dbo.Persona_Registrada ON dbo.Diplomado_pagado.IdPersonaRegistrada = dbo.Persona_Registrada.IdPersonaRegistrada INNER JOIN dbo.Diplomados ON dbo.Diplomado_pagado.IdDiploPagado = dbo.Diplomados.NumDiplomado where dbo.Diplomado_pagado.Estado is null and (Identificacion like '%" + BuscarTextBox.Text + "%' or dbo.Persona_Registrada.PNombre like '%" + BuscarTextBox.Text + "%' or dbo.Persona_Registrada.SNombre like '%" + BuscarTextBox.Text + "%'or dbo.Persona_Registrada.PApellido like '%" + BuscarTextBox.Text + "%' or dbo.Persona_Registrada.SApellido like '%" + BuscarTextBox.Text + "%')");
            dataGridView1.DataSource = Consultas.devolverTabla("SELECT dbo.Diplomado_pagado.IdDiploPagado,dbo.Diplomado_pagado.IdDiplomado,dbo.Diplomado_pagado.IdPersonaRegistrada, dbo.Persona_Registrada.Identificacion,  CONCAT(dbo.Persona_Registrada.PNombre,' ',dbo.Persona_Registrada.SNombre,' ',dbo.Persona_Registrada.PApellido, ' ',dbo.Persona_Registrada.SApellido) as NombreCompleto,dbo.Diplomados.NombreDiplomado,  dbo.Diplomado_pagado.Observacion FROM            dbo.Diplomado_pagado INNER JOIN dbo.Diplomados ON dbo.Diplomado_pagado.IdDiplomado = dbo.Diplomados.NumDiplomado INNER JOIN dbo.Persona_Registrada ON dbo.Diplomado_pagado.IdPersonaRegistrada = dbo.Persona_Registrada.IdPersonaRegistrada where dbo.Diplomado_pagado.Estado is null and (Identificacion like '%" + BuscarTextBox.Text + "%' or dbo.Persona_Registrada.PNombre like '%" + BuscarTextBox.Text + "%' or dbo.Persona_Registrada.SNombre like '%" + BuscarTextBox.Text + "%'or dbo.Persona_Registrada.PApellido like '%" + BuscarTextBox.Text + "%' or dbo.Persona_Registrada.SApellido like '%" + BuscarTextBox.Text + "%')");
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
        }

        private void BuscarTextBox_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Consultas.devolverTabla("SELECT dbo.Diplomado_pagado.IdDiploPagado,dbo.Diplomado_pagado.IdDiplomado,dbo.Diplomado_pagado.IdPersonaRegistrada, dbo.Persona_Registrada.Identificacion,  CONCAT(dbo.Persona_Registrada.PNombre,' ',dbo.Persona_Registrada.SNombre,' ',dbo.Persona_Registrada.PApellido, ' ',dbo.Persona_Registrada.SApellido) as NombreCompleto,dbo.Diplomados.NombreDiplomado,  dbo.Diplomado_pagado.Observacion FROM            dbo.Diplomado_pagado INNER JOIN dbo.Diplomados ON dbo.Diplomado_pagado.IdDiplomado = dbo.Diplomados.NumDiplomado INNER JOIN dbo.Persona_Registrada ON dbo.Diplomado_pagado.IdPersonaRegistrada = dbo.Persona_Registrada.IdPersonaRegistrada where dbo.Diplomado_pagado.Estado is null and (Identificacion like '%" + BuscarTextBox.Text + "%' or dbo.Persona_Registrada.PNombre like '%" + BuscarTextBox.Text + "%' or dbo.Persona_Registrada.SNombre like '%" + BuscarTextBox.Text + "%'or dbo.Persona_Registrada.PApellido like '%" + BuscarTextBox.Text + "%' or dbo.Persona_Registrada.SApellido like '%" + BuscarTextBox.Text + "%')");
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
        }

        private void CertificarButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Esta seguro que el estudiante " + dataGridView1.CurrentRow.Cells[4].Value.ToString() + " con la cedula " + dataGridView1.CurrentRow.Cells[3].Value.ToString() + " se Certificó ?", "ATENCION", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    string NombreEstudiante = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    string cedulaEstudiante = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    string DiplomadoEstudiante = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    string idDiploPagado = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                    Consultas.HacerConsulta("update Diplomado_pagado set Estado = 'Certificado' , FechaEstado='" + DateTime.Now.ToString("yyyy-MM-dd") + "' where IdDiploPagado = " + idDiploPagado + "");
                    Consultas.comando.ExecuteNonQuery();

                    int UltimoNumActa = Consultas.devolverUnEntero("select Max(NumConsecutivo) as n from LibroActa");
                    if (UltimoNumActa == 0)
                        UltimoNumActa = Consultas.devolverUnEntero("select UltimoRegistro as n from UltimoRegistro") + 1;
                    else
                        UltimoNumActa++;

                    string NumActa = "DI" + Convert.ToDateTime(Consultas.DevolverUnString("select FechaEstado as n from Diplomado_pagado where IdDiploPagado = '" + idDiploPagado + "'")).ToString("ddMMyyyy") + UltimoNumActa;

                    int ultimoIdActa = Consultas.InsertDevovliendoId("insert into LibroActa (IdPersonaRegistrada,IdDiplomado,FechaCreated,NumConsecutivo,NumActa) "
                    + "values (" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "," + dataGridView1.CurrentRow.Cells[1].Value.ToString() + ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "',1,'" + NumActa + "')");

                    Consultas.HacerConsulta("update LibroActa set NumConsecutivo = " + (UltimoNumActa) + " where IdLibroActa = " + ultimoIdActa);
                    Consultas.comando.ExecuteNonQuery();

                    Consultas.HacerConsulta("update Diplomado_pagado set IdLibroActa = " + ultimoIdActa + " where IdDiploPagado = " + idDiploPagado);
                    Consultas.comando.ExecuteNonQuery();

                    ReportParameter NombreCompleto = new ReportParameter("NombreCompleto", NombreEstudiante.ToUpper().Trim());
                    ReportParameter Cedula = new ReportParameter("Cedula", cedulaEstudiante.ToString());
                    //ReportParameter NumeroActa = new ReportParameter("NumeroActa", " DI2018070180".ToUpper().Trim());
                    ReportParameter NumeroActa = new ReportParameter("NumeroActa", NumActa.ToUpper().Trim());
                    //ReportParameter Diplomado = new ReportParameter("Diplomado", " INCLUSION EDUCATIVA EN LOS AMBIENTES DE APRENDIZAJE ".ToUpper().Trim());
                    ReportParameter Diplomado = new ReportParameter("Diplomado", DiplomadoEstudiante.ToUpper().Trim());

                    string Mes = MonthName(DateTime.Now.Month);
                    string dia = DateTime.Now.ToString("dd");
                    string año = DateTime.Now.ToString("yyyy");
                    string fecha = Mes + " " + dia + " del " + año;

                    ReportParameter Fecha = new ReportParameter("Fecha", fecha.Trim());
                    this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { NombreCompleto, Cedula, NumeroActa, Diplomado, Fecha });

                    this.reportViewer1.RefreshReport();

                    byte[] pdfContent = reportViewer1.LocalReport.Render("PDF");

                    string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Diplomas_Grupo_Colombiano";

                    if (!Directory.Exists(path))
                    {
                        DirectoryInfo di = Directory.CreateDirectory(path);
                    }
                    // Generar el archivo PDF
                    string pdfPath = path + @"\" + cedulaEstudiante + "-" + NumActa + ".pdf";
                    System.IO.FileStream pdfFile = new System.IO.FileStream(pdfPath, System.IO.FileMode.Create);
                    pdfFile.Write(pdfContent, 0, pdfContent.Length);
                    pdfFile.Close();

                    CargarTabla();
                    notifyIcon1.Visible = true;
                    notifyIcon1.ShowBalloonTip(400);
                }
                catch (Exception)
                {
                    
                    throw;
                }
                
            }
        }
        public string MonthName(int month)
        {
            DateTimeFormatInfo dtinfo = new CultureInfo("es-ES", false).DateTimeFormat;
            return dtinfo.GetMonthName(month);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = false;
            observacion = "editar";
            textBox2.Text = Consultas.DevolverUnString("select Observacion as n from Diplomado_pagado where IdDiploPagado = " + dataGridView1.CurrentRow.Cells[0].Value.ToString());
            panel2.Visible = true;
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void funcionObservaciones()
        {
            if (observacion == "editar")
            {
           
                Consultas.HacerConsulta("update Diplomado_pagado set Observacion = '" + textBox2.Text + "' where IdDiploPagado = " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "");
                Consultas.comando.ExecuteNonQuery();
            }
            else if (observacion == "desertar")
            {
                Consultas.HacerConsulta("update Diplomado_pagado set Observacion = '" + textBox2.Text + "',Estado='Desertado',FechaEstado = '"+DateTime.Now.ToString("yyyy-MM-dd")+"' where IdDiploPagado = " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "");
                Consultas.comando.ExecuteNonQuery();
            }
            dataGridView1.Enabled = true;
            observacion = "";
            panel2.Visible = false;
            textBox2.Text = "";
            CargarTabla();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            funcionObservaciones();
        }

        private void DesertarButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = false;
            observacion = "desertar";
            textBox2.Text = Consultas.DevolverUnString("select Observacion as n from Diplomado_pagado where IdDiploPagado = " + dataGridView1.CurrentRow.Cells[0].Value.ToString());
            panel2.Visible = true;
           
        }

    }
}

