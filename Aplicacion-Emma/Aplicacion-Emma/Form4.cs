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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Nombre_Enter(object sender, EventArgs e)
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

        private void Nombre_Leave(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string nm = "|";
            string ap = "|";
            string am = "|";
            string ed = "|";
            string cp = "|";
            string en = "|";
            string er = "|";
            string ae = "|";
            string gn = "|";
            int n = 0;
            int o = 8;


            if (Nombre.Text == string.Empty)
            {
                nm = "Nombre";
                n--;
                o--;
            }
            if (ApeidoP.Text == string.Empty)
            {
                ap = "Apeido Paterno";
                n--;
                o--;
            }
            if (ApeidoM.Text == string.Empty)
            {
                am = "Apeido Materno";
                n--;
                o--;
            }
            if (Edad.Text == string.Empty)
            {
                ed = "Edad";
                n--;
                o--;
            }
            else
            {
                try
                {
                    string es = Edad.Text;
                    int Es = int.Parse(es);
                    if (Es < 0)
                    {
                        ed = "La edad deve ser positiva";
                        n--;
                        o--;
                    }
                    else if (Es == 0)
                    {
                        ed = "Edad invalida";
                        n--;
                        o--;
                    }
                }
                catch
                {
                    ed = "La edad deve ser un numero entero";
                    n--;
                    o--;
                }
            }
            if (Curp.Text == string.Empty)
            {
                cp = "Curp";
                n--;
                o--;
            }
            else
            {
                if (Curp.Text.Length != 10)
                {
                    cp = "La Curp debe tener 10 digitos";
                    n--;
                    o--;
                }
            }
            if (CB1.Text == string.Empty)
            {
                en = "Entidad de Nacimiento";
                n--;
                o--;
            }
            if (CB2.Text == string.Empty)
            {
                er = "Entidad de Residencia";
                n--;
                o--;
            }
            if (LIB1.Text == string.Empty)
            {
                ae = "Area de Empleado";
                n--;
                o--;
            }
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked || radioButton5.Checked || radioButton6.Checked || radioButton7.Checked || radioButton8.Checked || radioButton9.Checked)
            {
                n++;
            }
            else
            {
                gn = "Genero";

            }

            if (n == 1 && o == 8)
            {
                MessageBox.Show("Bienvenido", "Sistema de verificacion de datos",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            Form5 f5 = new Form5();
                f5.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Rellena los siguientes apartados" + "\n" + nm + "\n" + ap + "\n" + am + "\n" + ed + "\n" + cp + "\n" + en + "\n" + er + "\n" + ae + "\n" + gn, "Sistema de verificacion de datos",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
        }
    }
}
