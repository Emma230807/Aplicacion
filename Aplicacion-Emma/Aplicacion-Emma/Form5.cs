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
        int c2 = 0;


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
                MessageBox.Show("No puedes eliminar datos inexistentes", "Sistema de verificacion de datos",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                
                if (n != -1)
                {
                    DTGVv.Rows.RemoveAt(n);
                }
            }
            catch
            {
                MessageBox.Show("No puedes eliminar datos inexistentes", "Sistema de verificacion de datos",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            
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
                MessageBox.Show("Rellena los siguientes apartados" + "\n" + cd + "\n" + tp + "\n" + al + "\n" + pv + "\n" + lt + "\n" + ct, "Sistema de verificacion de datos",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
            else
            {
                if (c2 == 0)
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
                else
                {
                    int r2 = DTGVv.SelectedRows.Count - 1;

                    DTGVv.Rows[r2].Cells[0].Value = txtipo.Text;
                    DTGVv.Rows[r2].Cells[1].Value = txcodigo.Text;
                    DTGVv.Rows[r2].Cells[2].Value = txprovedor.Text;
                    DTGVv.Rows[r2].Cells[3].Value = txlote.Text;
                    DTGVv.Rows[r2].Cells[4].Value = txcantidad.Text;
                    DTGVv.Rows[r2].Cells[5].Value = txalimento.Text;
                    DTGVv.Rows[r2].Cells[6].Value = dtfechaingreeso.Text;
                    DTGVv.Rows[r2].Cells[7].Value = dtcaducidad.Text;

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

                    c2 = 0;
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (DTGVv.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecciona un renglon valido", "Editor ALMACEN DE VIDEOJUEGOS",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txtipo.Text = DTGVv.CurrentRow.Cells[0].Value.ToString();
                txcodigo.Text = DTGVv.CurrentRow.Cells[1].Value.ToString();
                txprovedor.Text = DTGVv.CurrentRow.Cells[2].Value.ToString();
                txlote.Text = DTGVv.CurrentRow.Cells[3].Value.ToString();
                txcantidad.Text = DTGVv.CurrentRow.Cells[4].Value.ToString();
                txalimento.Text = DTGVv.CurrentRow.Cells[5].Value.ToString();
                dtfechaingreeso.Text = DTGVv.CurrentRow.Cells[6].Value.ToString();
                dtcaducidad.Text = DTGVv.CurrentRow.Cells[7].Value.ToString();

                c2 = 1;
            }
        }
    }
}