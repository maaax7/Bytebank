using Bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.Conta
{
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }
        public static float TaxaOperacao { get; private set; }

        private int numero_agencia;
        public int Numero_Agencia
        {
            get { return this.numero_agencia; }
            private set
            {
                if (value > 0)
                {
                    this.numero_agencia = value;
                }
            }
        }

        //private string conta;
        public string Conta { get; set; }

        private double saldo = 100;
        public Cliente Titular { get; set; }

        public ContaCorrente(int numero_agencia, string numero_conta)
        {
            numero_agencia = numero_agencia;
            Conta = numero_conta;

            if (numero_agencia <= 0)
            {
                throw new ArgumentException("Número de agência menor ou igual a zero!", nameof(numero_agencia));
            }

            TotalDeContasCriadas++;
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                throw new SaldoInsuficienteException("Saldo insuficiente para a operação.");
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }

        public override string ToString()
        {
            StringBuilder retorno = new();
            retorno.AppendLine($"Nome do titular da conta: {Titular?.Nome}");
            retorno.AppendLine($"CPF do titular da conta: {Titular?.Cpf}");
            retorno.AppendLine($"Profissão do titular da conta: {Titular?.Profissao}");
            retorno.AppendLine($"Agência: {numero_agencia}");
            retorno.AppendLine($"Conta Corrente: {Conta}");
            retorno.AppendLine($"Saldo R$ {string.Format("{0:0.00}", saldo)}");

            return retorno.ToString();
        }

        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        
    }
}
