using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroClientes.Entidade
{
    public class Cliente
    {
        public int ID { get; set; }
        public String Nome { get; set; }
       
        public String Email { get; set; }

        public String Fone { get; set; }

        public DateTime Agendar { get; set; }
        public String Profissional { get; set; }
        public String Serviço { get; set; }
        public String NomesClientes { get; set; }
        public String Horario { get; set; }
        
        public String Comissao { get; set; }

        public override string ToString()
        {
            return "ID:"+ ID + ", Nome:" + Nome + ", Email:" + Email + ", Fone:" + Fone + "\n";
        }
        public string NomeCliente()
        {
            return "Nome: " + Nome + "\n";
        }
        public string AgendarCliente()
        {
            return "Nome: " + NomesClientes + "\n" + "Data: " + Agendar + "\n"+ "Horário: " + Horario + "\n" + "Profissional: " + Profissional + "\n" + "Serviço: " + Serviço + "\n" + "Comissão:" + Comissao + "\n";
        }
       
    }
    
}


