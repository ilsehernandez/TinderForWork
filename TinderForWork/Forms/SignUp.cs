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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            UsuarioInfo user = new UsuarioInfo();
            user.Matricula = TextBoxMatricula.Text;
            user.Nombre = TextBoxNombre.Text;
            user.ApellidoP = TextBoxApp.Text;
            user.ApellidoM = TextBoxApm.Text;
            user.Campus = TextBoxCampus.Text;
            user.Carrera = Convert.ToInt32(TextBoxCarrera.Text);
            user.Contrasena = TextBoxContra.Text;
            user.StatusOcupado = checkBoxStatus.Checked;
            user.Correo = TextBoxCorreo.Text;
            user.Telefono = TextBoxTelefono.Text;

            UsuarioInfo.ConexionUsuario(user);

        }
    }
}
