using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.Titular
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

        public Cliente(int numero_agencia, string numero_conta)
        {
            this.Numero_agencia = numero_agencia;
            this.Conta = numero_conta;
        }
    }
}
