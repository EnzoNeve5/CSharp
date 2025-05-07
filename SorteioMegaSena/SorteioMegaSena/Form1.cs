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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] megasena = new int[6];
            Random sorteio = new Random();
            label1.Text = "";
            label1.ForeColor = Color.Indigo;

            for (int i = 0; i < 6; i++) { 
                megasena[i] = sorteio.Next(1, 61);
            }

            Array.Sort(megasena);

            for (int i = 0; i < 6; i++)
            {
                if (i < 5)
                {
                    label1.Text += megasena[i].ToString() + ", ";
                }
                else
                {
                    label1.Text += megasena[i].ToString() + "";
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
