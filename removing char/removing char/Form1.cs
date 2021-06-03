using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace removing_char
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(charDel.Text);
            string str = baseWord.Text;

            result.Text += $"Starting word:\n{str}\nnew word:\n{removeChar(str, num)}\n";//str.Length - 1 delka stringu (vybere posledni pismeno)
        }

        public static string removeChar(string str, int n)
        {
            return str.Remove(n, 1);
        }
    }
}
