using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMORTIZACION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btbcalcular_Click(object sender, EventArgs e)
        {
            double Vpresente = 0;
            double interes = 0;
            double saldo = 0;
            double amortizacion = 0;
            double tasa = 0;
            double tiempo = 0;
            double anualidad = 0;

            if (txttasa.Text != String.Empty && txttiempo.Text != String.Empty && txtVP.Text != String.Empty )
            {
                tasa = Convert.ToDouble(txttasa.Text);
                tiempo = Convert.ToDouble(txttiempo.Text);
                Vpresente = Convert.ToDouble(txtVP.Text);
                

                txtanual.Text = (Math.Abs(Math.Round(Vpresente * (tasa / (1 - Math.Pow((1 + tasa), (-tiempo)))), 3))).ToString();
                txtinteres.Text= (Math.Abs(Math.Round(Vpresente * tasa, 3))).ToString();
               

            }
        }

        private void btbreiniciar_Click(object sender, EventArgs e)
        {
            txtVP.Text = "";
            txttasa.Text = "";
            txttiempo.Text = "";
            txtanual.Text = "";
            txtinteres.Text = "";
            txtamortizacion.Text = "";
            txtsaldo.Text = "";


            txtVP.Enabled = true;
            txtinteres.Enabled = true;
            txttiempo.Enabled = true;
            txtanual.Enabled = true;
            txttasa.Enabled = true;
            txtamortizacion.Enabled = true;
            txtsaldo.Enabled = true;


            btbcalcular.Enabled = true;
            btbreiniciar.Visible = true;
        }

        private void btbfinalizar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTBSALDO_Click(object sender, EventArgs e)
        {
            double Vpresente = 0;
            double amortizacion = 0;
           

            if (txtamortizacion.Text != String.Empty && txtVP.Text != String.Empty )
            {
                amortizacion = Convert.ToDouble(txtamortizacion.Text);
                Vpresente = Convert.ToDouble(txtVP.Text);


               
                txtsaldo.Text = (Math.Abs(Math.Round(Vpresente -amortizacion, 3))).ToString();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            double interes = 0;
            double anualidad = 0;

            if (txtinteres.Text != String.Empty && txtanual.Text != String.Empty )
            {
                
                anualidad= Convert.ToDouble(txtanual.Text);
                interes = Convert.ToDouble(txtinteres.Text);


                txtamortizacion.Text = (Math.Abs(Math.Round(anualidad-interes, 3))).ToString();


            }
        }
    }
}
