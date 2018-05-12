using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinderForWork.Forms
{
    public partial class Seleccion_Proyecto : Form
    {
        string mat;
        int IDProj=4;

        public Seleccion_Proyecto(string matricula)
        {
            InitializeComponent();
            mat = matricula;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender == button1)
            {
                MatchingProy matchingProy = new MatchingProy(mat, 4);
                matchingProy.ShowDialog();
                Close();
            }
        }
    }
}
