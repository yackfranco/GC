using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Reporte1 : Form
    {
        public Reporte1()
        {
            InitializeComponent();
        }


        private void Reporte1_Load(object sender, EventArgs e)
        {
            // Nombre: Jesus Andres Gonzalez alarcon
            //Cedula: 1112791837
            //numero Acta : DI2018070180
            //Diplomado : INCLUSION EDUCATIVA EN LOS AMBIENTES DE APRENDIZAJE
            //Fecha : Julio 01 del 2018


        //     Dim pdfContent As Byte() = report.Render("PDF")

        //' Para exportar a Excel
        //' Dim excelContent as Byte() = report.Render("Excel")

        //' Generar el archivo PDF
        //Dim pdfPath As String = "C:\temp\report.pdf"
        //Dim pdfFile As New System.IO.FileStream(pdfPath, System.IO.FileMode.Create)
        //pdfFile.Write(pdfContent, 0, pdfContent.Length)
        //pdfFile.Close()

            //ReportViewer1.LocalReport.DisplayName = "Perro";

            //var fieldInfo = typeof(Microsoft.Reporting.WinForms.RenderingExtension).GetField("m_isVisible", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);

            //foreach (var extension in this.ReportViewer1.LocalReport.ListRenderingExtensions())
            //{
            //    fieldInfo.SetValue(extension, true);
            //}

            ReportParameter NombreCompleto = new ReportParameter("NombreCompleto", "Jesus Andres Gonzalez alarcon".ToUpper().Trim());
            ReportParameter Cedula = new ReportParameter("Cedula", "1112791837");
            ReportParameter NumeroActa = new ReportParameter("NumeroActa", " DI2018070180".ToUpper().Trim());
            ReportParameter Diplomado = new ReportParameter("Diplomado", " INCLUSION EDUCATIVA EN LOS AMBIENTES DE APRENDIZAJE ".ToUpper().Trim());
            ReportParameter Fecha = new ReportParameter("Fecha", " Julio 01 del 2018".Trim());
            this.ReportViewer1.LocalReport.SetParameters(new ReportParameter[] { NombreCompleto, Cedula, NumeroActa,Diplomado,Fecha });
            //this.ReportViewer1.RefreshReport();            
            this.ReportViewer1.RefreshReport();
            /* Download File.....*/
            
            
        }
             
        
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
