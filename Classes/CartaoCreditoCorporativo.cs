using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_a_objetos.Classes
{
    /// <summary>
    /// Classe concreta que representa a implementação de um cartão de crédito corporativo.
    /// </summary>
    internal class CartaoCreditoCorporativo : CartaoCredito
    {
        /// <summary>
        /// Análogo ao ID do cartão corporativo.
        /// </summary>
        public string CodigoCartao { get; }
        public string NomeEmpresa { get; }

        /// <summary>
        /// Construtor da classe CartaoCreditoCorporativo, que inicializa uma instância de CartaoCreditoCorporativo com as informações fornecidas.
        /// </summary>
        /// <param name="tipoCartao">Tipo do cartão.</param>
        /// <param name="numero">Número do cartão.</param>
        /// <param name="cvv">Código de verificação do cartão.</param>
        /// <param name="vencimento">Data de vencimento do cartão.</param>
        /// <param name="bandeira">Bandeira do cartão.</param>
        /// <param name="internacional">Indica se o cartão é internacional.</param>
        /// <param name="codigoCartao">Código do cartão corporativo. Análogo ao ID do cartão corporativo.</param>
        /// <param name="nomeEmpresa">Nome da empresa associada ao cartão corporativo.</param>
        /// <exception cref="ArgumentNullException">Lançada quando o código do cartão corporativo ou o nome da empresa são nulos ou vazios.</exception>
        public CartaoCreditoCorporativo(TiposCartao tipoCartao, string numero, int cvv, DateOnly vencimento, string bandeira, bool internacional, 
            string codigoCartao, string nomeEmpresa) 
            : base(tipoCartao, numero, cvv, vencimento, bandeira, internacional)
        {
            if (string.IsNullOrEmpty(codigoCartao))
                throw new ArgumentNullException("Código do cartão corporativo não pode ser nulo ou vazio!");

            if (string.IsNullOrEmpty(codigoCartao))
                throw new ArgumentNullException("Nome da empresa do cartão corporativo não pode ser nulo ou vazio!");

            CodigoCartao = codigoCartao;
            NomeEmpresa = nomeEmpresa;
        }
    }
}
