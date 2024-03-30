using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_a_objetos.Interfaces
{
    /// <summary>
    /// Interface responsável por definir comportamentos universais e imprescindíveis para todos os descendentes da classe abstrata venda.
    /// </summary>
    internal interface IVenda
    {
        /// <summary>
        /// Realiza a operação de venda.
        /// </summary>
        public void FazVenda();

        /// <summary>
        /// Cancela a venda realizada.
        /// </summary>
        public void CancelaVenda();

        /// <summary>
        /// Estorna a venda efetuada.
        /// </summary>
        public void EstornaVenda();
    }
}
