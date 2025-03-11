namespace meu_segundo_programa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void funcao_Botao(String numero)
        {
            if (txt_Visor.Text == "0")
                txt_Visor.Text = "";

            txt_Visor.Text = txt_Visor.Text + numero;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            funcao_Botao("1");
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            funcao_Botao("2");
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            funcao_Botao("3");
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            funcao_Botao("4");
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            funcao_Botao("5");
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            funcao_Botao("6");
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            funcao_Botao("7");
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            funcao_Botao("8");
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            funcao_Botao("9");
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            funcao_Botao("0");
        }

        private void btn_V_Click(object sender, EventArgs e)
        {
            if (!txt_Visor.Text.Contains(","))
            {
                txt_Visor.Text += ",";
            }
            ;
        }

        decimal primeiroNumero, segundoNumero;
        string operacao = "";

        private void btn_Mais_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txt_Visor.Text, out primeiroNumero))
            {
                operacao = "+";
                txt_Visor.Clear();
            }
        }

        private void btn_Menos_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txt_Visor.Text, out primeiroNumero))
            {
                operacao = "-";
                txt_Visor.Clear();
            }
        }

        private void btn_D_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txt_Visor.Text, out primeiroNumero))
            {
                operacao = "/";
                txt_Visor.Clear();
            }
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txt_Visor.Text, out primeiroNumero))
            {
                operacao = "*";
                txt_Visor.Clear();
            }
        }

        private void btn_I_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txt_Visor.Text, out segundoNumero))
            {
                decimal resultado = 0;
                switch (operacao)
                {
                    case "+":
                        resultado = primeiroNumero + segundoNumero;
                        break;
                    case "-":
                        resultado = primeiroNumero - segundoNumero;
                        break;
                    case "*":
                        resultado = primeiroNumero * segundoNumero;
                        break;
                    case "/":
                        if (segundoNumero != 0)
                            resultado = primeiroNumero / segundoNumero;
                        else
                        {
                            MessageBox.Show("Erro: Divisão por zero!");
                            return;
                        }
                        break;
                    case "%":
                        resultado = (primeiroNumero * segundoNumero) / 100;
                        break;
                }
                txt_Visor.Text = resultado.ToString();
            }
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            txt_Visor.Text = "0";
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            txt_Visor.Text = "0";
            primeiroNumero = 0;
            segundoNumero = 0;
            operacao = "";
        }

        private void btn_P_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txt_Visor.Text, out primeiroNumero))
            {
                operacao = "%";
                txt_Visor.Clear();
            }
        }
    }
}
