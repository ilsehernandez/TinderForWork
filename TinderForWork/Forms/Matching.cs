﻿using System;
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
        Match match = new Match();

        public Matching(string mat)
        {
            InitializeComponent();
            matricula = mat;
            proyectos = ProyectoInfo.NextProy(0, matricula);
            UpdateLabelsProjects();
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
            else if (sender == BotonMatches)
            {
                Match_List match_List = new Match_List(matricula);
                match_List.ShowDialog();
                Close();
            }
            else
            {
                try
                {
                    match.Matricula = matricula;
                    match.ProyectoId = proyectos[ind].ProyectoId;
                    if (sender == Like)
                    {
                        match.GetMatch(1, 1);
                        match.UpdateMatch(1, 1);
                        UpdateLabelsProjects();
                    }
                    else if (sender == Dislike)
                    {
                        match.GetMatch(1, 0);
                        match.UpdateMatch(1, 0);
                        UpdateLabelsProjects();
                    }
                    else if (sender == SuperLike)
                    {
                        match.GetMatch(1, 1);
                        match.UpdateMatch(1, 1);
                        UpdateLabelsProjects();
                    }
                    ind++;
                }
                catch(ArgumentOutOfRangeException ex)
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

        private void UpdateLabelsProjects()
        {
            lblName.Text = "Nombre: "+proyectos[ind].NombreProyecto;
            lblDescripcion.Text = "Descripcion: " + proyectos[ind].Descripcion;
            lblHorasTrabajo.Text = "Horas Esperadas de Trabajo: " + proyectos[ind].HorasTrabajo;
            lblCampo.Text = "Campo: " + proyectos[ind].Campo;
        }

        private void BotonMatches_Click(object sender, EventArgs e)
        {
        }
    }
}
