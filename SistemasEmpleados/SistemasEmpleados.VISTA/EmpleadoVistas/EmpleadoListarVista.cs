using SistemasEmpleados.BSS;
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
    public partial class EmpleadoListarVista : Form
    {
        public EmpleadoListarVista()
        {
            InitializeComponent();
        }
        EmpleadoBss bss = new EmpleadoBss();
        private void EmpleadoListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarEmpleadosBass();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmpleadoInsertarVista fr = new EmpleadoInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarEmpleadosBass();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IdEmpleadoSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            EmpleadoEditarVista fr = new EmpleadoEditarVista(IdEmpleadoSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarEmpleadosBass();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdEmpleadoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Estas Seguro de eliminar esta empleado?", "Eliminado", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarEmpleadoBss(IdEmpleadoSeleccionado);
                dataGridView1.DataSource = bss.ListarEmpleadosBass();
            }
        }
    }
}
