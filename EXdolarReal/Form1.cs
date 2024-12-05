using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXdolarReal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double ConverterDolarParaReal(double cotacaoDolar, double valorDolar)
        {
            return cotacaoDolar * valorDolar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cotacaoTexto = txtCota.Text;
            string valorDolarTexto = txtDolar.Text;

            
            if (double.TryParse(cotacaoTexto, out double cotacaoDolar) && double.TryParse(valorDolarTexto, out double valorDolar))
            {
                
                double valorReal = ConverterDolarParaReal(cotacaoDolar, valorDolar);

                
                txtReal.Text = valorReal.ToString("F2"); 
            }
            else
            {
                
                txtReal.Clear();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCota.Clear();
            txtDolar.Clear();
            txtReal.Clear();
            txtCota.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }


}
