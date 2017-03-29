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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            this.ListaCli();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormCadastraCliente CadastraCliente = new FormCadastraCliente();
            CadastraCliente.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var index = dataGridView1.CurrentRow.Index;
            int id = Convert.ToInt32(dataGridView1.Rows[index].Cells["ID"].Value.ToString());
            ClienteDAO DAO = new ClienteDAO();
            DAO.Deletar(id);
            this.ListaCli();
            MessageBox.Show("Cliente deletado com Sucesso!");
        }

        private void ListaCli() {

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            ClienteDAO DAO = new ClienteDAO();

            var lista = DAO.Listar();
            foreach (var li in lista)
            {
                this.dataGridView1.Rows.Add(li.ID, li.Nome, li.Responsavel, li.Email, li.Endereco, li.Telefone);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAlteraCliente AltCli = new FormAlteraCliente
            
            var index = dataGridView1.CurrentRow.Index;
            int id = Convert.ToInt32(dataGridView1.Rows[index].Cells["ID"].Value.ToString());

            this.Close();

            ClienteDAO DAO = new ClienteDAO();
            Cliente Cliente = DAO.BuscaPorId(id);

            
            AltCliente.Show();
        }
        
    }
}
