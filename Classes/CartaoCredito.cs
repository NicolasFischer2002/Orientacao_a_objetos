using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_a_objetos.Classes
{
    /// <summary>
    /// Classe abstrata que representa um cartão de crédito genérico. Define propriedades e comportamentos comuns a todos os cartões.
    /// </summary>
    internal abstract class CartaoCredito
    {
        /// <summary>
        /// Enumeração dos tipos de cartão de crédito disponíveis.
        /// </summary>
        public enum TiposCartao
        {
            Pessoal,
            Corporativo
        }

        /// <summary>
        /// Enumeração das bandeiras de cartão de crédito aceitas.
        /// </summary>
        public enum Bandeiras
        {
            Cielo,
            MasterCard,
            Visa
        }

        /// <summary>
        /// Tipo do cartão (Pessoal ou Corporativo).
        /// </summary>
        protected string Tipo { get; }
        protected string Numero { get; }
        /// <summary>
        /// Código de segurança do cartão.
        /// </summary>
        protected int CVV { get; }
        protected DateOnly Vencimento { get; }
        protected string Bandeira { get; }
        protected bool Internacional { get; }

        /// <summary>
        /// Construtor da classe abstrata CartaoCredito.
        /// </summary>
        /// <param name="tipoCartao">Tipo do cartão (Pessoal ou Corporativo).</param>
        /// <param name="numero">Número do cartão de crédito.</param>
        /// <param name="cvv">Código de segurança do cartão.</param>
        /// <param name="vencimento">Data de vencimento do cartão.</param>
        /// <param name="bandeira">Bandeira do cartão de crédito.</param>
        /// <param name="internacional">Indica se o cartão é internacional.</param>
        /// <exception cref="ArgumentException">Lançada quando algum dos parâmetros não atende aos critérios de validação.</exception>
        /// <exception cref="ArgumentNullException">Lançada quando a bandeira do cartão é nula ou vazia.</exception>
        protected CartaoCredito(TiposCartao tipoCartao, string numero, int cvv, DateOnly vencimento, string bandeira, bool internacional)
        {
            if (numero.Length != 16)
                throw new ArgumentException("Número do cartão inválido!");

            // Fica estipulado que o CVV dos cartões podem ter apenas 3 dígitos
            if (cvv <= 99 || cvv >= 1000)
                throw new ArgumentException("CVV deve ter 3 dígitos!");

            if (string.IsNullOrEmpty(bandeira))
                throw new ArgumentNullException("Bandeira do cartão não pode ser nula!");
            
            Tipo = tipoCartao.ToString();
            Numero = numero;
            CVV = cvv;
            Vencimento = vencimento;
            Bandeira = bandeira;
            Internacional = internacional;
        }
    }
}
