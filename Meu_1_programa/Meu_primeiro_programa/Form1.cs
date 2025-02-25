namespace Meu_primeiro_programa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_mensagem_Click(object sender, EventArgs e)
        {
            String mensagem, frase, nome, dia, hora, sobrenome;
            mensagem = "Ver Novamente";
            frase = "Olá, Mundo!";
            btn_mensagem.Text = mensagem;
            MessageBox.Show(frase);
            nome = "Enzo";
            sobrenome = "Neves";
            MessageBox.Show(nome + " " + sobrenome + ", Bom dia");
            dia = "18";
            hora = "10";
            MessageBox.Show(nome + " " + sobrenome + ", Hoje é dia " + dia);
            MessageBox.Show(nome + " " + sobrenome + ", Agora são " + hora + " Horas");
        }
    }
}
