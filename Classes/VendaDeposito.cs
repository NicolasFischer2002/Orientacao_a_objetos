using Orientacao_a_objetos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_a_objetos.Classes
{
    internal class VendaDeposito : Venda, IVenda
    {
        public string BancoCliente { get; }
        public string NumeroContaCliente { get; }
        public string CodigoPagamento { get; }

        public VendaDeposito(MetodoVenda metodo, float valor, int parcelas, DateTime momentoVenda, string documentoCliente, string documentoVendedor, 
            string codigoIdentificacao, string bancoCliente, string numeroContaCliente, string codigoPagamento) 
            : base(metodo, valor, parcelas, momentoVenda, documentoCliente, documentoVendedor, codigoIdentificacao)
        {
            if (string.IsNullOrEmpty(bancoCliente))
                throw new ArgumentNullException("Para transações depósito o banco não pode ser nulo ou vazio!");

            if (string.IsNullOrEmpty(numeroContaCliente))
                throw new ArgumentNullException("Para transações depósito o número da conta do cliente não pode ser nulo ou vazio!");

            if (string.IsNullOrEmpty(codigoPagamento))
                throw new ArgumentNullException("Para transações depósito o codigoPagamento não pode ser nulo ou vazio!");

            BancoCliente = bancoCliente;
            NumeroContaCliente = numeroContaCliente;
            CodigoPagamento = codigoPagamento;
        }

        public void FazVenda()
        {
            Console.WriteLine("\nVenda no depósito efetuada com sucesso!");
        }

        public void CancelaVenda()
        {
            Console.WriteLine("\nVenda no depósito cancelada com sucesso!");
        }

        public void EstornaVenda()
        {
            Console.WriteLine("\nVenda no depósito estornada com sucesso!");
        }
    }
}
