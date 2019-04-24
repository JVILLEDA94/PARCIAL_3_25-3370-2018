using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARCIAL_3_25_3370_2018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario, password;
            usuario = textBox1.Text.TrimEnd();
            password = textBox2.Text.TrimEnd();
            if ((usuario == "JVILLEDA") && (password == "1234567"))
            {

                MessageBox.Show("Bienvenidos al sistema");

                MDIParent1 obj = new MDIParent1();

                obj.Show();

                

            }
            else
            {
                MessageBox.Show("Verifique usuario y password");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
