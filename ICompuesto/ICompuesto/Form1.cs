using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICompuesto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btcalcular_Click(object sender, EventArgs e)
        {



            double Vpresente = 0;
            double Vfuturo = 0;
            double Tinteres = 0;
            double tiempo = 0;


            if (txtTI.Text != String.Empty && txtTiempo.Text != String.Empty && txtVP.Text != String.Empty)
            {

                Tinteres = Convert.ToDouble(txtTI.Text);
                tiempo = Convert.ToDouble(txtTiempo.Text);
                Vpresente = Convert.ToDouble(txtVP.Text);

                //INTERES

                txtIC.Text = (Math.Abs(Math.Round((Vpresente*(Math.Pow((1 + Tinteres), tiempo)-1)), 3))).ToString();



                //VALOR FUTURO
                txtVF.Text = (Math.Abs(Math.Round((Vpresente*Math.Pow((1+ Tinteres), tiempo)), 3))).ToString();

          
                txtVF.Enabled = false;
                txtIC.Enabled = false;

            }

            //valor presente 

            else if (txtVF.Text != String.Empty && txtTI.Text != String.Empty && txtTiempo.Text != String.Empty)
            {
                Tinteres = Convert.ToDouble(txtTI.Text);
                tiempo = Convert.ToDouble(txtTiempo.Text);
                Vfuturo = Convert.ToDouble(txtVF.Text);

                txtVP.Text = Math.Round((Vfuturo / Math.Pow((1 + Tinteres), tiempo)),3).ToString();

             
                txtVP.Enabled = false;
                txtIC.Enabled = false;

            }


            //Tasa de interes

            else if (txtVP.Text != String.Empty && txtVF.Text != String.Empty && txtTiempo.Text != String.Empty)
            {
                Vfuturo = Convert.ToDouble(txtVF.Text);
                tiempo = Convert.ToDouble(txtTiempo.Text);
                Vpresente = Convert.ToDouble(txtVP.Text);

                txtTI.Text = (Math.Abs(Math.Round((Math.Pow((Vfuturo / Vpresente),(1/tiempo))-1), 3))).ToString();

                txtTI.Enabled = false;
                txtIC.Enabled = false;


            }


            //Tiempo

            else if (txtVP.Text != String.Empty && txtTI.Text != String.Empty && txtTiempo.Text != String.Empty)
            {
                Vfuturo = Convert.ToDouble(txtVF.Text);
                Tinteres = Convert.ToDouble(txtTI.Text);
                Vpresente = Convert.ToDouble(txtVP.Text);

                txtTiempo.Text = (Math.Abs(Math.Round(((Math.Log10(Vfuturo / Vpresente))/ (Math.Log10(1+Tinteres))), 3))).ToString();

                txtTiempo.Enabled = false;
                txtIC.Enabled = false;

            }
        }

        private void btbreiniciar_Click(object sender, EventArgs e)
        {
            txtVP.Text = "";
            txtVF.Text = "";
            txtTiempo.Text = "";
            txtTI.Text = "";
            txtIC.Text = "";

            txtVP.Enabled = true;
            txtVF.Enabled = true;
            txtTiempo.Enabled = true;
            txtTI.Enabled = true;
            txtIC.Enabled = true;

            btcalcular.Enabled = true;
            btbreiniciar.Visible = true;

        }

        private void btbfinalizar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
