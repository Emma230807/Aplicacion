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
    public partial class Form3 : Form
    {
        private int n = 0;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cd = "|";
            string nm = "|";
            string cf = "|";
            string añ = "|";
            string cp = "|";
            string ct = "|";
            string gb = "|";
            string pc = "|";
            int n2 = 0;
            if(txcodigo.Text == string.Empty)
            {
                cd = "Codigo";
                n2++;
            }
            if (txnombre.Text == string.Empty)
            {
                nm = "Nombre";
                n2++;
            }
            if (txclasificacion.Text == string.Empty)
            {
                cf = "Clasificacion";
                n2++;
            }
            if (txaño.Text == string.Empty)
            {
                añ = "año";
                n2++;
            }
            else
            {
                try
                {
                    string es3 = txgb.Text;
                    int Es3 = int.Parse(es3);
                    if (Es3 < 0)
                    {
                        añ = "El año debe ser positivo";
                        n2++;
                    }
                    else if (Es3 == 0)
                    {
                        añ = "Año invalido";
                        n2++;
                    }
                }
                catch
                {
                    añ = "EL año deve ser un numero entero";
                    n2++;
                }
            }
            if (txcompañia.Text == string.Empty)
            {
                cp = "Compañia";
                n2++;
            }
            if (txcategoria.Text == string.Empty)
            {
                ct = "Categoria";
                n2++;
            }
            if (txgb.Text == string.Empty)
            {
                gb = "GB";
                n2++;
            }
            else
            {
                try
                {
                    string es2 = txgb.Text;
                    int Es2 = int.Parse(es2);
                    if (Es2 < 0)
                    {
                        gb = "Los GB deven ser positivos";
                        n2++;
                    }
                    else if (Es2 == 0)
                    {
                        gb = "GB invalidos";
                        n2++;
                    }
                }
                catch
                {
                    gb = "Los GB deven ser un numero entero";
                    n2++;
                }
            }
            if (txprecio.Text == string.Empty)
            {
                pc = "Precio";
                n2++;
            }
            else
            {
                try
                {
                    string es = txprecio.Text;
                    int Es = int.Parse(es);
                    if (Es < 0)
                    {
                        pc = "El precio deve ser positivo";
                        n2++;
                    }
                    else if (Es == 0)
                    {
                        pc = "Precio invalido";
                        n2++;
                    }
                }
                catch
                {
                    pc = "El precio deve ser un numero entero";
                    n2++;
                }
            }

            if(n2 != 0)
            {
                MessageBox.Show("Rellena los siguientes apartados" + "\n" + cd + "\n" + nm + "\n" + cf + "\n" + añ + "\n" + cp + "\n" + ct + "\n" + gb + "\n" + pc);
            }
            else
            {
                //colocar el codigo
                int n = DTGVv.Rows.Add();

                // colocamos la información 
                DTGVv.Rows[n].Cells[0].Value = txcodigo.Text;
                DTGVv.Rows[n].Cells[1].Value = txnombre.Text;
                DTGVv.Rows[n].Cells[2].Value = txclasificacion.Text;
                DTGVv.Rows[n].Cells[3].Value = txaño.Text;
                DTGVv.Rows[n].Cells[4].Value = txcompañia.Text;
                DTGVv.Rows[n].Cells[5].Value = txcategoria.Text;
                DTGVv.Rows[n].Cells[6].Value = txgb.Text;
                DTGVv.Rows[n].Cells[7].Value = txprecio.Text;

                //limpiamos los txt 
                txcodigo.Text = "";
                txnombre.Text = "";
                txclasificacion.Text = "";
                txaño.Text = "";
                txcompañia.Text = "";
                txcategoria.Text = "";
                txgb.Text = "";
                txprecio.Text = "";
                //limpiamos los txt 
            }
        }

        private void DTGVv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

            if(n != -1)
            {
                DTGVv.Rows.RemoveAt(n);
            }
            }
            catch
            {
                MessageBox.Show("No puedes eliminar datos inexistentes");
            }
        }

        private void lbaño_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txcodigo_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox; foreach (Control ctrl in Pcontainer2.Controls)
            {
                if (ctrl is PictureBox
                    && ctrl.Name == "PB" + txt.Tag.ToString())
                {
                    ctrl.BackColor = Color.FromArgb(79, 129, 189);
                }
                if (ctrl is Label && ctrl.Name == "lb" + txt.Tag.ToString())
                {
                    ctrl.ForeColor = Color.FromArgb(79, 129, 189);
                }
            }
        }

        private void txcodigo_Leave(object sender, EventArgs e)
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Form2 f2 = new Form2();
                f2.Show();
                Hide();
            }
        }
    }
}
