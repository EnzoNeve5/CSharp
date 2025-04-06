namespace UrnaEletronica
{
    public partial class Form1 : Form
    {
        string numeroDigitado = "";
        class Candidato
        {
            public string Nome { get; set; }
            public string Partido { get; set; }

            public Candidato(string nome, string partido)
            {
                Nome = nome;
                Partido = partido;
            }
        }

        Dictionary<string, Candidato> candidatos = new Dictionary<string, Candidato>
        {
            { "10", new Candidato("Enzo Neves", "Partido Azul") },
            { "20", new Candidato("Levi Bambam", "Partido Verde") },
            { "30", new Candidato("Victor Gustavo", "Partido Amarelo") },
            { "40", new Candidato("Andreas Alves", "Partido Vermelho") },
            { "50", new Candidato("Gustavo Venâncio", "Partido Roxo") },
            { "60", new Candidato("Vinicius Ciencia", "Partido Laranja") }
        };

        public Form1()
        {
            InitializeComponent();
        }
        void funcao_Botao(String numero)
        {
            if (txtUrna.Text == "0")
                txtUrna.Text = "";

            if (numeroDigitado.Length < 2)
            {
                numeroDigitado += numero;
                txtUrna.Text += numero;

                if (numeroDigitado.Length == 2)
                {
                    if (candidatos.ContainsKey(numeroDigitado))
                    {
                        var c = candidatos[numeroDigitado];
                        lblCandidato.Text = $"Nome: {c.Nome}\nPartido: {c.Partido}";
                    }
                    else
                    {
                        lblCandidato.Text = $"Nome: Nulo\nPartido: Nulo";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            funcao_Botao("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            funcao_Botao("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            funcao_Botao("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            funcao_Botao("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            funcao_Botao("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            funcao_Botao("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            funcao_Botao("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            funcao_Botao("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            funcao_Botao("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            funcao_Botao("0");
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voto em branco confirmado.");
            numeroDigitado = "";
            txtUrna.Text = "";
        }

        private void btnCorrige_Click(object sender, EventArgs e)
        {
            numeroDigitado = "";
            txtUrna.Text = "";
            lblCandidato.Text = "";
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (numeroDigitado == "")
            {
                MessageBox.Show("Nenhum número digitado.");
                return;
            }

            if (candidatos.ContainsKey(numeroDigitado))
            {
                MessageBox.Show("O seu voto foi realizado com sucesso");
            }
            else
            {
                MessageBox.Show("Voto nulo.");
            }

            numeroDigitado = "";
            txtUrna.Text = "";
            lblCandidato.Text = "";
        }
    }
}
