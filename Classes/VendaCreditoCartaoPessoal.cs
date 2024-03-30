using Orientacao_a_objetos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_a_objetos.Classes
{
    /// <summary>
    /// Classe concreta que representa uma venda realizada com cartão de crédito pessoal.
    /// </summary>
    internal class VendaCreditoCartaoPessoal : Venda, IVenda
    {
        /// <summary>
        /// Cartão de crédito pessoal utilizado na venda.
        /// </summary>
        public CartaoCreditoPessoal CartaoCreditoPessoal { get; }

        /// <summary>
        /// Construtor da classe VendaCreditoCartaoPessoal, que inicializa uma instância de VendaCreditoCartaoPessoal com as informações fornecidas.
        /// </summary>
        /// <param name="metodo">Método de venda utilizado.</param>
        /// <param name="valor">Valor da venda.</param>
        /// <param name="parcelas">Número de parcelas da venda.</param>
        /// <param name="momentoVenda">Momento da realização da venda.</param>
        /// <param name="documentoCliente">Documento do cliente envolvido na venda.</param>
        /// <param name="documentoVendedor">Documento do vendedor responsável pela venda.</param>
        /// <param name="codigoIdentificacao">Código de identificação do veículo vendido.</param>
        /// <param name="cartaoCorporativo">Cartão de crédito corporativo utilizado na venda.</param>
        public VendaCreditoCartaoPessoal(MetodoVenda metodo, float valor, int parcelas, DateTime momentoVenda, string documentoCliente, 
            string documentoVendedor, string codigoIdentificacao, CartaoCreditoPessoal cartaoCreditoPessoal) 
            : base(metodo, valor, parcelas, momentoVenda, documentoCliente, documentoVendedor, codigoIdentificacao)
        {
            CartaoCreditoPessoal = cartaoCreditoPessoal;
        }

        /// <summary>
        /// Realiza a venda utilizando cartão de crédito pessoal.
        /// </summary>
        public void FazVenda()
        {
            Console.WriteLine("\nVenda no cartão de crédito pessoal efetuada com sucesso!");
        }

        /// <summary>
        /// Cancela a venda realizada com cartão de crédito pessoal.
        /// </summary>
        public void CancelaVenda()
        {
            Console.WriteLine("\nVenda no cartão de crédito pessoal cancelada com sucesso!");
        }

        /// <summary>
        /// Estorna a venda realizada com cartão de crédito pessoal.
        /// </summary>
        public void EstornaVenda()
        {
            Console.WriteLine("\nVenda no cartão de crédito pessoal estornada com sucesso!");
        }
    }
}
