namespace meu_4_programa
{
    public partial class Form1 : Form
    {
        bool troca = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random sorteio = new Random();
            int numeroCarta = sorteio.Next(1, 14);
            string naipe = "espada_";
            string carta = naipe + numeroCarta.ToString();
            if (troca)
            {
                pictureBox2.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(carta);
                troca = true;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.espada_tras;
                troca = true;
            }
        }
    }
}
