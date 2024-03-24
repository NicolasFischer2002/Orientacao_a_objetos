using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_a_objetos.Classes
{
    internal abstract class CartaoCredito
    {
        public enum TiposCartao
        {
            Pessoal,
            Corporativo
        }

        public enum Bandeiras
        {
            Cielo,
            MasterCard,
            Visa
        }

        protected string Tipo { get; }
        protected string Numero { get; }
        protected int CVV { get; }
        protected DateOnly Vencimento { get; }
        protected string Bandeira { get; }
        protected bool Internacional { get; }

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
