namespace meu_3_programa
{
    public partial class Form1 : Form
    {
        bool troca = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.estatua;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.templo;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (troca)
            {
                pictureBox2.Image = Properties.Resources.baralhotraseiro;
                troca = false;
            }
            else
            {
                pictureBox2.Image = Properties.Resources.baralhofrontal;
                troca = true;
            }
        }
    }
}
