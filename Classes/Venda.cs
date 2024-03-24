using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_a_objetos.Classes
{
    internal abstract class Venda
    {
        public enum MetodoVenda
        {
            Credito,
            Boleto,
            Deposito,            
        }

        protected string Metodo { get; }
        protected float Valor { get; }
        protected int Parcelas { get; }
        protected DateTime Momento { get; }
        protected string DocumentoCliente { get; }
        protected string DocumentoVendedor { get; }
        protected string CodigoIdentificacaoVeiculo { get; }

        public Venda(MetodoVenda metodo, float valor, int parcelas, DateTime momentoVenda, string documentoCliente, string documentoVendedor,
            string codigoIdentificacao)
        {
            if (valor <= 0)
                throw new ArgumentException("O valor da venda deve ser positivo");

            // Fica definido que o limite mínimo de parcelas para uma venda é 1 parcela, e o máximo é 60 (5 anos)
            if (parcelas < 1 || parcelas > 60)
                throw new ArgumentException("O valor mínimo de parcelas é 1 e o máximo é 60!");

            if (documentoCliente.Length != 11 && documentoCliente.Length != 14)
                throw new ArgumentException("Documento do cliente inválido!");

            if (documentoVendedor.Length != 11 && documentoVendedor.Length != 14)
                throw new ArgumentException("Documento do vendedor inválido!");

            if (codigoIdentificacao.Length != 17)
                throw new ArgumentException("O número de identificação não pode possuir um comprimento diferente de 17 caracteres!");

            Metodo = metodo.ToString();
            Valor = valor;
            Parcelas = parcelas;
            Momento = momentoVenda;
            DocumentoCliente = documentoCliente;
            DocumentoVendedor = documentoVendedor;
            CodigoIdentificacaoVeiculo = codigoIdentificacao;
        }
    }
}
