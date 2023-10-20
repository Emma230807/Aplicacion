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
    public partial class Form5 : Form
    {
        private int n = 0;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Enter(object sender, EventArgs e)
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

        private void Form5_Leave(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (n != -1)
                {
                    DTGVv.Rows.RemoveAt(n);
                }
            }
            catch
            {
                MessageBox.Show("No puedes eliminar datos inexistentes");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cd = "|";
            string tp = "|";
            string al = "|";
            string pv = "|";
            string lt = "|";
            string ct = "|";
            int n2 = 0;
            if (txcodigo.Text == string.Empty)
            {
                cd = "Codigo";
                n2++;
            }
            if (txtipo.Text == string.Empty)
            {
                tp = "Tipo";
                n2++;
            }
            if (txalimento.Text == string.Empty)
            {
                al = "Alimento";
                n2++;
            }
            
            if (txprovedor.Text == string.Empty)
            {
                pv = "Provedor";
                n2++;
            }
            if (txlote.Text == string.Empty)
            {
                lt = "Lote";
                n2++;
            }
            if (txcantidad.Text == string.Empty)
            {
                ct = "Cantidad";
                n2++;
            }
            else
            {
                try
                {
                    string es2 = txcantidad.Text;
                    int Es2 = int.Parse(es2);
                    if (Es2 < 0)
                    {
                        ct = "La cantidad deve ser positiva";
                        n2++;
                    }
                    else if (Es2 == 0)
                    {
                        ct = "Cantidad invalidas";
                        n2++;
                    }
                }
                catch
                {
                    ct = "La cantidad deve ser un numero entero";
                    n2++;
                }
            }
            

            if (n2 != 0)
            {
                MessageBox.Show("Rellena los siguientes apartados" + "\n" + cd + "\n" + tp + "\n" + al + "\n" + pv + "\n" + lt + "\n" + ct);
            }
            else
            {
                //colocar el codigo
                int n = DTGVv.Rows.Add();

                // colocamos la información 
                DTGVv.Rows[n].Cells[1].Value = txcodigo.Text;
                DTGVv.Rows[n].Cells[0].Value = txtipo.Text;
                DTGVv.Rows[n].Cells[5].Value = txalimento.Text;
                DTGVv.Rows[n].Cells[7].Value = dtcaducidad.Text;
                DTGVv.Rows[n].Cells[2].Value = txprovedor.Text;
                DTGVv.Rows[n].Cells[3].Value = txlote.Text;
                DTGVv.Rows[n].Cells[4].Value = txcantidad.Text;
                DTGVv.Rows[n].Cells[6].Value = dtfechaingreeso.Text;

                //limpiamos los txt 
                txcodigo.Text = "";
                txtipo.Text = "";
                txalimento.Text = "";
                dtcaducidad.Text = "";
                txprovedor.Text = "";
                txlote.Text = "";
                txcantidad.Text = "";
                dtfechaingreeso.Text = "";
                //limpiamos los txt 
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
