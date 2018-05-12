using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TinderForWork.Classes;

namespace TinderForWork.Forms
{
    public partial class Seleccion_Proyecto : Form
    {
        string mat;
        List<ProyectoInfo> proyectos;

        public Seleccion_Proyecto(string matricula)
        {
            InitializeComponent();
            proyectos = new List<ProyectoInfo>();
            mat = matricula;
            SqlConnection connection = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=TinderForWorkDB;Integrated Security=True");
            connection.Open();
            {
                SqlCommand cmd = connection.CreateCommand();
                DataTable Data = new DataTable();
                cmd.CommandText = "ViewOwnedProjects";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Matricula", mat);


                cmd.ExecuteNonQuery();

                SqlDataReader dataReader = cmd.ExecuteReader();


                while (dataReader.Read())
                {
                    ProyectoInfo temp = new ProyectoInfo();
                    temp.NombreProyecto = dataReader["NombreProyecto"].ToString();
                    temp.ProyectoId = Convert.ToInt32(dataReader["ProyectoID"].ToString());
                    ListaProyectos.Items.Add(dataReader["NombreProyecto"].ToString());
                    proyectos.Add(temp);
                }

                dataReader.Close();
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender == button1)
            {
                MatchingProy matchingProy = new MatchingProy(mat, proyectos[ListaProyectos.SelectedIndex].ProyectoId);
                matchingProy.ShowDialog();
                Close();
            }
        }
    }
}
