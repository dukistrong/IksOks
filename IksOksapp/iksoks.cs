using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IksOksapp
{
    public partial class iksoks : Form
    {
        public iksoks()
        {
            InitializeComponent();
        }
        bool Igrac1naRedu = true;
        string click(Button b)
        {
            if (b.Text != "") return b.Text;
            if (Igrac1naRedu)
            {
                Igrac1naRedu = false;
                textBox1.Text = "Igrac 2 je na redu";
                return "X";
            }
            else
            {
                Igrac1naRedu = true;
                textBox1.Text = "Igrac 1 je na redu";
                return "O";
            }
        }
        void provera()
        {
            string[,] tabla = new string[3, 3];
            tabla[0, 0] = button1.Text;
            tabla[1, 0] = button2.Text;
            tabla[2, 0] = button3.Text;
            tabla[0, 1] = button4.Text;
            tabla[1, 1] = button5.Text;
            tabla[2, 1] = button6.Text;
            tabla[0, 2] = button7.Text;
            tabla[1, 2] = button8.Text;
            tabla[2, 2] = button9.Text;

            if (tabla[0, 0] == tabla[1, 0] && tabla[1, 0] == tabla[2, 0] && tabla[0, 0] != "") 
            { MessageBox.Show("Pobednik: " + tabla[0, 0]); resetTable(); }
            if (tabla[0, 1] == tabla[1, 1] && tabla[1, 1] == tabla[2, 1] && tabla[0, 1] != "")
            { MessageBox.Show("Pobednik: " + tabla[0, 1]); resetTable(); }
            if (tabla[0, 2] == tabla[1, 2] && tabla[1, 2] == tabla[2, 2] && tabla[0, 2] != "")
            { MessageBox.Show("Pobednik: " + tabla[0, 2]); resetTable(); }
            if (tabla[0, 0] == tabla[0, 1] && tabla[0, 1] == tabla[0, 2] && tabla[0, 1] != "")
            { MessageBox.Show("Pobednik: " + tabla[0, 1]); resetTable(); }
            if (tabla[1, 0] == tabla[1, 1] && tabla[1, 1] == tabla[1, 2] && tabla[1, 1] != "")
            { MessageBox.Show("Pobednik: " + tabla[1, 1]); resetTable(); }
            if (tabla[2, 0] == tabla[2, 1] && tabla[2, 1] == tabla[2, 2] && tabla[2, 1] != "")
            { MessageBox.Show("Pobednik: " + tabla[2, 1]); resetTable(); }
            if (tabla[0, 0] == tabla[1, 1] && tabla[1, 1] == tabla[2, 2] && tabla[1, 1] != "")
            { MessageBox.Show("Pobednik: " + tabla[1, 1]); resetTable(); }
            if (tabla[2, 0] == tabla[1, 1] && tabla[1, 1] == tabla[0, 2] && tabla[1, 1] != "")
            { MessageBox.Show("Pobednik: " + tabla[1, 1]); resetTable(); }
            if (tabla[0, 0] != "" & tabla[0, 1] != "" & tabla[0, 2] != "" & tabla[1, 0] != "" &
                tabla[1, 1] != "" & tabla[1, 2] != "" & tabla[2, 0] != "" & tabla[2, 1] != "" &
                tabla[2, 2] != "" ) { MessageBox.Show("Nereseno");resetTable(); }
        }
        void resetTable()
        {
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.Text = "";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = click(button1);
            provera();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = click(button2);
            provera();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = click(button3);
            provera();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = click(button4);
            provera();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = click(button5);
            provera();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = click(button6);
            provera();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = click(button7);
            provera();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = click(button8);
            provera();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = click(button9);
            provera();
        }
    }
}
