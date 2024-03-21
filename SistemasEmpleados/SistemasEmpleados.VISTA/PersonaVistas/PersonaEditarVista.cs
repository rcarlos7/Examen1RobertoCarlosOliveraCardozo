using SistemasEmpleados.BSS;
using SistemasEmpleados.MODELOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasEmpleados.VISTA.PersonaVistas
{
    public partial class PersonaEditarVista : Form
    {
        int idx = 0;
        Persona persona = new Persona();
        PersonaBss bss = new PersonaBss();
        public PersonaEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void PersonaEditarVista_Load(object sender, EventArgs e)
        {
            persona = bss.ObtenerPersonaIdBss(idx);
            textBox1.Text = persona.Nombre;
            textBox2.Text = persona.Apellido;
            textBox3.Text = persona.Estado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            persona.Nombre = textBox1.Text;
            persona.Apellido = textBox2.Text;
            persona.Estado = textBox3.Text;

            bss.EditarPersonaBss(persona);
            MessageBox.Show("Datos Actualizados");
        }
    }
}
