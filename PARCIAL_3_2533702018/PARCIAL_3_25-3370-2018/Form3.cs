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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Nombre, Carnet, Materia, Ciclo;

            Nombre = textBox1.Text.TrimEnd();
            Carnet = textBox2.Text.TrimEnd();
            Materia = textBox3.Text.TrimEnd();
            Ciclo = textBox4.Text.TrimEnd();

            if ((Nombre == "") || (Carnet == "") || (Materia == "") || (Ciclo == ""))
            {


                MessageBox.Show("todos los campos son obligatorios");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

                Form3 obj = new Form3();

                obj.Show();

            }
            else
            {
                MessageBox.Show("Datos ingresados");

                MDIParent1 obj = new MDIParent1();

                obj.Show();
            }
        }
    }
}
