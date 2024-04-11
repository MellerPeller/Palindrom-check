using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Palindrom_cheak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text.Length <= 0)
            {
                MessageBox.Show("Texten är för kort, testa igen", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string str;
                str = textBox1.Text;
                char[] arr = str.ToCharArray();
                Array.Reverse(arr);
                string str2 = new string(arr);



                if (str2 == textBox1.Text)
                {
                    MessageBox.Show($"\"{textBox1.Text}\" är ett palindrom.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"\"{textBox1.Text}\" är INTE ett palindrom, testa igen.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
