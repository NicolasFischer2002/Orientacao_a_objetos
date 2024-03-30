using Orientacao_a_objetos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_a_objetos.Classes
{
    /// <summary>
    /// Classe concreta que representa uma venda realizada com cartão de crédito corporativo.
    /// </summary>
    internal class VendaCreditoCartaoCorporativo : Venda, IVenda
    {
        /// <summary>
        /// Cartão de crédito corporativo utilizado na venda.
        /// </summary>
        public CartaoCreditoCorporativo CartaoCorporativo { get;}

        /// <summary>
        /// Construtor da classe VendaCreditoCartaoCorporativo, que inicializa uma instância de VendaCreditoCartaoCorporativo com as informações fornecidas.
        /// </summary>
        /// <param name="metodo">Método de venda utilizado.</param>
        /// <param name="valor">Valor da venda.</param>
        /// <param name="parcelas">Número de parcelas da venda.</param>
        /// <param name="momentoVenda">Momento da realização da venda.</param>
        /// <param name="documentoCliente">Documento do cliente envolvido na venda.</param>
        /// <param name="documentoVendedor">Documento do vendedor responsável pela venda.</param>
        /// <param name="codigoIdentificacao">Código de identificação do veículo vendido.</param>
        /// <param name="cartaoCorporativo">Cartão de crédito corporativo utilizado na venda.</param>
        public VendaCreditoCartaoCorporativo(MetodoVenda metodo, float valor, int parcelas, DateTime momentoVenda, string documentoCliente, 
            string documentoVendedor, string codigoIdentificacao, CartaoCreditoCorporativo cartaoCorporativo) 
            : base(metodo, valor, parcelas, momentoVenda, documentoCliente, documentoVendedor, codigoIdentificacao)
        {
            CartaoCorporativo = cartaoCorporativo;
        }

        /// <summary>
        /// Realiza a venda utilizando cartão de crédito corporativo.
        /// </summary>
        public void FazVenda()
        {
            Console.WriteLine("\nVenda no cartão de crédito corporativo efetuada com sucesso!");
        }

        /// <summary>
        /// Cancela a venda realizada com cartão de crédito corporativo.
        /// </summary>
        public void CancelaVenda()
        {
            Console.WriteLine("\nVenda no cartão de crédito corporativo cancelada com sucesso!");
        }

        /// <summary>
        /// Estorna a venda realizada com cartão de crédito corporativo.
        /// </summary>
        public void EstornaVenda()
        {
            Console.WriteLine("\nVenda no cartão de crédito corporativo estornada com sucesso!");
        }
    }
}
