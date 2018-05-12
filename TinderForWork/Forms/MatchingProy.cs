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
    public partial class MatchingProy : Form
    {
        string matricula;
        int IDProj;
        Match match;
        int ind=0;
        public MatchingProy(string mat, int projID)
        {
            InitializeComponent();
            matricula = mat;
            IDProj = projID;
            match = new Match();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender == AñadirProyecto)
            {
                NuevoProyecto VentanaProyecto = new NuevoProyecto(matricula);
                VentanaProyecto.Show();
            }
            else if (sender == VerComoProyecto)
            {
                Seleccion_Proyecto VentanaDeProyecto = new Seleccion_Proyecto(matricula);
                VentanaDeProyecto.ShowDialog();
                Close();
            }
            else if (sender == VerComoUsuario)
            {
                Matching matching = new Matching(matricula);
                matching.ShowDialog();
                Close();
            }
            else
            {
                try
                {
                    match.Matricula = "A00759898";
                    match.ProyectoId = IDProj;
                    if (sender == Like)
                    {
                        match.GetMatch(0, 1);
                        match.UpdateMatch(0, 1);
                        //UpdateLabelsProjects();
                    }
                    else if (sender == Dislike)
                    {
                        match.GetMatch(0, 0);
                        match.UpdateMatch(0, 0);
                       // UpdateLabelsProjects();
                    }
                    else if (sender == SuperLike)
                    {
                        match.GetMatch(0, 1);
                        match.UpdateMatch(0,1);
                        //UpdateLabelsProjects();
                    }
                    ind++;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    lblNoMas.Text = "Se han acabado los proyectos";
                }
            }
        }

        private void Matching_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*private void UpdateLabelsProjects()
        {
            lblName.Text = "Nombre: " + proyectos[ind].NombreProyecto;
            lblDescripcion.Text = "Descripcion: " + proyectos[ind].Descripcion;
            lblHorasTrabajo.Text = "Horas Esperadas de Trabajo: " + proyectos[ind].HorasTrabajo;
            lblCampo.Text = "Campo: " + proyectos[ind].Campo;
        }*/

        private void BotonMatches_Click(object sender, EventArgs e)
        {
            Match_List VentanaMatches = new Match_List(matricula);
            VentanaMatches.Show();
        }

        private void Like_Click(object sender, EventArgs e) { }
    }
}
