using Orientacao_a_objetos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_a_objetos.Classes
{
    internal class VendaCreditoCartaoPessoal : Venda, IVenda
    {
        public CartaoCreditoPessoal CartaoCreditoPessoal { get; }

        public VendaCreditoCartaoPessoal(MetodoVenda metodo, float valor, int parcelas, DateTime momentoVenda, string documentoCliente, 
            string documentoVendedor, string codigoIdentificacao, CartaoCreditoPessoal cartaoCreditoPessoal) 
            : base(metodo, valor, parcelas, momentoVenda, documentoCliente, documentoVendedor, codigoIdentificacao)
        {
            CartaoCreditoPessoal = cartaoCreditoPessoal;
        }

        public void FazVenda()
        {
            Console.WriteLine("\nVenda no cartão de crédito pessoal efetuada com sucesso!");
        }

        public void CancelaVenda()
        {
            Console.WriteLine("\nVenda no cartão de crédito pessoal cancelada com sucesso!");
        }

        public void EstornaVenda()
        {
            Console.WriteLine("\nVenda no cartão de crédito pessoal estornada com sucesso!");
        }
    }
}
