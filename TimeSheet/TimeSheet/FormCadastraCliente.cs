using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeSheet.DAO;

namespace TimeSheet
{
    public partial class FormCadastraCliente : Form
    {

        private IList<Controle> Controle;
        public FormCadastraCliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            FormCliente Cliente = new FormCliente();
            Cliente.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ClienteDAO DAO = new ClienteDAO();

            Cliente Cliente = new Cliente()
            {
                Nome = textBox1.Text,
                Email = textBox2.Text,
                Responsavel = textBox3.Text,
                Endereco = textBox4.Text,
                Telefone = textBox5.Text
            };

            DAO.Salvar(Cliente);
            MessageBox.Show("Cliente cadastrado com sucesso!");
            this.Close();
            FormCliente ClienteForm = new FormCliente();
            ClienteForm.Show();
        }
    }
}
