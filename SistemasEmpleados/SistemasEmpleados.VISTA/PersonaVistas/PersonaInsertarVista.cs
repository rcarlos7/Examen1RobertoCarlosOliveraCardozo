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
    public partial class PersonaInsertarVista : Form
    {
        public PersonaInsertarVista()
        {
            InitializeComponent();
        }
        PersonaBss bss = new PersonaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = textBox1.Text;
            persona.Apellido = textBox2.Text;
            persona.Estado = textBox3.Text;

            bss.InsertarPersonaBss(persona);
            MessageBox.Show("Se guardo correctamente la persona");
        }
    }
}
