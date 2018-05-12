using System;
using System.Collections.Generic;
using TinderForWork.Classes;
using System.Data;
using System.Data.SqlClient;

namespace TinderForWork.Classes
{
    public partial class Match
    {
        public int EstAlumno { get; set; }
        public string Matricula { get; set; }
        public int ProyectoId { get; set; }
        public int MatchId { get; set; }

        public UsuarioInfo MatriculaNavigation { get; set; }
        public ProyectoInfo Proyecto { get; set; }

        public void GetMatch(byte UserProy, byte LikeNot)
        {
            try
            {
                SqlConnection sql = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=TinderForWorkDB;Integrated Security=True");
                sql.Open();

                SqlCommand cmd = sql.CreateCommand();
                cmd.CommandText = "BuscaMatch";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IDProyecto", this.ProyectoId);
                cmd.Parameters.AddWithValue("@Matricula", this.Matricula);

                cmd.ExecuteNonQuery();

                SqlDataReader reader = cmd.ExecuteReader();
                if (!reader.Read())
                    MatchId = 0;
                while (reader.Read())
                {
                    this.MatchId = Convert.ToInt32((reader["MatchID"].ToString()));
                    this.EstAlumno = Convert.ToInt32(reader["EstAlumno"].ToString());                    
                }

                reader.Close();
                sql.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            if (MatchId == 0)
            {
                if (UserProy == 1)
                {
                    if (LikeNot == 1)
                    {
                        EstAlumno = 5;
                    }
                    else
                    {
                        EstAlumno = 4;
                    }
                }
                else
                {
                    if (LikeNot == 1)
                    {
                        EstAlumno = 8;
                    }
                    else
                    {
                        EstAlumno = 10;
                    }
                }
                try
                {

                    SqlConnection sql = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=TinderForWorkDB;Integrated Security=True");
                    sql.Open();

                    SqlCommand cmd = sql.CreateCommand();
                    cmd.CommandText = "InsertMatch";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Matricula", this.Matricula);
                    cmd.Parameters.AddWithValue("@IDProyecto", this.ProyectoId);
                    cmd.Parameters.AddWithValue("@EstadoMatch", this.EstAlumno);

                    cmd.ExecuteNonQuery();
                    sql.Close();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SQL Error" + ex.Message.ToString());
                }
            }
        }

        public void UpdateMatch(byte UserProy, byte LikeNot)
        {
            if (UserProy == 1)
            {
                if (LikeNot == 1)
                {
                    if (EstAlumno != 5)
                    {
                        EstAlumno += 5;
                    }
                }
                else
                {
                    if (EstAlumno != 4)
                    {
                        EstAlumno += 4;
                    }
                }
            } else if (UserProy == 0)
            {
                if (LikeNot == 1)
                {
                    if (EstAlumno != 10)
                    {
                        EstAlumno += 10;
                    }
                }
                else
                {
                    if (EstAlumno != 8)
                    {
                        EstAlumno += 8;
                    }
                }
            }
            try
            {

                SqlConnection sql = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=TinderForWorkDB;Integrated Security=True");
                sql.Open();

                SqlCommand cmd = sql.CreateCommand();
                cmd.CommandText = "UpdateMatch";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MatchId", this.MatchId);
                cmd.Parameters.AddWithValue("@newState", this.EstAlumno);

                cmd.ExecuteNonQuery();
                sql.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
        }

    }
}
