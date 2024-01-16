using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picturebox_buton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

            button1.Left= 0;
            button2.Left = 0;
            button3.Left = 0;
            button4.Left = 0;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();

            button1.Left = button1.Left + 1 + random.Next(1, 30);
            button2.Left = button2.Left + 1 + random.Next(1, 30);
            button3.Left = button3.Left + 1 + random.Next(1, 30);
            button4.Left = button4.Left + 1 + random.Next(1, 30);
        }
    }
}
