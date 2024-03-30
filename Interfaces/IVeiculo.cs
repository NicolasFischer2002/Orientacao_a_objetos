using Orientacao_a_objetos.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_a_objetos.Interfaces
{
    /// <summary>
    /// Interface responsável por definir comportamentos universais e imprescindíveis para todos os descendentes da classe abstrata veículo.
    /// </summary>
    internal interface IVeiculo
    {
        /// <summary>
        /// Deve exibir todas as propriedades do veículo concreto implementado pela classe em questão.
        /// </summary>
        public void Exibe();

        /// <summary>
        /// Deve exibir o quanto um veículo concreto está acima ou abaixo do valor estipulado pela tabela fipe.
        /// </summary>
        /// <param name="valorFipe"></param>
        /// <param name="valorVeiculo"></param>
        public void ExibeRelacaoValorFipe(float valorFipe, float valorVeiculo);

        /// <summary>
        /// Deve exibir o valor pago de IPVA pelo veículo concreto baseando-se no ano de fabricação e no valor da tabela fipe.
        /// </summary>
        /// <param name="anoFabricacao"></param>
        /// <param name="valorFipe"></param>
        public void ExibeIPVA(int anoFabricacao, float valorFipe);
    }
}
