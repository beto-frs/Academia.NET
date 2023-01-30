using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        bool vezX = false;
        string Vbutton;
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            vezX = true;
            lblVez.Text = "X";
            BotoesEnable();
            btnBolinha.Enabled = false;
            btnX.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BotoesEnable()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

        }

        private void BotoesFalse()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;

        }

        private void btnBolinha_Click(object sender, EventArgs e)
        {
            vezX = false;
            lblVez.Text = "O";
            BotoesEnable();
            btnBolinha.Enabled = false;
            btnX.Enabled = false;
        }

        private void btnRecomeca_Click(object sender, EventArgs e)
        {
            count = 0;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            lblVencedor.Text = " - ";
            lblVez.Text = " - ";

            btnBolinha.Enabled = true;
            btnX.Enabled = true;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            count++;
            Button btn = (Button)sender;
            btn.Text = lblVez.Text;
            btn.Enabled = false;

            if (vezX)
            {
                lblVez.Text = "O";
            }
            else
            {
                lblVez.Text = "X";
            }
            vezX = !vezX;


            if (!VerificaVencedor())
            {
                lblVez.Text = " - ";
                lblVez.Text = " - ";
                btn.Enabled = false;
                MessageBox.Show("EMPATE !!!");
            }
        }

        private bool VerificaVencedor()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")
            {
                lblVencedor.Text = button1.Text;
                MessageBox.Show(button1.Text + " é o vencedor!!!");
                BotoesFalse();
                return true;
            }

            else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
            {
                lblVencedor.Text = button1.Text;
                MessageBox.Show(button1.Text + " é o vencedor!!!");
                BotoesFalse();
                return true;
            }

            else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
            {
                lblVencedor.Text = button1.Text;
                MessageBox.Show(button1.Text + " é o vencedor!!!");
                BotoesFalse();
                return true;
            }

            else if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
            {
                lblVencedor.Text = button1.Text;
                MessageBox.Show(button1.Text + " é o vencedor!!!");
                BotoesFalse();
                return true;
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
            {
                lblVencedor.Text = button1.Text;
                MessageBox.Show(button1.Text + " é o vencedor!!!");
                BotoesFalse();
                return true;
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
            {
                lblVencedor.Text = button1.Text;
                MessageBox.Show(button1.Text + " é o vencedor!!!");
                BotoesFalse();
                return true;
            }
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
            {
                lblVencedor.Text = button1.Text;
                MessageBox.Show(button1.Text + " é o vencedor!!!");
                BotoesFalse();
                return true;
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
            {
                lblVencedor.Text = button1.Text;
                MessageBox.Show(button1.Text + " é o vencedor!!!");
                BotoesFalse();
                return true;
            }

            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
