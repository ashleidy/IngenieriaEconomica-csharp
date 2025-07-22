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
    public partial class anualidad : Form
    {
        public anualidad()
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

            if (txtanual.Text != String.Empty && txttasa.Text != String.Empty && txttiempo.Text != String.Empty)
            {
                tasa = Convert.ToDouble(txttasa.Text);
                tiempo = Convert.ToDouble(txttiempo.Text);
                anualidad = Convert.ToDouble(txtanual.Text);

                txtVP.Text = (Math.Abs(Math.Round(anualidad * ((1 - Math.Pow((1 + tasa), (-tiempo))) / tasa), 3))).ToString();

                txtVF.Enabled = false;
            }

            else if (txttasa.Text != String.Empty && txttiempo.Text != String.Empty && txtVP.Text != String.Empty)
            {
                tasa = Convert.ToDouble(txttasa.Text);
                tiempo = Convert.ToDouble(txttiempo.Text);
                Vpresente = Convert.ToDouble(txtVP.Text);



                txtanual.Text = (Math.Abs(Math.Round(Vpresente * (tasa / (1 - Math.Pow((1 + tasa), (-tiempo)))), 3))).ToString();

                txtVF.Enabled = false;
            }

            else if (txttasa.Text != String.Empty && txttiempo.Text != String.Empty && txtVF.Text != String.Empty)
            {
                tasa = Convert.ToDouble(txttasa.Text);
                tiempo = Convert.ToDouble(txttiempo.Text);
                Vfuturo = Convert.ToDouble(txtVF.Text);


                txtanual.Text = (Math.Abs(Math.Round(Vfuturo * (tasa /( ( Math.Pow((1 + tasa), tiempo))-1)), 3))).ToString();

                txtVP.Enabled = false;
                txtanual.Enabled = false;
            }

            else if (txttasa.Text != String.Empty && txttiempo.Text != String.Empty && txtVF.Text != String.Empty)
            {
                tasa = Convert.ToDouble(txttasa.Text);
                tiempo = Convert.ToDouble(txttiempo.Text);
               


                txtVF.Text = (Math.Abs(Math.Round(anualidad *( ((Math.Pow((1 + tasa), tiempo)) - 1)/tasa), 3))).ToString();

                txtVP.Enabled = false;
                txtanual.Enabled = false;
            }

            else if (txttasa.Text != String.Empty && txttiempo.Text != String.Empty && txtVP.Text != String.Empty)
            {
                tasa = Convert.ToDouble(txttasa.Text);
                Vpresente = Convert.ToDouble(txtVP.Text);
                anualidad = Convert.ToDouble(txtanual.Text);


                txttiempo.Text = (Math.Abs(Math.Round(-Math.Log(1-((Vpresente*tasa)/anualidad))/Math.Log(1+tasa), 3))).ToString();

                txtVF.Enabled = false;
                
            }

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

        private void btcalcular_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
