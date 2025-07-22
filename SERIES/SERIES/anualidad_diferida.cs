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
    public partial class anualidad_diferida : Form
    {
        public anualidad_diferida()
        {
            InitializeComponent();
        }

        private void btbcalcular_Click(object sender, EventArgs e)
        {
            double Vpresente = 0;
            double periodo = 0;
            double tasa = 0;
            double tiempo = 0;
            double anualidad = 0;

            if (txtanual.Text != String.Empty && txttasa.Text != String.Empty && txttiempo.Text != String.Empty && txtperiodo.Text != String.Empty)
            {
                tasa = Convert.ToDouble(txttasa.Text);
                tiempo = Convert.ToDouble(txttiempo.Text);
                periodo = Convert.ToDouble(txtperiodo.Text);
                anualidad = Convert.ToDouble(txtanual.Text);

                txtVP.Text = (Math.Abs(Math.Round(anualidad * ((1 - Math.Pow((1 + tasa), (-tiempo))) / tasa) *(Math.Pow( (1 + tasa),(-periodo))), 3))).ToString();

                txtVF.Enabled = false;
            }

            else if (txttasa.Text != String.Empty && txttiempo.Text != String.Empty && txtVP.Text != String.Empty && txtperiodo.Text != String.Empty)
            {
                tasa = Convert.ToDouble(txttasa.Text);
                tiempo = Convert.ToDouble(txttiempo.Text);
                Vpresente = Convert.ToDouble(txtVP.Text);
                periodo = Convert.ToDouble(txtperiodo.Text);


                txtanual.Text = (Math.Abs(Math.Round(Vpresente / (((1 - Math.Pow((1 + tasa), (-tiempo))) / tasa) * (Math.Pow((1 + tasa), (-periodo)))), 3))).ToString();

                txtVF.Enabled = false;
            }



            else if (txttasa.Text != String.Empty && txttiempo.Text != String.Empty && txtVF.Text != String.Empty && txtperiodo.Text != String.Empty)
            {
                tasa = Convert.ToDouble(txttasa.Text);
                tiempo = Convert.ToDouble(txttiempo.Text);
                periodo = Convert.ToDouble(txtperiodo.Text);

                txtVF.Text = (Math.Abs(Math.Round(anualidad * (((Math.Pow((1 + tasa), tiempo)) - 1) / tasa) * (Math.Pow((1 + tasa), (-periodo))), 3))).ToString();

                txtVP.Enabled = false;
                txtanual.Enabled = false;
            }

       
        }

        private void btbreiniciar_Click(object sender, EventArgs e)
        {
            txtVP.Text = "";
            txtVF.Text = "";
            txttiempo.Text = "";
            txtanual.Text = "";
            txttasa.Text = "";
            txtperiodo.Text = "";

            txtVP.Enabled = true;
            txtVF.Enabled = true;
            txttiempo.Enabled = true;
            txtanual.Enabled = true;
            txttasa.Enabled = true;
            txtperiodo.Enabled = true;

            btbcalcular.Enabled = true;
            btbreiniciar.Visible = true;
        }

        private void btbfinalizar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
