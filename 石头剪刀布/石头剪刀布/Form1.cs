using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 石头剪刀布
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rd = new Random();
        public int a;
        public int b;
        string[] lines;
        private void Game()
        {
            a = rd.Next(1,3);
            if(b==a)
            {
                lines = textBox1.Lines;
                lines[2] = "平局！";
                textBox1.Lines = lines;
            }
            if((b==1&&a==2) || (b==2&&a==3) || (b==3&&a==1))
            {
                lines = textBox1.Lines;
                lines[2] = "你赢了！";
                textBox1.Lines = lines;
                if(progressBar1.Value!=0)
                {
                    progressBar1.Value -= 1;
                }
                else 
                {
                    MessageBox.Show("你打败了电脑！","提示");
                    this.Close();
                }
            }
            if((b==1&&a==3)|| (b==2&&a==1)||(b==3&&a==2))
            {
                lines = textBox1.Lines;
                lines[2] = "你输了！";
                textBox1.Lines = lines;
                if (progressBar2.Value != 0)
                {
                    progressBar2.Value -= 1;
                }
                else
                {
                    MessageBox.Show("电脑打败了你！", "提示");
                    this.Close();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            b = 1;
            Game();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b = 2;
            Game();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            b = 3;
            Game();
        }
    }
}
