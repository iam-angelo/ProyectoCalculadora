using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCaption.Text))
                txtCaption.Text = "1";

            else
                txtCaption.Text += "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCaption.Text))
                txtCaption.Text = "2";

            else
                txtCaption.Text += "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCaption.Text))
                txtCaption.Text = "3";

            else
                txtCaption.Text += "3";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCaption.Text))
                txtCaption.Text = "4";

            else
                txtCaption.Text += "4";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCaption.Text))
                txtCaption.Text = "5";

            else
                txtCaption.Text += "5";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCaption.Text))
                txtCaption.Text = "6";

            else
                txtCaption.Text += "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCaption.Text))
                txtCaption.Text = "7";

            else
                txtCaption.Text += "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCaption.Text))
                txtCaption.Text = "8";

            else
                txtCaption.Text += "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCaption.Text))
                txtCaption.Text = "9";

            else
                txtCaption.Text += "9";
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCaption.Text))
                txtCaption.Text = "0";

            else
                txtCaption.Text += "0";
        }
        private void btnMas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCaption.Text))
                MessageBox.Show("Debe digitar un número primero para realizar la operación de suma","Atención",MessageBoxButtons.OK,MessageBoxIcon.Information);

            else
                txtCaption.Text += "+";
        }
        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCaption.Text))
                MessageBox.Show("Debe digitar un número primero para realizar la operación de resta", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                txtCaption.Text += "-";
        }
        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCaption.Text))
                MessageBox.Show("Debe digitar un número primero para realizar la operación de multiplicar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                txtCaption.Text += "*";
        }
        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCaption.Text))
                MessageBox.Show("Debe digitar un número primero para realizar la operación de dividir", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                txtCaption.Text += "/";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCaption.Text))
                MessageBox.Show("Debe digitar un número primero para agregar decimales", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                txtCaption.Text += ".";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtCaption.Text = string.Empty;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCaption.Text))
                MessageBox.Show("No se ha agregado ninguna operación para realizar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else 
            {
                //se inicializa una lista para almacenar los valores y los operadores
                List<string> elementos = new List<string>();
                string elementoActual = "";

                foreach (char caracter in txtCaption.Text)
                {
                    if (char.IsDigit(caracter) || caracter == '.') //se comprueba si el caracter es un dígito o un punto decimal
                        elementoActual += caracter;

                    else if ("+-*/^".Contains(caracter)) //se comprueba si el caracter es un operador
                    {
                        // se agrega el elemento actual a la lista y se reinicia elementoActual
                        if (!string.IsNullOrWhiteSpace(elementoActual))
                        {
                            elementos.Add(elementoActual);
                            elementoActual = "";
                        }

                        elementos.Add(caracter.ToString());
                    }
                }

                // se agrega el último elemento a la lista
                if (!string.IsNullOrWhiteSpace(elementoActual))
                    elementos.Add(elementoActual);

                double resultado = 0;
                string operador = "+";

                foreach (var elemento in elementos)
                {
                    if ("+-*/^".Contains(elemento))
                        operador = elemento;

                    else
                    {
                        double numero = double.Parse(elemento);

                        // se realiza la operación correspondiente
                        switch (operador)
                        {
                            case "+":
                                resultado += numero;
                                break;
                            case "-":
                                resultado -= numero;
                                break;
                            case "*":
                                resultado *= numero;
                                break;
                            case "/":
                                resultado /= numero;
                                break;
                            case "^": 
                                resultado=Math.Pow(resultado,numero);    
                                break;
                                
                        }
                    }
                }

                txtCaption.Text = resultado.ToString();
            }
        }

        private void btnxdos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCaption.Text))
                MessageBox.Show("Debe digitar un número primero para realizar la operación de elevar al cuadrado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            else {
                double result = 0;
                result = double.Parse(txtCaption.Text);
                result = Math.Pow(result, 2);
                txtCaption.Text = result.ToString();
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtCaption.Text = "0";
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCaption.Text))
                MessageBox.Show("Debe digitar un número primero para realizar la operación de logaritmo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {
                double log = double.Parse(txtCaption.Text);
                log = Math.Log(log);
                txtCaption.Text = log.ToString();
            }
        }

        private void btndiezx_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCaption.Text))
                MessageBox.Show("Debe digitar un número primero para realizar la operación de base 10", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {
                double result = 0;
                result = double.Parse(txtCaption.Text);
                result = Math.Pow(10, result);
                txtCaption.Text = result.ToString();
            }
        }

        private void btnxy_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(txtCaption.Text))
                    MessageBox.Show("Debe digitar un número primero para realizar la operación exponencial", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

                else
                {
                    double x = double.Parse(txtCaption.Text);
                    txtCaption.Text += "^";
                    
                }

            }

        }

        private void btnmasmenos_Click(object sender, EventArgs e)
        {
            double result = double.Parse(txtCaption.Text);
            result = result * -1;
            txtCaption.Text = result.ToString();
        }

        private void btnfac_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCaption.Text))
                MessageBox.Show("Debe digitar un número primero para realizar la operación de factorial", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {
                int factorial = 1;
                int num = int.Parse(txtCaption.Text);
                for (int i = 1; i <= num; i++)
                {
                    factorial *= i;
                }
                txtCaption.Text = factorial.ToString();
            }
        }

        private void btnraizdos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCaption.Text))
                MessageBox.Show("Debe digitar un número primero para realizar la operación de raiz", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {
                double result = 0;
                result = double.Parse(txtCaption.Text);
                result = Math.Sqrt(result);
                txtCaption.Text = result.ToString();
            }
        }

        private void txtCaption_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }


