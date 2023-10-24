using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Emma
{
    public partial class Form1 : Form
    {
        private const string a = "*";

        private char A = char.Parse(a);

        public Form1()
        {
            InitializeComponent();
        }

        
        

        private void txtEnter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox; foreach (Control ctrl in Pcontainer2.Controls)
            {
                if (ctrl is PictureBox 
                    && ctrl.Name == "PB" + txt.Tag.ToString())
                {
                    ctrl.BackColor = Color.FromArgb(79, 129, 189);
                }
                if (ctrl is Label && ctrl.Name == "LB" + txt.Tag.ToString())
                {
                    ctrl.ForeColor = Color.FromArgb(79, 129, 189);
                }
            }
        }

        private void txtlave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox; foreach (Control ctrl in Pcontainer2.Controls)
            {
                if (ctrl is PictureBox
                    && ctrl.Name == "PB" + txt.Tag.ToString())
                {
                    if (txt.Text == string.Empty)
                    {
                    ctrl.BackColor = Color.Red;
                    }
                    else
                    {
                    ctrl.BackColor = Color.Black;
                    }
                }
                if (ctrl is Label && ctrl.Name == "LB" + txt.Tag.ToString())
                {
                    if (txt.Text == string.Empty)
                    {
                        ctrl.ForeColor = Color.Red;
                    }
                    else
                    {
                        ctrl.ForeColor = Color.Black;
                    }
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PBnombre_Click(object sender, EventArgs e)
        {

        }

        private void LBnombre_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Pcontainer2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox; foreach (Control ctrl in Pcontainer2.Controls)
            {
                if (ctrl is PictureBox
                    && ctrl.Name == "pb" + txt.Tag.ToString())
                {
                    ctrl.BackColor = Color.FromArgb(79, 129, 189);
                }
                if (ctrl is Label && ctrl.Name == "lb" + txt.Tag.ToString())
                {
                    ctrl.ForeColor = Color.FromArgb(79, 129, 189);
                }
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox; foreach (Control ctrl in Pcontainer2.Controls)
            {
                if (ctrl is PictureBox
                    && ctrl.Name == "pb" + txt.Tag.ToString())
                {
                    if (txt.Text == string.Empty)
                    {
                        ctrl.BackColor = Color.Red;
                    }
                    else
                    {
                        ctrl.BackColor = Color.Black;
                    }
                }
                if (ctrl is Label && ctrl.Name == "lb" + txt.Tag.ToString())
                {
                    if (txt.Text == string.Empty)
                    {
                        ctrl.ForeColor = Color.Red;
                    }
                    else
                    {
                        ctrl.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                if(textBox3.Text == string.Empty)
                {
                    MessageBox.Show("El usuario o email y contraseña son incorrectos","Ingresar al sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (textBox3.Text != "231606")
                    {
                        MessageBox.Show("El usuario o email y contraseña son incorrectos", "Ingresar al sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("El usuario o email es incorrecto", "Ingresar al sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (textBox3.Text == string.Empty)
                {
                    if (textBox1.Text != "Emma")
                    {
                        MessageBox.Show("El usuario o email y contraseña son incorrectos", "Ingresar al sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("La contraseña es incorrecta", "Ingresar al sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (textBox1.Text != "Emma" && textBox3.Text != "231606")
                    {
                        MessageBox.Show("El usuario o email y contraseña son incorrectos", "Ingresar al sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (textBox1.Text != "Emma" && textBox3.Text == "231606")
                    {
                        MessageBox.Show("El usuario o email es incorrecto", "Ingresar al sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (textBox1.Text == "Emma" && textBox3.Text != "231606")
                    {
                        MessageBox.Show("La contraseña es incorrecta", "Ingresar al sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (textBox1.Text == "Emma" && textBox3.Text == "231606")
                    {
                        MessageBox.Show("Bienvenido", "Ingresar al sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form2 f2 = new Form2();
                        f2.Show();
                        Hide();
                    }
                }
            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            textBox3.PasswordChar = A;
            Font n = new Font("Arial", 7.0f, FontStyle.Regular);
            label2.Font = n;
            label2.ForeColor = Color.Black;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '\0';
            Font S = new Font("Arial", 7.0f, FontStyle.Underline);
            label2.Font = S;
            label2.ForeColor = Color.Blue;
        }
    }
}
