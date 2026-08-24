using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract3_EstructuraIf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdbSuma.Checked = false;
            rdbResta.Checked = false;
            rdbMultiplicacion.Checked = false;
            rdbDivision.Checked = false;
        }

        private void rdbSuma_Click(object sender, EventArgs e)
        {
            decimal valor1, valor2, resultado;

            if (decimal.TryParse(txtValor1.Text, out valor1) && decimal.TryParse(txtValor2.Text, out valor2))
            {
                lblSigno.Text = "+";
                resultado = valor1 + valor2;
                txtResultado.Text = resultado.ToString();

                return;
            }
            else
            {
                MessageBox.Show("Coloca un carácter númerico", "Información incorrecta",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void rdbResta_Click(object sender, EventArgs e)
        {
            decimal valor1, valor2, resultado;

            if (decimal.TryParse(txtValor1.Text, out valor1) && decimal.TryParse(txtValor2.Text, out valor2))
            {
                lblSigno.Text = "-";
                resultado = valor1 - valor2;
                txtResultado.Text = resultado.ToString();

                return;
            }
            else
            {
                MessageBox.Show("Coloca un carácter númerico", "Información incorrecta",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void rdbMultiplicacion_Click(object sender, EventArgs e)
        {
            decimal valor1, valor2, resultado;

            if (decimal.TryParse(txtValor1.Text, out valor1) && decimal.TryParse(txtValor2.Text, out valor2))
            {
                lblSigno.Text = "*";
                resultado = valor1 * valor2;
                txtResultado.Text = resultado.ToString();

                return;
            }
            else
            {
                MessageBox.Show("Coloca un carácter númerico", "Información incorrecta",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void rdbDivision_Click(object sender, EventArgs e)
        {
            decimal valor1, valor2, resultado;

            if (decimal.TryParse(txtValor1.Text, out valor1) && decimal.TryParse(txtValor2.Text, out valor2))
            {
                lblSigno.Text = "/";
                if (valor2 == 0)
                {
                    MessageBox.Show("No se puede dividir entre 0.", "Operación inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    resultado = valor1 / valor2;
                    txtResultado.Text = resultado.ToString();
                }

                return;
            }
            else
            {
                MessageBox.Show("Coloca un carácter númerico", "Información incorrecta",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
