using CadastroClientes.Entidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CadastroClientes.FormsClientes
{
    public partial class ExcluirCliente : Form
    {
        public List<Cliente> ListaClientes;
        public ExcluirCliente(List<Cliente> ListaClientes)
        {
            InitializeComponent();
            this.ListaClientes = ListaClientes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idExcluir = Convert.ToInt32(txtIDBuscar.Text);
            Cliente cliente = ListaClientes.Find(cliente => cliente.ID == idExcluir);
            ListaClientes.Remove(cliente);
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idBuscar = Convert.ToInt32(txtIDBuscar.Text);
            Cliente cliente = ListaClientes.Find(Cliente => Cliente.ID == idBuscar);

            txtNome.Text = cliente.Nome;
            txtEmail.Text = cliente.Email;
            txtFone.Text = cliente.Fone;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idEditar = Convert.ToInt32(txtIDBuscar.Text);
            Cliente cliente = ListaClientes.Find(Cliente => Cliente.ID == idEditar);


            DialogResult editar = MessageBox.Show("Confirma as ediçoes?", "Mensagem do sistema!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (editar == DialogResult.Yes)
            {
                cliente.Nome = txtNome.Text;
                cliente.Email = txtEmail.Text;
                txtFone.Text = cliente.Fone = txtFone.Text;

                limpaBoxes();
            }
        }
        private void limpaBoxes()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtFone.Clear();

        }
    }
}
