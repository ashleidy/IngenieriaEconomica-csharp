using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SERIES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btbanualidad_Click(object sender, EventArgs e)
        {
            anualidad ingreso = new anualidad();
            ingreso.Show();
        }

        private void btbanualidadA_Click(object sender, EventArgs e)
        {
            anualidad_anticipada ingreso = new anualidad_anticipada();
            ingreso.Show();
        }

        private void btbanualidadP_Click(object sender, EventArgs e)
        {
         
        }

        private void btbanualidadG_Click(object sender, EventArgs e)
        {

        }

        private void btbfinalizar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btbanualidadD_Click(object sender, EventArgs e)
        {
            anualidad_diferida ingreso = new anualidad_diferida();
            ingreso.Show();
        }

        private void anualidadP_Click(object sender, EventArgs e)
        {
            anualidad_perpetua ingreso = new anualidad_perpetua();
            ingreso.Show();
        }

        private void anualidadG_Click(object sender, EventArgs e)
        {

        }
    }
}
