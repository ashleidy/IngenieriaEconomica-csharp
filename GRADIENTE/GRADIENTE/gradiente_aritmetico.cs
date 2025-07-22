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
    public partial class gradiente_aritmetico : Form
    {
        public gradiente_aritmetico()
        {
            InitializeComponent();
        }

        private void btbcalcular_Click(object sender, EventArgs e)
        {
            double tasa = 0;
            double anualidad = 0;
            double gradiente = 0;
            double Vpresente = 0;




            if (txtanual.Text != String.Empty && txttasa.Text != String.Empty && txtgradiente.Text != String.Empty)
            {
                tasa = Convert.ToDouble(txttasa.Text);
                anualidad = Convert.ToDouble(txtanual.Text);
                gradiente = Convert.ToDouble(txtgradiente.Text);

                txtVP.Text = (Math.Abs(Math.Round((anualidad / tasa) + (gradiente / Math.Pow(tasa, 2)), 3))).ToString();




            }

            if (txtanual.Text != String.Empty && txtVP.Text != String.Empty && txtgradiente.Text != String.Empty)
            {
                Vpresente = Convert.ToDouble(txtVP.Text);
                anualidad = Convert.ToDouble(txtanual.Text);
                gradiente = Convert.ToDouble(txtgradiente.Text);

                txttasa.Text = (Math.Abs(Math.Round((anualidad+Math.Sqrt(Math.Pow(anualidad,2)+(4*Vpresente*gradiente)))/(2*Vpresente), 3))).ToString();




            }

            if (txtanual.Text != String.Empty && txtVP.Text != String.Empty && txttasa.Text != String.Empty)
            {
                Vpresente = Convert.ToDouble(txtVP.Text);
                anualidad = Convert.ToDouble(txtanual.Text);
                tasa = Convert.ToDouble(txttasa.Text);

                txtgradiente.Text = (Math.Abs(Math.Round((Vpresente*Math.Pow(tasa,2))-(anualidad*tasa), 3))).ToString();


        


            }

            if (txtgradiente.Text != String.Empty && txtVP.Text != String.Empty && txttasa.Text != String.Empty)
            {
                Vpresente = Convert.ToDouble(txtVP.Text);
                gradiente = Convert.ToDouble(txtgradiente.Text);
                tasa = Convert.ToDouble(txttasa.Text);

                txtanual.Text = (Math.Abs(Math.Round((Vpresente * tasa) - (gradiente/tasa), 3))).ToString();




            }
        }

        private void btbreiniciar_Click(object sender, EventArgs e)
        {
            txtVP.Text = "";
            txtanual.Text = "";
            txttasa.Text = "";
            txtgradiente.Text = "";
         

            txtVP.Enabled = true;
            txtanual.Enabled = true;
            txttasa.Enabled = true;
            txtgradiente.Enabled = true;
       

            btbcalcular.Enabled = true;
            btbreiniciar.Visible = true;
        }

        private void btbfinalizar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
