using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 formularioUser = new Form2();
            formularioUser.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 visualizaUser = new Form3();
            visualizaUser.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
    }
}
