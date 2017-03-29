using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeSheet
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'timesheetDataSet1.Cliente'. Você pode movê-la ou removê-la conforme necessário.
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormCadastraCliente CadastraCliente = new FormCadastraCliente();
            CadastraCliente.Show();
        }
    }
}
