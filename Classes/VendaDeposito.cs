using Orientacao_a_objetos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_a_objetos.Classes
{
    /// <summary>
    /// Classe concreta que representa a implementação de uma venda depósito.
    /// </summary>
    internal class VendaDeposito : Venda, IVenda
    {
        public string BancoCliente { get; }
        public string NumeroContaCliente { get; }
        public string CodigoPagamento { get; }

        /// <summary>
        /// Construtor da classe VendaDeposito, que inicializa uma instância de VendaDeposito com as informações fornecidas.
        /// </summary>
        /// <param name="metodo">O método de venda.</param>
        /// <param name="valor">O valor da venda.</param>
        /// <param name="parcelas">O número de parcelas.</param>
        /// <param name="momentoVenda">O momento da venda.</param>
        /// <param name="documentoCliente">O documento do cliente.</param>
        /// <param name="documentoVendedor">O documento do vendedor.</param>
        /// <param name="codigoIdentificacao">O código de identificação.</param>
        /// <param name="bancoCliente">O banco do cliente.</param>
        /// <param name="numeroContaCliente">O número da conta do cliente.</param>
        /// <param name="codigoPagamento">O código de pagamento.</param>
        /// <exception cref="ArgumentNullException">Exceção lançada quando o banco, o número da conta ou o código de pagamento são nulos ou vazios.</exception>
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

        /// <summary>
        /// Realiza a venda no método de depósito.
        /// </summary>
        public void FazVenda()
        {
            Console.WriteLine("\nVenda no depósito efetuada com sucesso!");
        }

        /// <summary>
        /// Cancela a venda realizada no método de depósito.
        /// </summary>
        public void CancelaVenda()
        {
            Console.WriteLine("\nVenda no depósito cancelada com sucesso!");
        }

        /// <summary>
        /// Estorna a venda realizada no método de depósito.
        /// </summary>
        public void EstornaVenda()
        {
            Console.WriteLine("\nVenda no depósito estornada com sucesso!");
        }
    }
}
