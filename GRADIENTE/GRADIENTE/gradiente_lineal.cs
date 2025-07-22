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
    public partial class gradiente_lineal : Form
    {
        public gradiente_lineal()
        {
            InitializeComponent();
        }

        private void btbcalcular_Click(object sender, EventArgs e)
        {
           
            double tasa = 0;
            double tiempo = 0;
            double anualidad = 0;
            double gradiente = 0;

            if (txtanual.Text != String.Empty && txttasa.Text != String.Empty && txttiempo.Text != String.Empty && txtgradiente.Text != String.Empty)
            {
                tasa = Convert.ToDouble(txttasa.Text);
                tiempo = Convert.ToDouble(txttiempo.Text);
                anualidad = Convert.ToDouble(txtanual.Text);
                gradiente = Convert.ToDouble(txtgradiente.Text);

                txtVP.Text = (Math.Abs(Math.Round((anualidad*((1-Math.Pow((1+tasa),(-tiempo)))/tasa))+((gradiente/tasa)*(((1 - Math.Pow((1 + tasa), (-tiempo))) / tasa)-(tiempo/ Math.Pow((1+tasa),tiempo)))), 3))).ToString();

                txtVF.Text = (Math.Abs(Math.Round((anualidad * ((Math.Pow((1 + tasa), (tiempo))-1) / tasa)) + ((gradiente / tasa) * ((( Math.Pow((1 + tasa), (tiempo))-1) / tasa) - tiempo)), 3))).ToString();

                txtVP.Enabled = false;
                txtVF.Enabled = false;

            }
        }

        private void btbcuota_Click(object sender, EventArgs e)
        {
        
            double tiempo = 0;
            double anualidad = 0;
            double gradiente = 0;

            if (txtanual.Text != String.Empty &&  txttiempo.Text != String.Empty && txtgradiente.Text != String.Empty)
            {
              
                tiempo = Convert.ToDouble(txttiempo.Text);
                anualidad = Convert.ToDouble(txtanual.Text);
                gradiente = Convert.ToDouble(txtgradiente.Text);

                

                txtcuota.Text = (Math.Abs(Math.Round(anualidad+((tiempo-1)*gradiente), 3))).ToString();
                txtcuota.Enabled = false;

            }
        }

        private void btbreiniciar_Click(object sender, EventArgs e)
        {
            txtVP.Text = "";
            txtVF.Text = "";
            txttiempo.Text = "";
            txtanual.Text = "";
            txttasa.Text = "";
            txtgradiente.Text = "";
            txtcuota.Text = "";


            txtVP.Enabled = true;
            txtVF.Enabled = true;
            txttiempo.Enabled = true;
            txtanual.Enabled = true;
            txttasa.Enabled = true;
            txtgradiente.Enabled = true;
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
