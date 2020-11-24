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
    public partial class AgendarCliente : Form
    {
        private List<Cliente> ListaClientes;
        public AgendarCliente(List<Cliente> ListaClientes)
        {
            InitializeComponent();
            this.ListaClientes = ListaClientes;
            MostraClientes(ListaClientes);
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.NomesClientes = txtNomeCliente.Text;
            cliente.Profissional = comboBProfissional.SelectedItem.ToString();
            cliente.Serviço = comboBServico.SelectedItem.ToString();
            cliente.Agendar = dateTimePicker1.Value;
            cliente.Horario = maskedTextBox1.Text;
            cliente.Comissao = comboComissao.SelectedItem.ToString();
            limpaCampos();

            richTBAgenda.Text = cliente.AgendarCliente();
        }

        private void limpaCampos()
        {
            txtNomeCliente.Clear();
            comboBProfissional.Text = "";
            comboBServico.Text = "";
        }
        private void MostraClientes(List<Cliente> ListaClientes)
        {
            ListaClientes.ForEach(cliente =>
            {
                richTBClientes.AppendText(cliente.NomeCliente());
            });

        }

        private void richTBAgenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBServico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
