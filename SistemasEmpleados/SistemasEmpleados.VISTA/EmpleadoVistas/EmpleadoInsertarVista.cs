using SistemasEmpleados.BSS;
using SistemasEmpleados.MODELOS;
using SistemasEmpleados.VISTA.PersonaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasEmpleados.VISTA.EmpleadoVistas
{
    public partial class EmpleadoInsertarVista : Form
    {
        public EmpleadoInsertarVista()
        {
            InitializeComponent();
        }

        public static int IdPersonaSeleccionada = 0;
        PersonaBss bsspersona = new PersonaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bsspersona.ObtenerPersonaIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }
        }

        EmpleadoBss bss = new EmpleadoBss();
        private void button3_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.IdPersona = IdPersonaSeleccionada;
            empleado.Puesto = textBox2.Text;
            empleado.Salario = Convert.ToDecimal(textBox3.Text);
            empleado.FechadeContratacion = dateTimePicker1.Value;

            bss.InsertarEmpleadoBss(empleado);
            MessageBox.Show("Se guardo correctamente el Empleado");
        }
    }
}
