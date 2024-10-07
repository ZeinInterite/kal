using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kal
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        public Form1()
        {
            InitializeComponent();

            textBox1 = new TextBox();
            textBox1.Location = new Point(10, 10);
            textBox1.Size = new Size(100, 20);
            Controls.Add(textBox1);

            textBox2 = new TextBox();
            textBox2.Location = new Point(10, 40);
            textBox2.Size = new Size(100, 20);
            Controls.Add(textBox2);

            textBox3 = new TextBox();
            textBox3.Location = new Point(10, 80);
            textBox3.Size = new Size(100, 20);
            textBox3.ReadOnly = true;
            Controls.Add(textBox3);

            button1 = new Button();
            button1.Text = "+";
            button1.Location = new Point(120, 10);
            button1.Size = new Size(50, 20);
            button1.Click += button1_Click;
            Controls.Add(button1);

            button2 = new Button();
            button2.Text = "-";
            button2.Location = new Point(120, 40);
            button2.Size = new Size(50, 20);
            button2.Click += button2_Click;
            Controls.Add(button2);

            button3 = new Button();
            button3.Text = "*";
            button3.Location = new Point(180, 10);
            button3.Size = new Size(50, 20);
            button3.Click += button3_Click;
            Controls.Add(button3);

            button4 = new Button();
            button4.Text = "/";
            button4.Location = new Point(180, 40);
            button4.Size = new Size(50, 20);
            button4.Click += button4_Click;
            Controls.Add(button4);

            button5 = new Button();
            button5.Text = "^";
            button5.Location = new Point(120, 80);
            button5.Size = new Size(50, 20);
            button5.Click += button5_Click;
            Controls.Add(button5);

            button6 = new Button();
            button6.Text = "√";
            button6.Location = new Point(180, 80);
            button6.Size = new Size(50, 20);
            button6.Click += button6_Click;
            Controls.Add(button6);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static double sum(double a, double b)
        {
            return a + b;
        }

        public static double razn(double a, double b)
        {
            return a - b;
        }

        public static double umnog(double a, double b)
        {
            return a * b;
        }

        public static double del(double a, double b)
        {
            return a / b;
        }

        public static double step(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public static double koren(double a, double b)
        {
            return Math.Pow(a, 1 / b);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(sum(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(razn(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(umnog(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(del(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(step(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(koren(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }
    }
}

