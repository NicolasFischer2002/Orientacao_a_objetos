using Orientacao_a_objetos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_a_objetos.Classes
{
    internal class VendaCreditoCartaoCorporativo : Venda, IVenda
    {
        public CartaoCreditoCorporativo CartaoCorporativo { get;}

        public VendaCreditoCartaoCorporativo(MetodoVenda metodo, float valor, int parcelas, DateTime momentoVenda, string documentoCliente, 
            string documentoVendedor, string codigoIdentificacao, CartaoCreditoCorporativo cartaoCorporativo) 
            : base(metodo, valor, parcelas, momentoVenda, documentoCliente, documentoVendedor, codigoIdentificacao)
        {
            CartaoCorporativo = cartaoCorporativo;
        }

        public void FazVenda()
        {
            Console.WriteLine("\nVenda no cartão de crédito corporativo efetuada com sucesso!");
        }

        public void CancelaVenda()
        {
            Console.WriteLine("\nVenda no cartão de crédito corporativo cancelada com sucesso!");
        }

        public void EstornaVenda()
        {
            Console.WriteLine("\nVenda no cartão de crédito corporativo estornada com sucesso!");
        }
    }
}
