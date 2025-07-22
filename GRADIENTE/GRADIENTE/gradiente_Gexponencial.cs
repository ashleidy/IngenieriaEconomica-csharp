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
    public partial class gradiente_Gexponencial : Form
    {
        public gradiente_Gexponencial()
        {
            InitializeComponent();
        }

        private void btbcalcular_Click(object sender, EventArgs e)
        {
            double tasaefectiva = 0;
            double tiempo = 0;
            double  tasanominal= 0;
            double primeracuota = 0;
            double Vpresente = 0;

            if (txttasaefectiva.Text != String.Empty && txttasanominal.Text != String.Empty && txttiempo.Text != String.Empty && txtprimeracuota.Text != String.Empty)
            {
                tasaefectiva = Convert.ToDouble(txttasaefectiva.Text);
                tiempo = Convert.ToDouble(txttiempo.Text);
                tasanominal = Convert.ToDouble(txttasanominal.Text);
                primeracuota = Convert.ToDouble(txtprimeracuota.Text);
              

                if (tasaefectiva != tasanominal)
                {
                    txtVP.Text = (Math.Abs(Math.Round(primeracuota * ((1 - Math.Pow(((1 + tasanominal) / (1 + tasaefectiva)), tiempo)) / (tasaefectiva - tasanominal)), 3))).ToString();
                    txtVF.Text = (Math.Abs(Math.Round(primeracuota * ((Math.Pow((1 + tasaefectiva), tiempo) - Math.Pow((1 + tasanominal), tiempo)) / (tasaefectiva - tasanominal)), 3))).ToString();

                    txtVP.Enabled = false;
                    txtVF.Enabled = false;


                }

                else if (tasaefectiva == tasanominal)
                {

                    txtVP.Text = (Math.Abs(Math.Round((tiempo * primeracuota) / (1 + tasaefectiva), 3))).ToString();
                    txtVF.Text = (Math.Abs(Math.Round(tiempo * primeracuota * Math.Pow((1 + tasanominal), (tiempo - 1)), 3))).ToString();

                    txtVP.Enabled = false;
                    txtVF.Enabled = false;
                }
            }
            else if(txttasaefectiva.Text != txttasanominal.Text && txttasaefectiva.Text != String.Empty && txttasanominal.Text != String.Empty && txttiempo.Text != String.Empty && txtVP.Text != String.Empty)
            {
                tasaefectiva = Convert.ToDouble(txttasaefectiva.Text);
                tiempo = Convert.ToDouble(txttiempo.Text);
                tasanominal = Convert.ToDouble(txttasanominal.Text);
               
                Vpresente = Convert.ToDouble(txtVP.Text);

                txtprimeracuota.Text = (Math.Abs(Math.Round((Vpresente * (tasaefectiva - tasanominal)) / (1 - (Math.Pow(((1 + tasanominal) / (1 + tasaefectiva)), tiempo))), 3))).ToString();

                txtprimeracuota.Enabled = false;
                txtVF.Enabled = false;

            }
       



            
        }

        private void btbcuota_Click(object sender, EventArgs e)
        {
           
            double tiempo = 0;
            double tasanominal = 0;
            double primeracuota = 0;
           

            if ( txttasanominal.Text != String.Empty && txttiempo.Text != String.Empty && txtprimeracuota.Text != String.Empty)
            {
                tiempo = Convert.ToDouble(txttiempo.Text);
                tasanominal = Convert.ToDouble(txttasanominal.Text);
                primeracuota = Convert.ToDouble(txtprimeracuota.Text);
                

                txtcuota.Text= (Math.Abs(Math.Round(primeracuota*Math.Pow((1+tasanominal),(tiempo-1)), 3))).ToString();

                txtcuota.Enabled = false;

            }


        }

        private void btbreiniciar_Click(object sender, EventArgs e)
        {
            txtVP.Text = "";
            txtVF.Text = "";
            txttiempo.Text = "";
            txttasanominal.Text = "";
            txttasaefectiva.Text = "";
            txtprimeracuota.Text = "";
            txtcuota.Text = "";


            txtVP.Enabled = true;
            txtVF.Enabled = true;
            txttiempo.Enabled = true;
            txttasanominal.Enabled = true;
            txttasaefectiva.Enabled = true;
            txtprimeracuota.Enabled = true;
            txtcuota.Enabled = true;

            btbcalcular.Enabled = true;
            btbreiniciar.Visible = true;
        }

        private void btbfinalizar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
