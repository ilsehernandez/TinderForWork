﻿using System;
using System.Collections.Generic;
using TinderForWork.Classes;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;

namespace TinderForWork.Classes
{
    public partial class UsuarioInfo
    {
        public UsuarioInfo()
        {
            Experiencia = new HashSet<Experiencia>();
            HabilidadesUsuario = new HashSet<HabilidadesUsuario>();
            Match = new HashSet<Match>();
            TarjetasUsuarios = new HashSet<TarjetasUsuarios>();
        }

        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string Contrasena { get; set; }
        public string Correo { get; set; }
        public int Carrera { get; set; }
        public string Campus { get; set; }
        public bool StatusOcupado { get; set; }
        public string Telefono { get; set; }

        public static void ConexionUsuario(UsuarioInfo user)
        {
            try
            {

                SqlConnection sql = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=TinderForWorkDB;Integrated Security=True");
                sql.Open();

                SqlCommand cmd = sql.CreateCommand();
                cmd.CommandText = "InsertUser";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Matricula", user.Matricula);
                cmd.Parameters.AddWithValue("@Nombre", user.Nombre);
                cmd.Parameters.AddWithValue("@ApellidoP", user.ApellidoP);
                cmd.Parameters.AddWithValue("@ApellidoM", user.ApellidoM);
                cmd.Parameters.AddWithValue("@Contrasena", user.Contrasena);
                cmd.Parameters.AddWithValue("@Correo", user.Correo);
                cmd.Parameters.AddWithValue("@Carrera", user.Carrera);
                cmd.Parameters.AddWithValue("@Campus", user.Campus);
                cmd.Parameters.AddWithValue("@StatusOcupado", user.StatusOcupado);
                cmd.Parameters.AddWithValue("@Telefono", user.Telefono);
                cmd.ExecuteNonQuery();
                sql.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
        }

        public ICollection<Experiencia> Experiencia { get; set; }
        public ICollection<HabilidadesUsuario> HabilidadesUsuario { get; set; }
        public ICollection<Match> Match { get; set; }
        public ICollection<TarjetasUsuarios> TarjetasUsuarios { get; set; }
    }
}
