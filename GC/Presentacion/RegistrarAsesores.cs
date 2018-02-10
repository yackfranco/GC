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
    public partial class RegistrarAsesores : Form
    {
        public RegistrarAsesores()
        {
            InitializeComponent();
        }
        public string accion = "";
        public string generarNumero()
        {
            Random r = new Random();
            string num1 = r.Next(1,10).ToString();
            string num2 = r.Next(1, 10).ToString();
            string num3 = r.Next(1, 10).ToString();
            string num4 = r.Next(1, 10).ToString();
            return num1 + num2 + num3 + num4;
        }
        public void NewOrUpdate(string boton)
        {
            NuevoButton.Enabled = false;
            GuardarButton.Enabled = true;
            CancelarButton.Enabled = true;
            EditarButton.Enabled = false;
            EliminarButton.Enabled = false;
            BuscarButton.Enabled = false;

            if (boton == "nuevo")
            {
                accion = "nuevo";
                panelDatos2.Enabled = true;
                panelDatos3.Enabled = true;
                LimpiarCampos();
                Boolean log = true;
                string cod = "";
                while (log)
                {
                    log = true;
                    cod = generarNumero();
                    if (Consultas.devolverUnEntero("select count(*) as n from Asesores where CodAsesor = " + cod + "") > 0)
                        log = true;
                    else
                        log = false;
                }
                CodigoAsesorTextBox.Text = cod;
            }
            else
            {
                accion = "editar";
                panelDatos2.Enabled = true;
                panelDatos3.Enabled = true;
                CodigoAsesorTextBox.Enabled = false;
            }
        }

        public void LimpiarCampos()
        {
            GeneroComboBox.Text = GeneroComboBox.Items[0].ToString();
            CodigoAsesorTextBox.Text = "";
            foreach (Control item in panelDatos2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                    item.Enabled = true;
                }
            }
            foreach (Control item in panelDatos3.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                    item.Enabled = true;
                }
            }
        }

        private void RegistrarAsesores_Load(object sender, EventArgs e)
        {

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            NewOrUpdate("nuevo");
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            NuevoButton.Enabled = true;
            GuardarButton.Enabled = false;
            CancelarButton.Enabled = false;
            EditarButton.Enabled = false;
            EliminarButton.Enabled = false;
            BuscarButton.Enabled = true;
            panelDatos2.Enabled = false;
            panelDatos3.Enabled = false;
            LimpiarCampos();
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            NewOrUpdate("editar");
        }


        public Boolean validarCampos()
        {
            if (PrimerNombreTextBox.Text == string.Empty)
            {
                MessageBox.Show("Debe Agregar el Primer Nombre del Asesor");
                return false;
            }
            if (PrimerApellidoTextBox.Text == string.Empty)
            {
                MessageBox.Show("Debe Agregar el Primer Apellido del Asesor");
                return false;
            }
            if (IdentificacionTextBox.Text == string.Empty)
            {
                MessageBox.Show("Debe Agregar el Numero de Indentificacion del Asesor");
                return false;
            }
            if (PaisTextBox.Text == string.Empty)
            {
                MessageBox.Show("Debe Agregar el Pais de Recidencia del Asesor");
                return false;
            }
            if (CiudadTextBox.Text == string.Empty)
            {
                MessageBox.Show("Debe Agregar la ciudad de recidencia del Asesor");
                return false;
            }
            if (DireccionTextBox.Text == string.Empty)
            {
                MessageBox.Show("Debe Agregar la direccion de recidencia del Asesor");
                return false;
            }
            if (celular1TextBox.Text == string.Empty)
            {
                MessageBox.Show("Debe Agregar el Numero de Celular 1 del Asesor");
                return false;
            }
            if (CorreoTextBox.Text == string.Empty)
            {
                MessageBox.Show("Debe Agregar el Correo Electronico del Asesor");
                return false;
            }
            return true;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Se validan los campos
                if(!validarCampos())
                {
                    return;
                }
                if (accion == "nuevo")
                {
                    if (Consultas.devolverUnEntero("select count(Identificacion) as n from Asesores where Identificacion = "+IdentificacionTextBox.Text+"") != 0)
                    {
                        MessageBox.Show("la cedula Ya se encuentra Registrada en la Base de Datos","ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Consultas.HacerConsulta("insert into Asesores (CodAsesor,genero,PNombre,SNombre,PApellido,SApellido,Identificacion,Pais,Ciudad,Direccion,Celular1,Celular2,Correo) values ("+CodigoAsesorTextBox.Text+",'"+GeneroComboBox.Text+"','"+PrimerNombreTextBox.Text+"','"+SegundoNombreTextBox.Text+"','"+PrimerApellidoTextBox.Text+"','"+SegundoApellidoTextBox.Text+"','"+IdentificacionTextBox.Text+"','"+PaisTextBox.Text+"','"+CiudadTextBox.Text+"','"+DireccionTextBox.Text+"','"+celular1TextBox.Text+"','"+Celular2TextBox.Text+"','"+CorreoTextBox.Text+"');");
                    Consultas.comando.ExecuteNonQuery();
                    MessageBox.Show("Se ha Creado El Asesor Correctamente","Felicitaciones",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    Consultas.HacerConsulta("update Asesores set genero = '"+GeneroComboBox.Text+"', PNombre = '"+PrimerNombreTextBox.Text+"', SNombre = '"+SegundoNombreTextBox.Text+"', PApellido = '"+PrimerApellidoTextBox.Text+"', SApellido = '"+SegundoApellidoTextBox.Text+"', Identificacion = '"+IdentificacionTextBox.Text+"', Pais = '"+PaisTextBox.Text+"', Ciudad = '"+CiudadTextBox.Text+"', Direccion = '"+DireccionTextBox.Text+"', Celular1 = '"+celular1TextBox.Text+"', Celular2 = '"+Celular2TextBox.Text+"', Correo = '"+CorreoTextBox.Text+"' where CodAsesor = '"+CodigoAsesorTextBox.Text+"'");
                    Consultas.comando.ExecuteNonQuery();
                    MessageBox.Show("Se ha Modificado El Asesor Correctamente", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
         
                panelDatos2.Enabled = false;
                panelDatos3.Enabled = false;
                CancelarButton_Click(sender,e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en Registrar Asesores......" + ex);
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            BuscarAsesor ba = new BuscarAsesor();
            ba.ShowDialog();
            Consultas.HacerConsulta("select * from Asesores where CodAsesor = '"+Variables.codigoAsesor+"'");
            Consultas.lector = Consultas.comando.ExecuteReader();
            while(Consultas.lector.Read())
            {
                CodigoAsesorTextBox.Text = Consultas.lector["CodAsesor"].ToString();
                PrimerNombreTextBox.Text = Consultas.lector["PNombre"].ToString();
                SegundoNombreTextBox.Text = Consultas.lector["SNombre"].ToString();
                PrimerApellidoTextBox.Text = Consultas.lector["PApellido"].ToString();
                SegundoApellidoTextBox.Text = Consultas.lector["SApellido"].ToString();
                IdentificacionTextBox.Text = Consultas.lector["Identificacion"].ToString();
                PaisTextBox.Text = Consultas.lector["Pais"].ToString();
                CiudadTextBox.Text = Consultas.lector["Ciudad"].ToString();
                DireccionTextBox.Text = Consultas.lector["Direccion"].ToString();
                celular1TextBox.Text = Consultas.lector["Celular1"].ToString();
                Celular2TextBox.Text = Consultas.lector["Celular2"].ToString();
                CorreoTextBox.Text = Consultas.lector["Correo"].ToString();
            }
            NuevoButton.Enabled = false;
            CancelarButton.Enabled = true;
            EditarButton.Enabled = true;
            EliminarButton.Enabled = true;
            BuscarButton.Enabled = false;
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta usted seguro que desea Eliminar el Sesor de Codigo " + CodigoAsesorTextBox.Text + "\n llamado " + PrimerNombreTextBox.Text + " "+SegundoNombreTextBox.Text+" "+PrimerApellidoTextBox.Text+" "+SegundoApellidoTextBox.Text+"", "¡ CUIDADO !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Consultas.HacerConsulta("delete from Asesores where CodAsesor = "+CodigoAsesorTextBox.Text+"");
                Consultas.comando.ExecuteNonQuery();
                CancelarButton_Click(sender,e);
            }
        }
    }
}
