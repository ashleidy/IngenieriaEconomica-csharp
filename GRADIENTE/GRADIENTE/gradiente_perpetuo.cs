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
    public partial class gradiente_perpetuo : Form
    {
        public gradiente_perpetuo()
        {
            InitializeComponent();
        }

        private void btbcalcular_Click(object sender, EventArgs e)
        {

            double tasaefectiva = 0;
            double tasanominal = 0;
            double primeracuota = 0;
            double Vpresente = 0;

            if (txttasaefectiva.Text != String.Empty && txttasanominal.Text != String.Empty && txtprimeracuota.Text != String.Empty)
            {
                tasaefectiva = Convert.ToDouble(txttasaefectiva.Text);

                tasanominal = Convert.ToDouble(txttasanominal.Text);
                primeracuota = Convert.ToDouble(txtprimeracuota.Text);


                if (tasaefectiva > tasanominal)
                {
                    txtVP.Text = (Math.Abs(Math.Round(primeracuota / (tasaefectiva - tasanominal), 3))).ToString();

                    txtVP.Enabled = false;



                }
            }

            else if (txttasaefectiva.Text != String.Empty && txttasanominal.Text != String.Empty && txtVP.Text != String.Empty)
            {
                tasaefectiva = Convert.ToDouble(txttasaefectiva.Text);
                tasanominal = Convert.ToDouble(txttasanominal.Text);
                Vpresente= Convert.ToDouble(txtVP.Text);


                if (tasaefectiva > tasanominal)
                {
                    txtprimeracuota.Text = (Math.Abs(Math.Round(Vpresente*(tasaefectiva-tasanominal), 3))).ToString();

                    txtprimeracuota.Enabled = false;



                }
            }
        }

        private void btbreiniciar_Click(object sender, EventArgs e)
        {
            txtVP.Text = "";
            txttasanominal.Text = "";
            txttasaefectiva.Text = "";
            txtprimeracuota.Text = "";
           

            txtVP.Enabled = true;
            
            txttasanominal.Enabled = true;
            txttasaefectiva.Enabled = true;
            txtprimeracuota.Enabled = true;
        

            btbcalcular.Enabled = true;
            btbreiniciar.Visible = true;
        }

        private void btbfinalizar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}