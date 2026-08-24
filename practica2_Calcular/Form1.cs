using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica2_Calcular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal valorVenta;
            decimal descuentoVenta;
            decimal ventasTotales;
            decimal descuentoPorcentaje;

            if (!decimal.TryParse(txtValorVenta.Text, out valorVenta))
            {
                MessageBox.Show("The textBox is Empty!");
            }
            else
            {
                if (valorVenta >= 500)
                {
                    descuentoPorcentaje = 0.30m;
                }
                else if (valorVenta >= 300 && valorVenta <= 499)
                {
                    descuentoPorcentaje = 0.20m;
                }
                else if (valorVenta > 100 && valorVenta <= 299)
                {
                    descuentoPorcentaje = 0.10m;
                }
                else
                {
                    descuentoPorcentaje = 0;
                }

                descuentoVenta = valorVenta * descuentoPorcentaje;
                ventasTotales = valorVenta - descuentoVenta;

                txtVentaFinal.Text = ventasTotales.ToString();
                txtDescuentoPorcentaje.Text = descuentoPorcentaje.ToString();
                txtDescuento.Text = descuentoVenta.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtVentaFinal.Text = "";
            txtDescuento.Text = "";
            txtDescuentoPorcentaje.Text = "";
            txtValorVenta.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A continuación se cerrará la aplicación", "Cerrar aplicación", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
