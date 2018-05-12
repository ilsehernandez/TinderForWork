using System;
using System.Collections.Generic;
using TinderForWork.Classes;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace TinderForWork.Classes
{
    public partial class ProyectoInfo
    {
        public ProyectoInfo()
        {
            Experiencia = new HashSet<Experiencia>();
            HabilidadesReqProyecto = new HashSet<HabilidadesReqProyecto>();
            Match = new HashSet<Match>();
        }

        public int ProyectoId { get; set; }
        public int HorasTrabajo { get; set; }
        public string NombreProyecto { get; set; }
        public string Descripcion { get; set; }
        public string Campo { get; set; }
        public string Matricula { get; set; }
        public bool StatusProyect { get; set; }

        public HorasServicioDadas HorasServicioDadas { get; set; }
        public PagoProj PagoProj { get; set; }
        public ICollection<Experiencia> Experiencia { get; set; }
        public ICollection<HabilidadesReqProyecto> HabilidadesReqProyecto { get; set; }
        public ICollection<Match> Match { get; set; }

        public static void NuevoProyecto(ProyectoInfo proyecto)
        {
            try
            {

                SqlConnection sql = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=TinderForWorkDB;Integrated Security=True");
                sql.Open();

                SqlCommand cmd = sql.CreateCommand();
                cmd.CommandText = "InsertProject";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@HorasTrabajo", proyecto.HorasTrabajo);
                cmd.Parameters.AddWithValue("@NombreProyecto", proyecto.NombreProyecto);
                cmd.Parameters.AddWithValue("@Descripcion", proyecto.Descripcion);
                cmd.Parameters.AddWithValue("@Campo", proyecto.Campo);
                cmd.Parameters.AddWithValue("@Matricula", proyecto.Matricula);


                cmd.ExecuteNonQuery();
                sql.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
        }

        public static List<ProyectoInfo> NextProy(int index, string mat)
        {
            List<ProyectoInfo> list = new List<ProyectoInfo>();
            SqlConnection connection = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=TinderForWorkDB;Integrated Security=True");
            connection.Open();
            {

                SqlCommand cmd = connection.CreateCommand();
                DataTable Data = new DataTable();
                cmd.CommandText = "ViewPossibleProjects";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Matricula", mat);


                cmd.ExecuteNonQuery();

                SqlDataReader dataReader = cmd.ExecuteReader();

                
                while (dataReader.Read())
                {
                    ProyectoInfo temp = new ProyectoInfo();
                    // dataReader.Read();
                    temp.ProyectoId = Convert.ToInt32(dataReader["ProyectoID"].ToString());
                    temp.HorasTrabajo = Convert.ToInt32(dataReader["HorasTrabajo"].ToString());
                    temp.NombreProyecto = dataReader["NombreProyecto"].ToString();
                    temp.Descripcion = dataReader["Descripcion"].ToString();
                    temp.Campo = dataReader["Campo"].ToString();
                    //temp.StatusProyect = Convert.ToBoolean(Convert.ToInt32(dataReader["Activo"].ToString()));
                    temp.Matricula = dataReader["Matricula"].ToString();
                    list.Add(temp);
                    //dataReader.NextResult();
                }

                /*else
                {
                    index = 0;
                }*/
                dataReader.Close();
                connection.Close();
                return list;


            }
        }
    }
}




