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
    public partial class Matching : Form
    {
        string matricula;
        List<ProyectoInfo> proyectos;
        int ind = 0;
        public Matching(string mat)
        {
            InitializeComponent();
            matricula = mat;
            proyectos = ProyectoInfo.NextProy(dataGridView1, 0, matricula);
            label1.Text = proyectos[ind].Matricula;
            label2.Text = proyectos[ind].Matricula;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender == AñadirProyecto)
            {
                NuevoProyecto VentanaProyecto = new NuevoProyecto(matricula);
                VentanaProyecto.Show();
            }
            else if (sender == Like)
            {
                if (ind < proyectos.Count&&proyectos.Count!=0)
                {
                    label1.Text = proyectos[ind].Matricula;
                    label2.Text = proyectos[ind].Matricula;
                    ind++;
                }
            }
        }

        private void Matching_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
