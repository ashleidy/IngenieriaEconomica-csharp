using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASAS
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
            double Tnominal = 0;
            double Tefectiva = 0;
            double meses = 0;
            double tiempo = 0;


            if (txtmeses.Text != String.Empty && txttiempo.Text != String.Empty  && txtVF.Text != String.Empty  && txtVP.Text != String.Empty)
            {
                Vpresente = Convert.ToDouble(txtVP.Text);
                Vfuturo = Convert.ToDouble(txtVF.Text);
              
                meses = Convert.ToDouble(txtmeses.Text);
                tiempo = Convert.ToDouble(txttiempo.Text);


                //TASA
                txtTN.Text = (Math.Abs(Math.Round(((Math.Pow((Vfuturo/Vpresente),(1/(meses*tiempo))))-1)*meses, 3))).ToString();

               


                txtTE.Enabled = false;
            }

            else if (txtmeses.Text != String.Empty && txttiempo.Text != String.Empty && txtTN.Text != String.Empty && txtVP.Text != String.Empty)


            {
                Vpresente = Convert.ToDouble(txtVP.Text);
              
                Tnominal = Convert.ToDouble(txtTN.Text);
                meses = Convert.ToDouble(txtmeses.Text);
                tiempo = Convert.ToDouble(txttiempo.Text);

                //VALOR FUTURO
                txtVF.Text = (Math.Abs(Math.Round((Vpresente * (Math.Pow((1 + Tnominal / meses), (meses * tiempo)))), 3))).ToString();

                txtTE.Enabled = false;
            }

            else if (txtmeses.Text != String.Empty && txttiempo.Text != String.Empty && txtTN.Text != String.Empty && txtVF.Text != String.Empty)


            {
               
                Vfuturo = Convert.ToDouble(txtVF.Text);
                Tnominal = Convert.ToDouble(txtTN.Text);
                meses = Convert.ToDouble(txtmeses.Text);
                tiempo = Convert.ToDouble(txttiempo.Text);

                //VALOR PRESENTE
                txtVP.Text = (Math.Abs(Math.Round((Vfuturo / (Math.Pow((1 + Tnominal / meses), (meses * tiempo)))), 3))).ToString();

                txtTE.Enabled = false;
            }

            else if ( txttiempo.Text != String.Empty && txtVF.Text != String.Empty && txtVP.Text != String.Empty)
            {
                Vpresente = Convert.ToDouble(txtVP.Text);
                Vfuturo = Convert.ToDouble(txtVF.Text);
             
                tiempo = Convert.ToDouble(txttiempo.Text);


                //TASA
                txtTE.Text = (Math.Abs(Math.Round(((Math.Pow((Vfuturo / Vpresente),(1/tiempo)))-1), 3))).ToString();

               
                txtTN.Enabled = false;
                txtmeses.Enabled = false;
            }

            else if (txttiempo.Text != String.Empty && txtTE.Text != String.Empty  && txtVP.Text != String.Empty)
            {
                Vpresente = Convert.ToDouble(txtVP.Text);
 
                Tefectiva = Convert.ToDouble(txtTE.Text);
                tiempo = Convert.ToDouble(txttiempo.Text);



                //VALOR FUTURO
                txtVF.Text = (Math.Abs(Math.Round((Vpresente * (Math.Pow((1 + Tefectiva), (tiempo)))), 3))).ToString();


                txtTN.Enabled = false;
                txtmeses.Enabled = false;
            }

            else if (txttiempo.Text != String.Empty && txtTE.Text != String.Empty && txtVF.Text != String.Empty )
            { 
                Vfuturo = Convert.ToDouble(txtVF.Text);
                Tefectiva = Convert.ToDouble(txtTE.Text);
                tiempo = Convert.ToDouble(txttiempo.Text);


               
                //VALOR PRESENTE
                txtVP.Text = (Math.Abs(Math.Round((Vfuturo / (Math.Pow((1 + Tefectiva), (tiempo)))), 3))).ToString();

                txtTN.Enabled = false;
                txtmeses.Enabled = false;
            }
        }

        private void btbreiniciar_Click(object sender, EventArgs e)
        {
            txtVP.Text = "";
            txtVF.Text = "";
            txtTN.Text = "";
            txtTE.Text = "";
            txttiempo.Text = "";
            txtmeses.Text = "";


            txtVP.Enabled = true;
            txtVF.Enabled = true;
            txtTN.Enabled = true;
            txttiempo.Enabled = true;
            txtTE.Enabled = true;
            txtmeses.Enabled = true;

            btcalcular.Enabled = true;
            btbreiniciar.Visible = true;
        }

        private void btbfinalizar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
