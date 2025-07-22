using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRADIENTE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btbGAL_Click(object sender, EventArgs e)
        {
            gradiente_lineal ingreso = new gradiente_lineal();
            ingreso.Show();
        }

        private void btbGLD_Click(object sender, EventArgs e)
        {
            gradiente_decreciente ingreso = new gradiente_decreciente();
            ingreso.Show();
        }

        private void btbGGE_Click(object sender, EventArgs e)
        {
            gradiente_Gexponencial ingreso = new gradiente_Gexponencial();
            ingreso.Show();
        }

        private void btbGGD_Click(object sender, EventArgs e)
        {
            gradiente_Gdecreciente ingreso = new gradiente_Gdecreciente();
            ingreso.Show();
        }

        private void btbfinalizar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btbaritmetico_Click(object sender, EventArgs e)
        {
            gradiente_aritmetico ingreso = new gradiente_aritmetico();
            ingreso.Show();
        }

        private void btbperpetuo_Click(object sender, EventArgs e)
        {
            gradiente_perpetuo ingreso = new gradiente_perpetuo();
            ingreso.Show();
        }
    }
}
