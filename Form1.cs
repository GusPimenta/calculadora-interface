using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace calculadora_complexa
{
    public partial class Calculadora : Form
    {

        decimal num1 = 0, num2 = 0, num3 = 0;
        string tipo = "", mostre1 = "", mostre2 = "";
        int tecla;
        public Calculadora()
        {
            InitializeComponent();
        }
        private void numero(int num)
        {
            if (tipo == "")
            {
                txtResultado.Text += Convert.ToString(num);
                mostre1 = txtResultado.Text;
            }
            else
            {
                txtResultado.Text += Convert.ToString(num);
                mostre2 += Convert.ToString(num);
            }
        }

        private void operacao(string op)
        {
            if (tipo == "")
            {
                if (mostre1 != "")
                {
                    num1 = decimal.Parse(txtResultado.Text);
                    tipo = op;
                    txtResultado.Text += tipo;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            numero(0);
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            numero(1);
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            numero(2);
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            numero(3);
        }


        private void btnQuatro_Click(object sender, EventArgs e)
        {
            numero(4);
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            numero(5);
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            numero(6);
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            numero(7);
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            numero(8);
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            numero(9);
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            num3 = 0;
            mostre1 = "";
            mostre2 = "";
            tipo = "";
            txtResultado.Text = "";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (tipo == "")
            {
                if (!mostre1.Contains(","))
                {
                    txtResultado.Text += ",";
                    mostre1 = txtResultado.Text;
                }
            }
            else
            {
                if (!mostre2.Contains(","))
                {
                    txtResultado.Text += ",";
                    mostre2 += ",";
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (mostre1 != "")
            {
                if (tipo == "")
                {
                    mostre1 = mostre1.Remove(mostre1.Length - 1);
                    txtResultado.Text = txtResultado.Text.Remove(txtResultado.Text.Length - 1);
                    if (mostre1 == "")
                    {
                        num1 = 0;
                    }
                    else
                    {
                        num1 = decimal.Parse(mostre1);
                    }
                }
                else
                {
                    if (txtResultado.Text.EndsWith("+") || txtResultado.Text.EndsWith("-") || txtResultado.Text.EndsWith("x") || txtResultado.Text.EndsWith("/"))
                    {
                        txtResultado.Text = txtResultado.Text.Remove(txtResultado.Text.Length - 1);
                        tipo = "";
                    }
                    else
                    {
                        if (mostre2 != "")
                        {
                            mostre2 = mostre2.Remove(mostre2.Length - 1);
                            txtResultado.Text = txtResultado.Text.Remove(txtResultado.Text.Length - 1);
                            if (mostre2 != "")
                            {
                                num2 = decimal.Parse(mostre2);
                            }
                            else
                            {
                                num2 = 0;
                            }
                        }
                        else
                        {
                            num2 = 0;
                        }

                    }
                }
            }

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            operacao("+");
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            operacao("-");
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            operacao("x");
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            operacao("/");
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (mostre2 != "")
            {
                num2 = decimal.Parse(mostre2);
                switch (tipo)
                {
                    case "+":
                        num3 = num1 + num2;
                        ; break;
                    case "-":
                        num3 = num1 - num2;
                        break;
                    case "x":
                        num3 = num1 * num2;
                        break;
                    case "/":
                        num3 = num1 / num2;
                        break;
                }
                num1 = num3;
                num2 = 0;
                num3 = 0;
                mostre1 = Convert.ToString(num1);
                mostre2 = "";
                tipo = "";
                txtResultado.Text = Convert.ToString(num1);
            }
        }
        private void txtResultado_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Cauculadora_KeyDown(object sender, KeyEventArgs e)
        {
            tecla = e.KeyValue;
            switch (tecla)
            {
                case 48:
                    btnZero_Click(sender, e);
                    tecla = 0;
                    break;
                case 49:
                    btnUm_Click(sender, e);
                    tecla = 0;
                    break;
                case 50:
                    btnDois_Click(sender, e);
                    tecla = 0;
                    break;
                case 51:
                    btnTres_Click(sender, e);
                    tecla = 0;
                    break;
                case 52:
                    btnQuatro_Click(sender, e);
                    tecla = 0;
                    break;
                case 53:
                    btnCinco_Click(sender, e);
                    tecla = 0;
                    break;
                case 54:
                    btnSeis_Click(sender, e);
                    tecla = 0;
                    break;
                case 55:
                    btnSete_Click(sender, e);
                    tecla = 0;
                    break;
                case 56:
                    btnOito_Click(sender, e);
                    tecla = 0;
                    break;
                case 57:
                    btnNove_Click(sender, e);
                    tecla = 0;
                    break;
                case 188:
                    btnVirgula_Click(sender, e);
                    tecla = 0;
                    break;
                case 190:
                    btnVirgula_Click(sender, e);
                    tecla = 0;
                    break;
                case 187:
                    btnSoma_Click(sender, e);
                    tecla = 0;
                    break;
                case 88:
                    btnMultiplicacao_Click(sender, e);
                    tecla = 0;
                    break;
                case 193:
                    btnDivisao_Click(sender, e);
                    tecla = 0;
                    break;
                case 189:
                    btnSubtracao_Click(sender, e);
                    tecla = 0;
                    break;
            }
        }
    }
}