using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_a_objetos.Classes
{
    internal abstract class Veiculo
    {
        public enum TiposCombustivel
        {
            Flex,
            Gasolina,
            Etanol,
            Eletricidade
        }

        public enum Cores
        {
            Preto,
            Branco,
            Prata,
            Verde,
            Azul
        }

        public string CodigoIdentificacao { get; }
        public int AnoFabricacao { get; }
        public bool Importado {  get; }
        public string Combustivel { get; }
        public string Cor { get; }
        public string Placa {  get; }
        public int NumeroPneus { get; }
        public int NumeroRetrovisores { get; }
        public int Potencia { get; }
        public float Valor {  get; }
        protected const string UnidadeMedidaPotencia = "CV";

        public Veiculo(string codigoIdentificacao, int anoFabricacao, bool importado, TiposCombustivel combustivel, Cores cor, string placa, int numeroPneus, 
            int numeroRetrovisores, int potencia, float valor)
        {
            if (codigoIdentificacao.Length != 17)
                throw new ArgumentException("O número de identificação não pode possuir um comprimento diferente de 17 caracteres!");

            if (anoFabricacao < 1769)
                throw new ArgumentException("Nenhum carro foi fabricado antes de 1769!");

            if (string.IsNullOrEmpty(placa))
                throw new ArgumentException("A placa não pode ser nula ou vazia!");

            if (numeroPneus <= 1)
                throw new ArgumentException("O número mínimo de pneus para um veículo é 2!");

            if (numeroRetrovisores <= 1)
                throw new ArgumentException("O número mínimo de retrovisores é 2");

            if (potencia <= 0)
                throw new ArgumentException("O veículo deve possuir uma potência positiva!");

            if (valor <= 0)
                throw new ArgumentException("O valor precisa ser positivo");

            CodigoIdentificacao = codigoIdentificacao;
            AnoFabricacao = anoFabricacao;
            Importado = importado;
            Combustivel = combustivel.ToString();
            Cor = cor.ToString();
            Placa = placa;
            NumeroPneus = numeroPneus;
            NumeroRetrovisores = numeroRetrovisores;
            Potencia = potencia;
            Valor = valor;
        }
    }
}
