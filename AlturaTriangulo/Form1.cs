using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlturaTriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {                        
            //Verificar se foi digitado apenas nºs
            try
            {
                // FÓRMULA: (base * altura) / 2
                double resultado = double.Parse(txbBase.Text) * double.Parse(txbAltura.Text) / 2;
                lblResultado.Text = "ÁREA: " + resultado.ToString();
                lblResultado.ForeColor = Color.Black;
            }
            catch
            {
                lblResultado.Text = "ERRO!";
                lblResultado.ForeColor = Color.Red;
            }                      
        }
    }
}
