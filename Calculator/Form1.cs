using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ZERO.Click += new EventHandler(BtnClick);
            DOT.Click += new EventHandler(BtnClick);
            add.Click += new EventHandler(BtnClick);
            ONE.Click += new EventHandler(BtnClick);
            TWO.Click += new EventHandler(BtnClick);
            Less.Click += new EventHandler(BtnClick);
            Multiply.Click += new EventHandler(BtnClick);
            SIX.Click += new EventHandler(BtnClick);
            FIVE.Click += new EventHandler(BtnClick);
            FOUR.Click += new EventHandler(BtnClick);
            SEVEN.Click += new EventHandler(BtnClick);
            EIGHT.Click += new EventHandler(BtnClick);
            NINE.Click += new EventHandler(BtnClick);
            Divide.Click += new EventHandler(BtnClick);
            percent.Click += new EventHandler(BtnClick);
         

        }
        private void BtnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void AC_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
