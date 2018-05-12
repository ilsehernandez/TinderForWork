using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinderForWork.Forms;
using System.Data.SqlClient;

namespace TinderForWork
{
    public partial class Form1 : Form
    {
        bool login = false;
        string mat;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection sql = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=TinderForWorkDB;Integrated Security=True");
                sql.Open();

                SqlCommand cmd = sql.CreateCommand();
                cmd.CommandText = "InicioSesion";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Matricula", TextBoxMatriculaLog.Text);
                cmd.Parameters.AddWithValue("@Contrasena", TextBoxContraLog.Text);
                
                cmd.ExecuteNonQuery();

                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    if (dataReader["YESNO"].ToString() == "1")
                        login = true;

                }

                dataReader.Close();
                sql.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            if (login)
            {
                mat = TextBoxMatriculaLog.Text;
                Matching VentanaMatches = new Matching(mat);
                VentanaMatches.ShowDialog();
                Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp VentanaSignUp = new SignUp();
            VentanaSignUp.ShowDialog();
        }
    }
}
