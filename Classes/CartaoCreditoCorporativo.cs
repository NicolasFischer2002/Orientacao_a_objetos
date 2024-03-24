using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_a_objetos.Classes
{
    internal class CartaoCreditoCorporativo : CartaoCredito
    {
        public string CodigoCartao { get; }
        public string NomeEmpresa { get; }

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
