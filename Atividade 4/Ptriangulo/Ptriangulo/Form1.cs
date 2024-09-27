using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ptriangulo
{
    public partial class Form1 : Form
    {
        double valorA, valorB, valorC;

        private void txtvalorB_Validating(object sender, CancelEventArgs e)
        {
            if(!Double.TryParse(txtvalorB.Text, out valorB))
            {
                MessageBox.Show("Valor de B inválido");
                e.Cancel = true;    
            }
            else if (valorB <= 0)
            {
                MessageBox.Show("Valor de B deve ser maior que 0");
                e.Cancel = true;
            }
        }

        private void txtvalorC_Validating(object sender, CancelEventArgs e)
        {
            if(!Double.TryParse(txtvalorC.Text, out valorC))
            {
                MessageBox.Show("Valor de C inválido");
                e.Cancel = true;
            }
            else if (valorC <= 0)
            {
                MessageBox.Show("Valor de C deve ser maior que 0");
                e.Cancel = true;
            }
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if ((valorA < valorB + valorC) && (valorA > Math.Abs(valorB - valorC)) &&
                (valorB < valorA + valorC) && (valorB > Math.Abs(valorA - valorC)) &&
                (valorC < valorA + valorB) && (valorC > Math.Abs(valorA - valorB)))
            {
                if ((valorA == valorB) && (valorB == valorC))
                {
                    MessageBox.Show("Triângulo Equilátero");
                }
                else if ((valorA == valorB) || (valorB == valorC) || (valorA == valorC))
                {
                    MessageBox.Show("Triângulo Isósceles");
                }
                else
                    MessageBox.Show("Triângulo Escaleno");
            }
            else
                MessageBox.Show("Valores inválidos, não formam triângulo!");

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtvalorA.Clear();
            txtvalorB.Clear();
            txtvalorC.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtvalorA_Validating(object sender, CancelEventArgs e)
        {
            if (!Double.TryParse(txtvalorA.Text, out valorA))
            {
                MessageBox.Show("Valor de A inválido");
                e.Cancel = true;
            }
            else if (valorA <= 0)
            {
                MessageBox.Show("Valor de A deve ser maior que zero");
                e.Cancel = true;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
