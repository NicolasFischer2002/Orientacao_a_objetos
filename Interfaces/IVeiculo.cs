using Orientacao_a_objetos.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_a_objetos.Interfaces
{
    internal interface IVeiculo
    {
        public void Exibe();

        public void ExibeRelacaoValorFipe(float valorFipe, float valorVeiculo);

        public void ExibeIPVA(int anoFabricacao, float valorFipe);
    }
}
