using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculoIMC
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double altura = Convert.ToDouble(txtAltura.Text);
            double peso = Convert.ToDouble(txtPeso.Text);

            double imc = peso / (altura * altura);

            ckAbaixo.Checked = false;
            ckNormal.Checked = false;
            ckAcima.Checked = false;
            ckOb1.Checked = false;
            ckOb2.Checked = false;
            ckOb3.Checked = false;

            if (imc < 18.5)
            {
                ckAbaixo.Checked = true;
            }
            else if (imc >= 18.5 && imc < 25)
            {
                ckNormal.Checked = true;
            }
            else if (imc >= 25 && imc < 30)
            {
                ckAcima.Checked = true;
            }
            else if (imc >= 30 && imc < 35)
            {
                ckOb1.Checked = true;
            }
            else if (imc >= 35 && imc < 40)
            {
                ckOb2.Checked = true;
            }
            else
            {
                ckOb3.Checked = true;
            }

            imc = Math.Round(imc, 2);

            txtIMC.Text = imc.ToString();


            

        }
    }
}
