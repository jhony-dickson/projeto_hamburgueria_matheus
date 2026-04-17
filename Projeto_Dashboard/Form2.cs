using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Dashboard
{
    public partial class formCalculadora : Form
    {
        double valorAnterior = 0;
        string operacao = "";
        bool novoValor = true;
       
        //double segundoNumero = double.Parse(visor.Text); // Pega o número novo da tela
        //double resultado = 0;
        public formCalculadora()
        {
            InitializeComponent();
        }

        private void c_Click(object sender, EventArgs e)
        {
            if (visor.Text.Length > 0)
            {
                visor.Clear();

                visor.Text = "0";
            }
        }

        private void sete_Click(object sender, EventArgs e)
        {
            if (novoValor)
            {
                visor.Text = "";
                novoValor = false;
            }
            // Se o texto for "0", nós substituímos pelo número clicado
            if (visor.Text == "0")
            {
                visor.Text = "7";
            }
            // Caso contrário, apenas adicionamos o número ao que já existe
            else
            {
                visor.Text += "7";
            }
        }

        private void oito_Click(object sender, EventArgs e)
        {
            if (novoValor)
            {
                visor.Text = "";
                novoValor = false;
            }
            // Se o texto for "0", nós substituímos pelo número clicado
            if (visor.Text == "0")
            {
                visor.Text = "8";
            }
            // Caso contrário, apenas adicionamos o número ao que já existe
            else
            {
                visor.Text += "8";
            }
        }

        private void nove_Click(object sender, EventArgs e)
        {
            if (novoValor)
            {
                visor.Text = "";
                novoValor = false;
            }
            // Se o texto for "0", nós substituímos pelo número clicado
            if (visor.Text == "0")
            {
                visor.Text = "9";
            }
            // Caso contrário, apenas adicionamos o número ao que já existe
            else
            {
                visor.Text += "9";
            }
        }

        private void quatro_Click(object sender, EventArgs e)
        {
            if (novoValor)
            {
                visor.Text = "";
                novoValor = false;
            }
            // Se o texto for "0", nós substituímos pelo número clicado
            if (visor.Text == "0")
            {
                visor.Text = "4";
            }
            // Caso contrário, apenas adicionamos o número ao que já existe
            else
            {
                visor.Text += "4";
            }
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            if (novoValor)
            {
                visor.Text = "";
                novoValor = false;
            }
            // Se o texto for "0", nós substituímos pelo número clicado
            if (visor.Text == "0")
            {
                visor.Text = "5";
            }
            // Caso contrário, apenas adicionamos o número ao que já existe
            else
            {
                visor.Text += "5";
            }
        }

        private void seis_Click(object sender, EventArgs e)
        {
            if (novoValor)
            {
                visor.Text = "";
                novoValor = false;
            }
            // Se o texto for "0", nós substituímos pelo número clicado
            if (visor.Text == "0")
            {
                visor.Text = "6";
            }
            // Caso contrário, apenas adicionamos o número ao que já existe
            else
            {
                visor.Text += "6";
            }
        }

        private void um_Click(object sender, EventArgs e)
        {
            if (novoValor)
            {
                visor.Text = "";
                novoValor = false;
            }
            // Se o texto for "0", nós substituímos pelo número clicado
            if (visor.Text == "0")
            {
                visor.Text = "1";
            }
            // Caso contrário, apenas adicionamos o número ao que já existe
            else
            {
                visor.Text += "1";
            }
        }

        private void dois_Click(object sender, EventArgs e)
        {
            if (novoValor)
            {
                visor.Text = "";
                novoValor = false;
            }
            // Se o texto for "0", nós substituímos pelo número clicado
            if (visor.Text == "0")
            {
                visor.Text = "2";
            }
            // Caso contrário, apenas adicionamos o número ao que já existe
            else
            {
                visor.Text += "2";
            }
        }

        private void tres_Click(object sender, EventArgs e)
        {
            if (novoValor)
            {
                visor.Text = "";
                novoValor = false;
            }
            // Se o texto for "0", nós substituímos pelo número clicado
            if (visor.Text == "0")
            {
                visor.Text = "3";
            }
            // Caso contrário, apenas adicionamos o número ao que já existe
            else
            {
                visor.Text += "3";
            }
        }

        private void igual_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(visor.Text);

            if (operacao == "+")
            {
                double resultado = valorAnterior + numero;
                visor.Text = resultado.ToString();
            }
            else if (operacao == "-")
            {
                double resultado = valorAnterior - numero;
                visor.Text = resultado.ToString();
            }
            else if (operacao == "*")
            {
                double resultado = valorAnterior * numero;
                visor.Text = resultado.ToString();
            }
            else if (operacao == "/")
            {
                double resultado = valorAnterior / numero;
                visor.Text = resultado.ToString();
            }
                novoValor = true;
        }

        private void virgula_Click(object sender, EventArgs e)
        {
            if (novoValor)
            {
                visor.Text = "0";
                novoValor = false;
            }
            // Verifica se a tela já contém uma vírgula
            if (!visor.Text.Contains(","))
            {
                // Se a tela não contém uma vírgula, nós adicionamos uma
                if (visor.Text == "")
                {
                    // Se a tela estiver vazia, coloca "0," 
                    visor.Text = "0,";
                }
                else
                {
                    // Se a tela não estiver vazia, apenas adiciona a vírgula
                    visor.Text += ",";
                }
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (novoValor)
            {
                visor.Text = "";
                novoValor = false;
            }
            // Se o texto for "0", nós substituímos pelo número clicado
            if (visor.Text == "0")
            {
                visor.Text = "0";
            }
            // Caso contrário, apenas adicionamos o número ao que já existe
            else
            {
                visor.Text += "0";
            }
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            if (novoValor)
            {
                visor.Text = "0";
                novoValor = false;
            }

            if (visor.Text.Length > 0)
            {
                visor.Text = visor.Text.Substring(0, visor.Text.Length - 1); // Se a tela ficar vazia, coloca "0"
            }
        }

        private void adicao_Click(object sender, EventArgs e)
        {
            // 1. converte o texto em número e armazena em valorAnterior
            valorAnterior = Convert.ToDouble(visor.Text);
            operacao = "+";
            novoValor = true;
        }

        private void subtracao_Click(object sender, EventArgs e)
        {
            valorAnterior = Convert.ToDouble(visor.Text);
            operacao = "-";
            novoValor = true;
        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {
            valorAnterior = Convert.ToDouble(visor.Text);
            operacao = "*";
            novoValor = true;
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            valorAnterior = Convert.ToDouble(visor.Text);
            operacao = "/";
            novoValor = true;
        }
    }
}
