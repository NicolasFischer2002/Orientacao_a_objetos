using Orientacao_a_objetos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_a_objetos.Classes
{
    internal class VendaBoleto : Venda, IVenda
    {
        public DateOnly DataVencimento { get; }

        public VendaBoleto(MetodoVenda metodo, float valor, int parcelas, DateTime momentoVenda, string documentoCliente, string documentoVendedor, 
            string codigoIdentificacao, DateOnly dataVencimento) 
            : base(metodo, valor, parcelas, momentoVenda, documentoCliente, documentoVendedor, codigoIdentificacao)
        {
            DataVencimento = dataVencimento;
        }

        public void FazVenda()
        {
            Console.WriteLine("Venda no boleto efetuada com sucesso!");
        }

        public void CancelaVenda()
        {
            Console.WriteLine("Venda no boleto cancelada com sucesso!");
        }

        public void EstornaVenda()
        {
            Console.WriteLine("Venda no boleto estornada com sucesso!");
        }
    }
}
