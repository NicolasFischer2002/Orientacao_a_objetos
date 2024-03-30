using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_a_objetos.Classes
{
    /// <summary>
    /// Classe concreta que representa a implementação de um cartão de crédito pessoal.
    /// </summary>
    internal class CartaoCreditoPessoal : CartaoCredito
    {
        /// <summary>
        /// Nome do titular do cartão.
        /// </summary>
        public string Nome { get; }

        /// <summary>
        /// Construtor da classe CartaoCreditoPessoal, que inicializa uma instância de CartaoCreditoPessoal com as informações fornecidas.
        /// </summary>
        /// <param name="tipoCartao">Tipo do cartão.</param>
        /// <param name="numero">Número do cartão.</param>
        /// <param name="cvv">Código de verificação do cartão.</param>
        /// <param name="vencimento">Data de vencimento do cartão.</param>
        /// <param name="bandeira">Bandeira do cartão.</param>
        /// <param name="internacional">Indica se o cartão é internacional.</param>
        /// <param name="nomeCartao">Nome do titular do cartão.</param>
        /// <exception cref="ArgumentException">Lançada quando o nome do cartão não atende aos critérios de validação.</exception>
        public CartaoCreditoPessoal(TiposCartao tipoCartao, string numero, int cvv, DateOnly vencimento, string bandeira, bool internacional,
            string nomeCartao) 
            : base(tipoCartao, numero, cvv, vencimento, bandeira, internacional)
        {
            // Fica definido que o tamanho mínimo para um nome é de 2 caracteres, e o máximo de 100
            if (nomeCartao.Length <= 1 || nomeCartao.Length >= 101)
                throw new ArgumentException("Nome inválido!");

            Nome = nomeCartao;
        }
    }
}
