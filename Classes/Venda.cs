using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_a_objetos.Classes
{
    /// <summary>
    /// Classe abstrata que representa uma venda genérica no sistema. Define propriedades e comportamentos comuns a todas as vendas.
    /// </summary>
    internal abstract class Venda
    {
        /// <summary>
        /// Enumeração que define os métodos de venda disponíveis.
        /// </summary>
        public enum MetodoVenda
        {
            Credito,
            Boleto,
            Deposito,            
        }

        protected string Metodo { get; }
        protected float Valor { get; }
        protected int Parcelas { get; }
        /// <summary>
        /// Momento da realização da venda. Dia, mês, ano, hora, minuto e segundo.
        /// </summary>
        protected DateTime Momento { get; }
        protected string DocumentoCliente { get; }
        protected string DocumentoVendedor { get; }
        /// <summary>
        /// Código de identificação do veículo vendido.
        /// </summary>
        protected string CodigoIdentificacaoVeiculo { get; }

        /// <summary>
        /// Construtor da classe Venda, que inicializa uma instância de uma venda com as informações fornecidas..
        /// </summary>
        /// <param name="metodo">Método de pagamento da venda.</param>
        /// <param name="valor">Valor da venda.</param>
        /// <param name="parcelas">Número de parcelas da venda.</param>
        /// <param name="momentoVenda">Data e hora da venda.</param>
        /// <param name="documentoCliente">Documento do cliente.</param>
        /// <param name="documentoVendedor">Documento do vendedor.</param>
        /// <param name="codigoIdentificacao">Código de identificação do veículo vendido.</param>
        /// <exception cref="ArgumentException">Lançada quando algum dos parâmetros não atende aos critérios de validação.</exception>
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
