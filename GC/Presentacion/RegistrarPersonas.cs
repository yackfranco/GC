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
    public partial class RegistrarPersonas : Form
    {
        public RegistrarPersonas()
        {
            InitializeComponent();
        }
        string accion = "";
        public void NewOrUpdate(string boton)
        {
            NuevoButton.Enabled = false;
            GuardarButton.Enabled = true;
            CancelarButton.Enabled = true;
            EditarButton.Enabled = false;
            EliminarButton.Enabled = false;
            BuscarButton.Enabled = false;
            IdentificacionTextBox.Focus();
            if (boton == "nuevo")
            {
                accion = "nuevo";
                panelDatos2.Enabled = true;
                panelDatos3.Enabled = true;
                LimpiarCampos();
            }
            else
            {
                accion = "editar";
                panelDatos2.Enabled = true;
                panelDatos3.Enabled = true;
            }
        }

        public void LimpiarCampos()
        {
            GeneroComboBox.Text = GeneroComboBox.Items[0].ToString();
            
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

        private void CorreoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Se validan los campos
                if (!validarCampos())
                {
                    return;
                }
                if (accion == "nuevo")
                {
                    if (Consultas.devolverUnEntero("select count(Identificacion) as n from Persona_Registrada where Identificacion = " + IdentificacionTextBox.Text + "") != 0)
                    {
                        MessageBox.Show("la cedula Ya se encuentra Registrada en la Base de Datos", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Consultas.HacerConsulta("insert into Persona_Registrada (genero,PNombre,SNombre,PApellido,SApellido,Identificacion,Pais,Ciudad,Direccion,Telefono,Correo,Estado) values ('" + GeneroComboBox.Text + "','" + PrimerNombreTextBox.Text + "','" + SegundoNombreTextBox.Text + "','" + PrimerApellidoTextBox.Text + "','" + SegundoApellidoTextBox.Text + "','" + IdentificacionTextBox.Text + "','" + PaisTextBox.Text + "','" + CiudadTextBox.Text + "','" + DireccionTextBox.Text + "','" + celular1TextBox.Text + "','" + CorreoTextBox.Text + "','"+EstadoComboBox.Text+"');");
                    Consultas.comando.ExecuteNonQuery();
                    MessageBox.Show("Se ha Creado El Asesor Correctamente", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Consultas.HacerConsulta("update Persona_Registrada set genero = '" + GeneroComboBox.Text + "', PNombre = '" + PrimerNombreTextBox.Text + "', SNombre = '" + SegundoNombreTextBox.Text + "', PApellido = '" + PrimerApellidoTextBox.Text + "', SApellido = '" + SegundoApellidoTextBox.Text + "', Pais = '" + PaisTextBox.Text + "', Ciudad = '" + CiudadTextBox.Text + "', Direccion = '" + DireccionTextBox.Text + "', Telefono = '" + celular1TextBox.Text + "', Correo = '" + CorreoTextBox.Text + "', Estado = '" + EstadoComboBox.Text + "' where  Identificacion = '" + IdentificacionTextBox.Text + "'");
                    Consultas.comando.ExecuteNonQuery();
                    MessageBox.Show("Se ha Modificado El Asesor Correctamente", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                panelDatos2.Enabled = false;
                panelDatos3.Enabled = false;
                CancelarButton_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en Registrar Asesores......" + ex);
            }
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

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta usted seguro que desea Eliminar La Persona Llamada = "+PrimerNombreTextBox.Text + " "+ PrimerApellidoTextBox.Text +"", "¡ CUIDADO !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Consultas.HacerConsulta("delete from Persona_Registrada where Identificacion = " + IdentificacionTextBox.Text+ "");
                Consultas.comando.ExecuteNonQuery();
                CancelarButton_Click(sender, e);
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            BuscarPersona ba = new BuscarPersona();
            ba.ShowDialog();
            Consultas.HacerConsulta("select * from Persona_Registrada where Identificacion = '" + Variables.identPersona + "'");
            Consultas.lector = Consultas.comando.ExecuteReader();
            while (Consultas.lector.Read())
            {
                PrimerNombreTextBox.Text = Consultas.lector["PNombre"].ToString();
                SegundoNombreTextBox.Text = Consultas.lector["SNombre"].ToString();
                PrimerApellidoTextBox.Text = Consultas.lector["PApellido"].ToString();
                SegundoApellidoTextBox.Text = Consultas.lector["SApellido"].ToString();
                IdentificacionTextBox.Text = Consultas.lector["Identificacion"].ToString();
                PaisTextBox.Text = Consultas.lector["Pais"].ToString();
                CiudadTextBox.Text = Consultas.lector["Ciudad"].ToString();
                DireccionTextBox.Text = Consultas.lector["Direccion"].ToString();
                celular1TextBox.Text = Consultas.lector["Telefono"].ToString();
                CorreoTextBox.Text = Consultas.lector["Correo"].ToString();
            }
            NuevoButton.Enabled = false;
            CancelarButton.Enabled = true;
            EditarButton.Enabled = true;
            EliminarButton.Enabled = true;
            BuscarButton.Enabled = false;
        }
    }
}
