using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_a_objetos.Classes
{
    internal class CartaoCreditoPessoal : CartaoCredito
    {
        public string Nome { get; }

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
