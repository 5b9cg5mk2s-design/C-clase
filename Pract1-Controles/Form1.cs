using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract1_Controles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            decimal numero;
            foreach (Control dato in this.Controls)
            {
                if (dato is TextBox incorrect)
                {
                    if (incorrect == txtFecha)
                    {
                        continue;
                    }
                    if (!decimal.TryParse(incorrect.Text, out numero))
                    {
                        txtFecha.Clear();
                        
                        MessageBox.Show("La información necesaria está vacía o incorrecta, por favor completa los espacios en blanco.", 
                            "Espacios vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        incorrect.Focus();
                        incorrect.Clear();
                        
                        return;
                    }
                    else
                    {
                        txtFecha.Text = txtDia.Text + "/" + txtMes.Text + "/" + txtAnio.Text;
                    }
                }
            }
        }
            

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls) {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
