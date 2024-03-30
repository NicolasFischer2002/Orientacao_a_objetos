

using System.Diagnostics.CodeAnalysis;

namespace Orientacao_a_objetos.Classes
{
    /// <summary>
    /// Classe abstrata que representa um veículo genérico. Define propriedades e comportamentos comuns a todos os veículos.
    /// </summary>
    internal abstract class Veiculo
    {
        /// <summary>
        /// Enumeração que representa os tipos de combustível disponíveis para um veículo.
        /// </summary>
        public enum TiposCombustivel
        {
            Flex,
            Gasolina,
            Etanol,
            Diesel,
            Eletricidade
        }

        /// <summary>
        /// Enumeração que representa as cores disponíveis para um veículo.
        /// </summary>
        public enum Cores
        {
            Preto,
            Branco,
            Prata,
            Verde,
            Azul
        }

        /// <summary>
        /// Enumeração que representa os tipos de tração disponíveis para um veículo.
        /// </summary>
        public enum Tracoes
        {
            Dianteira,
            Traseira,
            QuatroPorQuatro
        }
 
        /// <summary>
        /// Atributo ID não é passado no construtor pois só existirá mediante a atribuição do banco de dados.
        /// Todas as classes concretas que herdarem de veículo já herdarão o id por padrão, evitando a redeclaração
        /// do campo nas demais classes.
        /// </summary>
        public int Id { get; }
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

        /// <summary>
        /// Construtor da classe abstrata Veiculo.
        /// </summary>
        /// <param name="codigoIdentificacao">Código de identificação único do veículo, número do chassi.</param>
        /// <param name="montadora">Nome da montadora do veículo.</param>
        /// <param name="modelo">Modelo do veículo.</param>
        /// <param name="anoFabricacao">Ano de fabricação do veículo.</param>
        /// <param name="importado">Indica se o veículo é importado.</param>
        /// <param name="combustivel">Tipo de combustível do veículo.</param>
        /// <param name="capacidadeTanque">Capacidade do tanque de combustível do veículo.</param>
        /// <param name="potencia">Potência do veículo em cavalos.</param>
        /// <param name="cambioAutomatico">Indica se o veículo possui câmbio automático.</param>
        /// <param name="tracao">Tipo de tração do veículo.</param>
        /// <param name="cor">Cor do veículo.</param>
        /// <param name="placa">Placa do veículo.</param>
        /// <param name="numeroPneus">Número de pneus do veículo.</param>
        /// <param name="numeroRetrovisores">Número de retrovisores do veículo.</param>
        /// <param name="numeroLugares">Número de lugares do veículo.</param>
        /// <param name="tabelaFipe">Valor do veículo de acordo com a Tabela Fipe.</param>
        /// <param name="valor">Valor do veículo.</param>
        /// <exception cref="ArgumentException">Lançada quando algum dos parâmetros não atende aos critérios de validação.</exception>
        /// <exception cref="ArgumentNullException">Lançada quando algum dos parâmetros obrigatórios é nulo ou vazio.</exception> 
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
            Montadora = montadora.Trim().ToUpper(); // Todas as montadoras devem estar em letra maiúscula
            Modelo = modelo.Trim();
            AnoFabricacao = anoFabricacao;
            Importado = importado;
            Combustivel = combustivel.ToString();
            CapacidadeTanque = capacidadeTanque;
            Potencia = potencia;
            CambioAutomatico = cambioAutomatico;
            Cor = cor.ToString();
            Placa = placa.Trim();
            Tracao = tracao.ToString();
            NumeroPneus = numeroPneus;
            NumeroRetrovisores = numeroRetrovisores;
            NumeroLugares = numeroLugares;
            TabelaFipe = tabelaFipe;
            Valor = valor;
        }

        /// <summary>
        /// Exibe as informações do veículo no Console.
        /// </summary>
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
