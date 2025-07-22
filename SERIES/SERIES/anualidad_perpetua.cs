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
    public partial class anualidad_perpetua : Form
    {
        public anualidad_perpetua()
        {
            InitializeComponent();
        }

        private void btbcalcular_Click(object sender, EventArgs e)
        {
            double Vpresente = 0;
            double Vfuturo = 0;
            double tasa = 0;
            double tiempo = 0;
            double anualidad = 0;

            if (txtanual.Text != String.Empty && txttasa.Text != String.Empty )
            {
                tasa = Convert.ToDouble(txttasa.Text);
                anualidad = Convert.ToDouble(txtanual.Text);

                txtVP.Text = (Math.Abs(Math.Round(anualidad/tasa, 3))).ToString();

                txtVF.Enabled = false;
                txttiempo.Enabled = false;




            }

         

            else if (txttasa.Text != String.Empty && txttiempo.Text != String.Empty && txtVF.Text != String.Empty)
            {
                tasa = Convert.ToDouble(txttasa.Text);
                tiempo = Convert.ToDouble(txttiempo.Text);
                Vfuturo = Convert.ToDouble(txtVF.Text);


                txtanual.Text = (Math.Abs(Math.Round(Vfuturo * (tasa / ((Math.Pow((1 + tasa), tiempo)) - 1)), 3))).ToString();

                txtVP.Enabled = false;
            }

            else if (txttasa.Text != String.Empty && txttiempo.Text != String.Empty && txtVF.Text != String.Empty)
            {
                tasa = Convert.ToDouble(txttasa.Text);
                tiempo = Convert.ToDouble(txttiempo.Text);



                txtVF.Text = (Math.Abs(Math.Round(anualidad * (((Math.Pow((1 + tasa), tiempo)) - 1) / tasa), 3))).ToString();

                txtVP.Enabled = false;

            }

           
        }

        private void btbfinalizar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btbreiniciar_Click(object sender, EventArgs e)
        {
            txtVP.Text = "";
            txtVF.Text = "";
            txttiempo.Text = "";
            txtanual.Text = "";
            txttasa.Text = "";


            txtVP.Enabled = true;
            txtVF.Enabled = true;
            txttiempo.Enabled = true;
            txtanual.Enabled = true;
            txttasa.Enabled = true;

            btbcalcular.Enabled = true;
            btbreiniciar.Visible = true;
        }
    }
}
