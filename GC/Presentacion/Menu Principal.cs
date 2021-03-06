﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string archivo = "";

        Funciones funcionesClass = new Funciones();

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        
        private void button6_Click(object sender, EventArgs e)
        {

            Reporte1 r = new Reporte1();
            r.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.ReportViewer1.RefreshReport();
        }

        private void registrarPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AceptarEstudiante ae = new AceptarEstudiante();
            ae.ShowDialog();
        }

        private void registrarDiplomadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarDiplomados rd = new RegistrarDiplomados();
            rd.ShowDialog();
        }

        private void registrarCursosGratuitosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarCursos rc = new RegistrarCursos();
            rc.ShowDialog();
        }

        private void registrarAsesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarAsesores ra = new RegistrarAsesores();
            ra.ShowDialog();
        }

        private void registrarPersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarPersonas rp = new RegistrarPersonas();
            rp.ShowDialog();
        }

        private void concluirProcesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TerminarProceso tp = new TerminarProceso();
            tp.ShowDialog();
        }

        private void actualizarBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas Actualizar Los Registros?", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx"; //le indicamos el tipo de filtro en este caso que busque
                dialog.Title = "Seleccione el archivo de Excel";//le damos un titulo a la ventana
                dialog.FileName = string.Empty;//inicializamos con vacio el nombre del archivo
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //el nombre del archivo sera asignado al textbox
                    archivo = dialog.FileName;
                    //hoja = txtHoja.Text; //la variable hoja tendra el valor del textbox donde colocamos el nombre de la hoja
                    //LLenarGrid(txtArchivo.Text, "H1"); //se manda a llamar al metodo

                    funcionesClass.actualizarBaseDatos(archivo,this);
                    //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //se ajustan las
                    //columnas al ancho del DataGridview para que no quede espacio en blanco (opcional)

                }
            }
        }

        private void liquidarAsesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Liquidar_Asesores la = new Liquidar_Asesores();
            la.ShowDialog();
        }

        private void configurarParametrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parametros pa = new Parametros();
            pa.ShowDialog();
        }
    }
}
