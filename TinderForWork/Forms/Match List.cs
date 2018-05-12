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

namespace TinderForWork.Forms
{
    public partial class Match_List : Form
    {
        public Match_List(string matricula)
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=TinderForWorkDB;Integrated Security=True");
            connection.Open();
            {

                SqlCommand cmd = connection.CreateCommand();
                DataTable Data = new DataTable();
                cmd.CommandText = "MatchDoneUser";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Matricula", matricula);


                cmd.ExecuteNonQuery();

                SqlDataReader dataReader = cmd.ExecuteReader();


                while (dataReader.Read())
                {
                    ListaNombre.Items.Add(dataReader["NombreProyecto"].ToString());
                    ListaTelefono.Items.Add(dataReader["Telefono"].ToString());
                    ListaCorreo.Items.Add(dataReader["Correo"].ToString());

                }

                dataReader.Close();
                connection.Close();
            }
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
