

namespace Orientacao_a_objetos.Classes
{
    internal abstract class Veiculo
    {
        public enum TiposCombustivel
        {
            Flex,
            Gasolina,
            Etanol,
            Diesel,
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

        public enum Tracoes
        {
            Dianteira,
            Traseira,
            QuatroPorQuatro
        }

        public string CodigoIdentificacao { get; }
        public string Montadora { get; }
        public string Modelo { get; }
        public int AnoFabricacao { get; }
        public bool Importado { get; }
        public string Combustivel { get; }
        public float CapacidadeTanque { get; }
        public int Potencia { get; }
        public bool CambioAutomatico { get; }
        public string Tracao { get; }
        public string Cor { get; }
        public string Placa { get; }
        public int NumeroPneus { get; }
        public int NumeroRetrovisores { get; }
        public int NumeroLugares { get; }
        public float TabelaFipe { get; }
        public float Valor { get; }
        protected const string UnidadeMedidaPotencia = "CV";
        protected const string UnidadeMonetaria = "R$";

        public Veiculo(string codigoIdentificacao, string montadora, string modelo, int anoFabricacao, bool importado, TiposCombustivel combustivel, 
            float capacidadeTanque, int potencia, bool cambioAutomatico, Tracoes tracao, Cores cor, string placa, int numeroPneus, int numeroRetrovisores, 
            int numeroLugares, float tabelaFipe, float valor)
        {
            if (codigoIdentificacao.Length != 17)
                throw new ArgumentException("O número de identificação não pode possuir um comprimento diferente de 17 caracteres!");

            if (string.IsNullOrEmpty(montadora))
                throw new ArgumentNullException("Montadora não pode ser nula ou vazia!");

            if (string.IsNullOrEmpty(modelo))
                throw new ArgumentNullException("Modelo não pode ser nulo ou vazio!");

            if (anoFabricacao < 1769)
                throw new ArgumentException("Nenhum carro foi fabricado antes de 1769!");

            if (capacidadeTanque <= 0)
                throw new ArgumentException("Capacidade do tanque de combustível deve ser positiva!");

            if (potencia <= 0)
                throw new ArgumentException("O veículo deve possuir uma potência positiva!");

            if (string.IsNullOrEmpty(placa))
                throw new ArgumentNullException("A placa não pode ser nula ou vazia!");

            if (numeroPneus <= 1)
                throw new ArgumentException("O número mínimo de pneus para um veículo é 2!");

            if (numeroRetrovisores <= 1)
                throw new ArgumentException("O número mínimo de retrovisores é 2");

            if (valor <= 0)
                throw new ArgumentException("O valor precisa ser positivo");

            if (string.IsNullOrEmpty(montadora))
                throw new ArgumentException("O nome da montadora não pode ser nulo ou vazio!");

            if (string.IsNullOrEmpty(modelo))
                throw new ArgumentException("O modelo do carro não pode ser nulo ou vazio!");

            if (tabelaFipe <= 0)
                throw new ArgumentException("O valor de tabela fipe deve ser positivo!");

            CodigoIdentificacao = codigoIdentificacao;
            Montadora = montadora;
            Modelo = modelo;
            AnoFabricacao = anoFabricacao;
            Importado = importado;
            Combustivel = combustivel.ToString();
            CapacidadeTanque = capacidadeTanque;
            Potencia = potencia;
            CambioAutomatico = cambioAutomatico;
            Cor = cor.ToString();
            Placa = placa;
            Tracao = tracao.ToString();
            NumeroPneus = numeroPneus;
            NumeroRetrovisores = numeroRetrovisores;
            NumeroLugares = numeroLugares;
            TabelaFipe = tabelaFipe;
            Valor = valor;
        }

        protected void ExibeVeiculo()
        {
            Console.WriteLine($"\nCódigo de Identificação: {CodigoIdentificacao}");
            Console.WriteLine($"Montadora: {Montadora}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano de Fabricação: {AnoFabricacao}");
            Console.WriteLine($"Importado: {(Importado ? "Sim" : "Não")}");
            Console.WriteLine($"Combustível: {Combustivel}");
            Console.WriteLine($"Capacidade do Tanque: {CapacidadeTanque} litros");
            Console.WriteLine($"Potência: {Potencia} {UnidadeMedidaPotencia}");
            Console.WriteLine($"Câmbio Automático: {(CambioAutomatico ? "Sim" : "Não")}");
            Console.WriteLine($"Cor: {Cor}");
            Console.WriteLine($"Placa: {Placa}");
            Console.WriteLine($"Tração: {Tracao}");
            Console.WriteLine($"Número de Pneus: {NumeroPneus}");
            Console.WriteLine($"Número de Retrovisores: {NumeroRetrovisores}");
            Console.WriteLine($"Número de Lugares: {NumeroLugares}");
            Console.WriteLine($"Tabela Fipe: {UnidadeMonetaria} {TabelaFipe}");
            Console.WriteLine($"Valor: {UnidadeMonetaria} {Valor}");
        }
    }
}
