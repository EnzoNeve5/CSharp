using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SorteioMegaSena
{
    public partial class Form1 : Form
    {
        int quantidade = 0;
        int[,] sorteios_megasena = new int[100, 8];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random sorteio = new Random();

            label1.Text = "Sorteio Realizado";
            label1.ForeColor = Color.Indigo;

            for (int j = 0; j < 6; j++)
            {
                sorteios_megasena[quantidade, j] = sorteio.Next(1, 61);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            for (int j = 0; j < 6; j++)
            {
                if (j < 5)
                {
                    label1.Text += sorteios_megasena[quantidade, j].ToString() + ", ";
                }
                else
                {
                    label1.Text += sorteios_megasena[quantidade, j].ToString() + "";
                }
            }
            quantidade++;
            listBox1.Items.Add("Sorteio " + quantidade + ": " + label1.Text);
            listBox1.ForeColor = Color.OrangeRed;
            listBox1.BackColor = Color.LightSkyBlue;
            listBox1.SelectedItems.Clear();
        }
    }
}
