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
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void videojuegosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            MessageBox.Show("Por seguridad de la tienda devemos validar algunos datos" + "\n" + "Estos datos no seran visibles para nadie mas");
            FormAV av = new FormAV();
            av.Show();
        }

        private void alimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            MessageBox.Show("Por seguridad de la tienda devemos validar algunos datos" + "\n" + "Estos datos no seran visibles para nadie mas");
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            MessageBox.Show("Por seguridad de la tienda devemos validar algunos datos" + "\n" + "Estos datos no seran visibles para nadie mas");
            Form6 f6 = new Form6();
            f6.Show();
        }
    }
}
