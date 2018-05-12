using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinderForWork.Classes;

namespace TinderForWork.Forms
{
    public partial class NuevoProyecto : Form
    {
        string mat;

        public NuevoProyecto(string matricula)
        {
            InitializeComponent();
            mat = matricula;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender == button1)
            {
                ProyectoInfo proyecto = new ProyectoInfo();
                proyecto.Matricula = mat;
                proyecto.NombreProyecto = TextBoxTitulo.Text;
                proyecto.HorasTrabajo = Convert.ToInt32(TextBoxHorasTrabajo.Text);
                proyecto.Campo = TextBoxCampo.Text;
                proyecto.Descripcion = TextBoxDescripcion.Text;
                proyecto.StatusProyect = ChckEstadoProyecto.Checked;
                ProyectoInfo.NuevoProyecto(proyecto);
            }
            Close();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
