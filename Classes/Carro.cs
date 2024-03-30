using Orientacao_a_objetos.Interfaces;


namespace Orientacao_a_objetos.Classes
{
    /// <summary>
    /// Classe concreta que representa a implementação de um Carro. Implementação concreta que herda de veículo.
    /// </summary>
    internal class Carro : Veiculo, IVeiculo
    {
        public bool RodasLigaLeve { get; }
        public int TamanhoPortamala { get; }
        public int NumeroPortas { get; }
        public bool TetoSolar { get; }
        private const float AliquotaIPVA = 0.04f;
        private const string UnidadeMedidaPortamala = "Litros";

        /// <summary>
        /// Construtor para a classe Carro, que inicializa uma instância de carro com as informações fornecidas.
        /// </summary>
        /// <param name="codigoIdentificacao">Código de identificação único do carro. Herdado de veículo</param>
        /// <param name="montadora">Nome da montadora do carro. Herdado de veículo</param>
        /// <param name="modelo">Modelo do carro. Herdado de veículo</param>
        /// <param name="anoFabricacao">Ano de fabricação do carro. Herdado de veículo</param>
        /// <param name="importado">Indica se o carro é importado. Herdado de veículo</param>
        /// <param name="combustivel">Tipo de combustível do carro. Herdado de veículo</param>
        /// <param name="capacidadeTanque">Capacidade do tanque de combustível do carro. Herdado de veículo</param>
        /// <param name="potencia">Potência do carro em cavalos. Herdado de veículo</param>
        /// <param name="cambioAutomatico">Indica se o carro possui câmbio automático. Herdado de veículo</param>
        /// <param name="tracao">Tipo de tração do carro. Herdado de veículo</param>
        /// <param name="cor">Cor do carro. Herdado de veículo</param>
        /// <param name="placa">Placa do carro. Herdado de veículo</param>
        /// <param name="numeroPneus">Número de pneus do carro. Herdado de veículo</param>
        /// <param name="numeroRetrovisores">Número de retrovisores do carro. Herdado de veículo</param>
        /// <param name="numeroLugares">Número de lugares do carro. Herdado de veículo</param>
        /// <param name="tabelaFipe">Valor do carro de acordo com a Tabela Fipe. Herdado de veículo</param>
        /// <param name="valor">Valor do carro. Herdado de veículo</param>
        /// <param name="rodasLigaLeve">Indica se o carro possui rodas de liga leve.</param>
        /// <param name="tamanhoPortamala">Tamanho do porta-malas do carro em litros.</param>
        /// <param name="numeroPortas">Número de portas do carro.</param>
        /// <param name="tetoSolar">Indica se o carro possui teto solar.</param>
        /// <exception cref="ArgumentException">Lançada quando algum dos parâmetros não atende aos critérios de validação.</exception>
        public Carro(string codigoIdentificacao, string montadora, string modelo, int anoFabricacao, bool importado, TiposCombustivel combustivel, 
            float capacidadeTanque, int potencia, bool cambioAutomatico, Tracoes tracao, Cores cor, string placa, int numeroPneus, int numeroRetrovisores, 
            int numeroLugares, float tabelaFipe, float valor, bool rodasLigaLeve, int tamanhoPortamala, int numeroPortas, bool tetoSolar)
            : base(codigoIdentificacao, montadora, modelo, anoFabricacao, importado, combustivel, capacidadeTanque, potencia, cambioAutomatico, tracao, cor, 
                  placa, numeroPneus, numeroRetrovisores, numeroLugares, tabelaFipe, valor)
        {
            if (tamanhoPortamala <= 0)
                throw new ArgumentException("O tamanho do portamala tem que ser positivo!");

            if (numeroPortas <= 0)
                throw new ArgumentException("O número mínimo de portas para um carro é 1!");
            
            RodasLigaLeve = rodasLigaLeve;
            TamanhoPortamala = tamanhoPortamala;
            NumeroPortas = numeroPortas;
            TetoSolar = tetoSolar;
        }

        /// <summary>
        /// Exibe todas as propriedades do carro no Console.
        /// </summary>
        public void Exibe()
        {
            ExibeVeiculo();
            Console.WriteLine($"Possue rodas de liga leve: {RodasLigaLeve}");
            Console.WriteLine($"Tamanho do portamala: {TamanhoPortamala} {UnidadeMedidaPortamala}");
            Console.WriteLine($"Número de portas: {NumeroPortas}");
            Console.WriteLine($"Teto solar: {TetoSolar}");
            Console.WriteLine($"Número de lugares: {NumeroLugares}");
        }

        /// <summary>
        /// Devolve o quanto o carro está acima ou abaixo da tabela fipe.
        /// </summary>
        /// <param name="valorFipe"></param>
        /// <param name="valorVeiculo"></param>
        /// <returns></returns>
        private static float ValorVeiculoMenosFipe(float valorFipe, float valorVeiculo)
        {
            return valorFipe - valorVeiculo;
        }

        /// <summary>
        /// Exibe o quanto o carro está acima ou abaixo da tabela fipe no Console.
        /// </summary>
        /// <param name="valorFipe"></param>
        /// <param name="valorVeiculo"></param>
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

        /// <summary>
        ///  Devolve o valor que o carro deve pagar de IPVA baseado no seu valor e no seu ano de fabricação.
        /// </summary>
        /// <param name="anoFabricacao"></param>
        /// <param name="valorFipe"></param>
        /// <returns></returns>
        private static float IPVA(int anoFabricacao, float valorFipe)
        {
            // Diferentemente dos caminhões, os carros deixam de pagar IPVA após 20 anos de fabricação.
            return (DateTime.Now.Year - anoFabricacao) >= 20 ? 0 : valorFipe * AliquotaIPVA;
        }

        /// <summary>
        /// Exibe o valor que o carro deve pagar de IPVA.
        /// </summary>
        /// <param name="anoFabricacao"></param>
        /// <param name="valorFipe"></param>
        public void ExibeIPVA(int anoFabricacao, float valorFipe)
        {
            Console.WriteLine($"IPVA: {UnidadeMonetaria}{IPVA(anoFabricacao, valorFipe)}");
        }
    }
}
