using CadastroClientes.Entidade;
using CadastroClientes.FormsClientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroClientes
{
    public partial class MenuPrincipal : Form
    {
        private List<Cliente> ListaClientes;
        public MenuPrincipal()
        {
            InitializeComponent();
            ListaClientes = new List<Cliente>();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult escolha = MessageBox.Show("Deseja sair?", "Mensagem do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (escolha == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InserirCliente formCliente = new InserirCliente(ListaClientes);
            formCliente.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListarCliente listarCliente = new ListarCliente(ListaClientes);
            listarCliente.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExcluirCliente excluirCliente = new ExcluirCliente(ListaClientes);
            excluirCliente.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PesquisaCliente pesquisaCliente = new PesquisaCliente(ListaClientes);
            pesquisaCliente.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AgendarCliente agendarCliente = new AgendarCliente(ListaClientes);
            agendarCliente.Show();
        }
    }
}
