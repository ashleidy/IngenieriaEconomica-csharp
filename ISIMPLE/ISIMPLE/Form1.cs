using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISIMPLE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btcalcular_Click(object sender, EventArgs e)
        {
            //Interes=Valor presente*n*i
            //Valor presente=F/(1+i*n)
            //Valor futuro=P(1+i*n)
            //Tasa de interes=(F/P-1)/n
            //tiempo=(F/P-1)/i

           
            double Vpresente = 0;
            double Vfuturo = 0;
            double Tinteres = 0;
            double tiempo = 0;

            
            if (txtTI.Text != String.Empty &&  txtTiempo.Text != String.Empty && txtVP.Text != String.Empty)
            {

                Tinteres = Convert.ToDouble(txtTI.Text);
                tiempo = Convert.ToDouble(txtTiempo.Text);
                Vpresente = Convert.ToDouble(txtVP.Text);

                //INTERES

                txtIS.Text = (Math.Abs(Math.Round((Tinteres*tiempo*Vpresente), 3))).ToString();

                //VALOR FUTURO
                txtVF.Text = (Math.Abs(Math.Round((Vpresente * (1 + (Tinteres * tiempo))), 3))).ToString();

                txtIS.Enabled = false;
                txtVF.Enabled = false;


            }

            //valor presente 

            else if (txtVF.Text != String.Empty && txtTI.Text != String.Empty && txtTiempo.Text != String.Empty)
            {
                Tinteres = Convert.ToDouble(txtTI.Text);
                tiempo = Convert.ToDouble(txtTiempo.Text);
                Vfuturo= Convert.ToDouble(txtVF.Text);

                txtVP.Text = (Math.Abs(Math.Round((Vfuturo/(1+ (Tinteres* tiempo))), 3))).ToString();

                txtIS.Enabled = false;
                txtVP.Enabled = false;
            }
     

            //Tasa de interes

            else if (txtVP.Text != String.Empty && txtVF.Text != String.Empty && txtTiempo.Text != String.Empty)
            {
                Vfuturo = Convert.ToDouble(txtVF.Text);
                tiempo = Convert.ToDouble(txtTiempo.Text);
                Vpresente = Convert.ToDouble(txtVP.Text);

                txtTI.Text = (Math.Abs(Math.Round((((Vfuturo/Vpresente)-1)/tiempo), 3))).ToString();

                txtTI.Enabled = false;
                txtIS.Enabled = false;

            }


            //Tiempo

            else if (txtVP.Text != String.Empty && txtTI.Text != String.Empty && txtTiempo.Text != String.Empty)
            {
                Vfuturo = Convert.ToDouble(txtVF.Text);

                Tinteres = Convert.ToDouble(txtTI.Text);
                Vpresente = Convert.ToDouble(txtVP.Text);

                txtTiempo.Text = (Math.Abs(Math.Round((((Vfuturo / Vpresente) - 1) / Tinteres), 3))).ToString();

                txtTiempo.Enabled = false;
                txtIS.Enabled = false;
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
            txtIS.Text = "";
            txtTiempo.Text ="";
            txtTI.Text = "";


            txtVP.Enabled= true;
            txtVF.Enabled = true;
            txtIS.Enabled = true;
            txtTiempo.Enabled = true;
            txtTI.Enabled = true;

            btcalcular.Enabled = true;
            btbreiniciar.Visible = true;

        }
    }
}
