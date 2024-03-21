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
    public partial class EmpleadoEditarVista : Form
    {
        int idx = 0;
        Empleado empleado = new Empleado();
        EmpleadoBss bss = new EmpleadoBss();
        public EmpleadoEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void EmpleadoEditarVista_Load(object sender, EventArgs e)
        {
            empleado = bss.ObtenerEmpleadoIdBss(idx);
            textBox1.Text = Convert.ToString(empleado.IdPersona);
            textBox2.Text = empleado.Puesto;
            textBox3.Text = Convert.ToString(empleado.Salario);
            dateTimePicker1.Value = empleado.FechadeContratacion;
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

        private void button3_Click(object sender, EventArgs e)
        {
            empleado.IdPersona = IdPersonaSeleccionada;
            empleado.Puesto = textBox2.Text;
            empleado.Salario = Convert.ToDecimal(textBox3.Text);
            empleado.FechadeContratacion = dateTimePicker1.Value;

            bss.EditarEmpleadoBss(empleado);
            MessageBox.Show("Datos Actualizados");
        }
    }
}
