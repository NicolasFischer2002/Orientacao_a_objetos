using Orientacao_a_objetos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_a_objetos.Classes
{
    internal class Carro : Veiculo, IVeiculo
    {
        public enum Tracoes
        {
            Dianteira,
            Traseira,
            QuatroPorQuatro
        }

        public string Montadora { get; }
        public string Modelo { get; }
        public int TabelaFipe {  get; }
        private string Tracao { get; }
        public int TamanhoPortamala { get; }
        public int NumeroPortas { get; }
        public bool TetoSolar { get; }
        public bool CambioAutomatico { get; }
        public int NumeroLugares { get; }
        private const string UnidadeMonetaria = "R$";
        private const string UnidadeMedidaPortamala = "Litros";
        private const float AliquotaIPVA = 0.04f;

        public Carro(string codigoIdentificacao, int anoFabricacao, bool importado, TiposCombustivel combustivel, Cores cor, string placa, int numeroPneus,
            int numeroRetrovisores, int potencia, float valor, string montadora, string modelo, int tabelaFipe, Tracoes tracao, int tamanhoPortamala, int numeroPortas, 
            bool tetoSolar, bool cambioAutomatico, int numeroLugares) 
            : base(codigoIdentificacao, anoFabricacao, importado, combustivel, cor, placa, numeroPneus, numeroRetrovisores, potencia, valor)
        {
            if (string.IsNullOrEmpty(montadora))
                throw new ArgumentException("O nome da montadora não pode ser nulo ou vazio!");

            if (string.IsNullOrEmpty(modelo))
                throw new ArgumentException("O modelo do carro não pode ser nulo ou vazio!");

            if (tabelaFipe <= 0)
                throw new ArgumentException("O valor de tabela fipe deve ser positivo!");

            if (tamanhoPortamala <= 0)
                throw new ArgumentException("O tamanho do portamala tem que ser positivo!");

            if (numeroPortas <= 0)
                throw new ArgumentException("O número mínimo de portas para um carro é 1!");

            if (numeroLugares <= 0)
                throw new ArgumentException("Nenhum carro pode possuir menos de 1 lugar!");

            Montadora = montadora;
            Modelo = modelo;
            TabelaFipe = tabelaFipe;
            Tracao = tracao.ToString();
            TamanhoPortamala = tamanhoPortamala;
            NumeroPortas = numeroPortas;
            NumeroLugares = numeroLugares;
            TetoSolar = tetoSolar;
            CambioAutomatico = cambioAutomatico;
            NumeroLugares = numeroLugares;
        }

        public void Exibe()
        {
            Console.WriteLine($"\nMontadora: {Montadora}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Tabela fipe: {UnidadeMonetaria}{TabelaFipe}");
            Console.WriteLine($"Tração: {Tracao}");
            Console.WriteLine($"Tamanho do portamala: {TamanhoPortamala} {UnidadeMedidaPortamala}");
            Console.WriteLine($"Número de portas: {NumeroPortas}");
            Console.WriteLine($"Teto solar: {TetoSolar}");
            Console.WriteLine($"Câmbio automático: {CambioAutomatico}");
            Console.WriteLine($"Número de lugares: {NumeroLugares}");
            Console.WriteLine($"Número de chassi: {CodigoIdentificacao}");
            Console.WriteLine($"Ano de fabricação: {AnoFabricacao}");
            Console.WriteLine($"Importado: {Importado}");
            Console.WriteLine($"Combustível: {Combustivel}");
            Console.WriteLine($"Cor: {Cor}");
            Console.WriteLine($"Placa: {Placa}");
            Console.WriteLine($"Número de pneus: {NumeroPneus}");
            Console.WriteLine($"Número de retrovisores: {NumeroRetrovisores}");
            Console.WriteLine($"Potência: {Potencia} {UnidadeMedidaPotencia}");
            Console.WriteLine($"Valor: {UnidadeMonetaria}{Valor}");
        }

        private static float ValorVeiculoMenosFipe(float valorFipe, float valorVeiculo)
        {
            return valorFipe - valorVeiculo;
        }

        public void ExibeRelacaoValorFipe(float valorFipe, float valorVeiculo)
        {
            float valor = ValorVeiculoMenosFipe(valorFipe, valorVeiculo);

            if (valor > 0)
                Console.WriteLine($"\nO carro está {UnidadeMonetaria}{valor} acima da tabela fipe");
            else if (valor < 0)
                Console.WriteLine($"\nO carro está {UnidadeMonetaria}{valor} abaixo da tabela fipe");
            else 
                Console.WriteLine("\nO carro está de acordo com a tabela fipe");
        }

        private static float IPVA(int anoFabricacao, float valorFipe)
        {
            return (DateTime.Now.Year - anoFabricacao) >= 20 ? 0 : valorFipe * AliquotaIPVA;
        }

        public void ExibeIPVA(int anoFabricacao, float valorFipe)
        {
            Console.WriteLine($"IPVA: {UnidadeMonetaria}{IPVA(anoFabricacao, valorFipe)}");
        }
    }
}
