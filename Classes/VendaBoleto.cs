using Orientacao_a_objetos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_a_objetos.Classes
{
    /// <summary>
    /// Classe concreta que representa a implementação de uma venda no boleto.
    /// </summary>
    internal class VendaBoleto : Venda, IVenda
    {
        /// <summary>
        /// Data de vencimento do boleto.
        /// </summary>
        public DateOnly DataVencimento { get; }

        /// <summary>
        /// Construtor da classe VendaBoleto, que inicializa uma instância de VendaBoleto com as informações fornecidas.
        /// </summary>
        /// <param name="metodo">O método de venda.</param>
        /// <param name="valor">O valor da venda.</param>
        /// <param name="parcelas">O número de parcelas.</param>
        /// <param name="momentoVenda">O momento da venda.</param>
        /// <param name="documentoCliente">O documento do cliente.</param>
        /// <param name="documentoVendedor">O documento do vendedor.</param>
        /// <param name="codigoIdentificacao">O código de identificação.</param>
        /// <param name="dataVencimento">A data de vencimento do boleto.</param>
        public VendaBoleto(MetodoVenda metodo, float valor, int parcelas, DateTime momentoVenda, string documentoCliente, string documentoVendedor, 
            string codigoIdentificacao, DateOnly dataVencimento) 
            : base(metodo, valor, parcelas, momentoVenda, documentoCliente, documentoVendedor, codigoIdentificacao)
        {
            DataVencimento = dataVencimento;
        }

        /// <summary>
        /// Realiza a venda no método de boleto.
        /// </summary>
        public void FazVenda()
        {
            Console.WriteLine("\nVenda no boleto efetuada com sucesso!");
        }

        /// <summary>
        /// Cancela a venda realizada no método de boleto.
        /// </summary>
        public void CancelaVenda()
        {
            Console.WriteLine("\nVenda no boleto cancelada com sucesso!");
        }

        /// <summary>
        /// Estorna a venda realizada no método de depósito.
        /// </summary>
        public void EstornaVenda()
        {
            Console.WriteLine("\nVenda no boleto estornada com sucesso!");
        }
    }
}
