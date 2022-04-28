using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoDeTrocoMoeda.View
{
    public partial class telaprincipal : Form
    {
        public telaprincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Declaramos as variaveis para o tipo decimal
            if (tbxValorCompra.Text == "")
            {
                MessageBox.Show("Nenhum valor encontrado");

            }
            else
            {


                decimal valorCompra;
                decimal valorPago;
                decimal resto;

                //Receber os valores nas variaveis declaradas e converter para decimal

                valorCompra = Convert.ToDecimal(tbxValorCompra.Text);
                valorPago = Convert.ToDecimal(tbxValorDinheiro.Text);


                resto = valorPago - valorCompra;

                lblResultado.Text = resto.ToString();

                // resto = resto % 1;

                int moedas100 = (int)(resto / 1);
                resto = resto % 1;
                lblQtdMoeda100.Text = moedas100.ToString();

                int moedas050 = (int)(resto / 0.50m);
                resto = resto % 0.50m;
                lblQtdMoeda050.Text = moedas050.ToString();

                int moedas025 = (int)(resto / 0.25m);
                resto = resto % 0.25m;
                lblQtdMoeda025.Text = moedas025.ToString();

                int moedas010 = (int)(resto / 0.10m);
                resto = resto % 0.10m;
                lblQtdMoeda010.Text = moedas010.ToString();

                int moedas05 = (int)(resto / 0.05m);
                resto = resto % 0.05m;
                lblQtdMoeda05.Text = moedas05.ToString();

                int moedas01 = (int)(resto / 0.01m);
                resto = resto % 0.01m;
                lblQtdMoeda01.Text = moedas01.ToString();
            }
        }
    }
}
