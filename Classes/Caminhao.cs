
using Orientacao_a_objetos.Interfaces;

namespace Orientacao_a_objetos.Classes
{
    /// <summary>
    /// Classe concreta que representa a implementação de um Caminhão. Implementação concreta que herda de veículo.
    /// </summary>
    internal class Caminhao : Veiculo, IVeiculo
    {
        /// <summary>
        /// Enumeração que representa os tipos de carroceria de um caminhão.
        /// </summary>
        public enum TiposCarroceria
        {
            Bau,
            Cacamba
        }

        /// <summary>
        /// Enumeração que representa os tipos de suspensão de um caminhão.
        /// </summary>
        public enum TiposSuspensao
        {
            Molas,
            Pneumática,
            FeixeDeMolas,
            Ar,
            MultiLink,
            Independente,
            EixoRígido
        }

        public float CapacidadeCarga { get; }
        public int NumeroEixos { get; }
        private string TipoCarroceria { get; }
        private string TipoSuspensao { get; }
        public float AlturaMaximaPermitida { get; }
        private const string UnidadeMedidaAltura = "m";
        private const float AliquotaIPVA = 0.01f;
        private const string UnidadeMedidaCapacidadeCarga = "Toneladas";

        /// <summary>
        /// Construtor para a classe Caminhao, que inicializa uma instância de caminhão com as informações fornecidas.
        /// </summary>
        /// <param name="codigoIdentificacao">Código de identificação único do caminhão. Herdado de veículo</param>
        /// <param name="montadora">Nome da montadora do caminhão. Herdado de veículo</param>
        /// <param name="modelo">Modelo do caminhão. Herdado de veículo</param>
        /// <param name="anoFabricacao">Ano de fabricação do caminhão. Herdado de veículo</param>
        /// <param name="importado">Indica se o caminhão é importado. Herdado de veículo</param>
        /// <param name="combustivel">Tipo de combustível do caminhão. Herdado de veículo</param>
        /// <param name="capacidadeTanque">Capacidade do tanque de combustível do caminhão. Herdado de veículo</param>
        /// <param name="potencia">Potência do caminhão em cavalos. Herdado de veículo</param>
        /// <param name="cambioAutomatico">Indica se o caminhão possui câmbio automático. Herdado de veículo</param>
        /// <param name="tracao">Tipo de tração do caminhão. Herdado de veículo</param>
        /// <param name="cor">Cor do caminhão. Herdado de veículo</param>
        /// <param name="placa">Placa do caminhão. Herdado de veículo</param>
        /// <param name="numeroPneus">Número de pneus do caminhão. Herdado de veículo</param>
        /// <param name="numeroRetrovisores">Número de retrovisores do caminhão. Herdado de veículo</param>
        /// <param name="numeroLugares">Número de lugares do caminhão. Herdado de veículo</param>
        /// <param name="tabelaFipe">Valor do caminhão de acordo com a Tabela Fipe. Herdado de veículo</param>
        /// <param name="valor">Valor do caminhão. Herdado de veículo</param>
        /// <param name="capacidadeCarga">Capacidade de carga do caminhão em toneladas.</param>
        /// <param name="numeroEixos">Número de eixos do caminhão.</param>
        /// <param name="tipoCarroceria">Tipo de carroceria do caminhão.</param>
        /// <param name="tipoSuspensao">Tipo de suspensão do caminhão.</param>
        /// <param name="alturaMaximaPermitida">Altura máxima permitida para o caminhão em metros.</param>
        /// <exception cref="ArgumentException">Lançada quando algum dos parâmetros não atende aos critérios de validação.</exception>
        public Caminhao(string codigoIdentificacao, string montadora, string modelo, int anoFabricacao, bool importado, TiposCombustivel combustivel, 
            float capacidadeTanque, int potencia, bool cambioAutomatico, Tracoes tracao, Cores cor, string placa, int numeroPneus, int numeroRetrovisores, 
            int numeroLugares, float tabelaFipe, float valor, float capacidadeCarga, int numeroEixos, TiposCarroceria tipoCarroceria, 
            TiposSuspensao tipoSuspensao, float alturaMaximaPermitida) : 
            base(codigoIdentificacao, montadora, modelo, anoFabricacao, importado, combustivel, capacidadeTanque, potencia, cambioAutomatico, 
                tracao, cor, placa, numeroPneus, numeroRetrovisores, numeroLugares, tabelaFipe, valor)
        {
            if (capacidadeCarga <= 0)
                throw new ArgumentException("Capacidade de carga deve ser positiva!");
            
            if (numeroEixos <= 0)
                throw new ArgumentException("Número de eixos deve ser positivo!");

            if (alturaMaximaPermitida <= 0)
                throw new ArgumentException("Altura máxima deve ser positiva!");

            CapacidadeCarga = capacidadeCarga;
            NumeroEixos = numeroEixos;
            TipoCarroceria = tipoCarroceria.ToString();
            TipoSuspensao = tipoSuspensao.ToString();
            AlturaMaximaPermitida = alturaMaximaPermitida;
        }

        /// <summary>
        /// Exibe todas as propriedades do caminhão no Console.
        /// </summary>
        public void Exibe()
        {
            ExibeVeiculo();
            Console.WriteLine($"Capacidade de carga: {CapacidadeCarga} {UnidadeMedidaCapacidadeCarga}");
            Console.WriteLine($"Número de eixos: {NumeroEixos}");
            Console.WriteLine($"Carroceria: {TipoCarroceria}");
            Console.WriteLine($"Suspensão: {TipoSuspensao}");
            Console.WriteLine($"Altura máxima permitida: {AlturaMaximaPermitida} {UnidadeMedidaAltura}");
        }

        /// <summary>
        /// Devolve o quanto o caminhão está acima ou abaixo da tabela fipe.
        /// </summary>
        /// <param name="valorFipe"></param>
        /// <param name="valorVeiculo"></param>
        /// <returns></returns>
        private static float ValorVeiculoMenosFipe(float valorFipe, float valorVeiculo)
        {
            return valorFipe - valorVeiculo;
        }

        /// <summary>
        /// Exibe o quanto o caminhão está acima ou abaixo da tabela fipe no Console.
        /// </summary>
        /// <param name="valorFipe"></param>
        /// <param name="valorVeiculo"></param>
        public void ExibeRelacaoValorFipe(float valorFipe, float valorVeiculo)
        {
            float valor = ValorVeiculoMenosFipe(valorFipe, valorVeiculo);

            if (valor > 0)
                Console.WriteLine($"\nO caminhão está {UnidadeMonetaria} {valor} acima da tabela fipe");
            else if (valor < 0)
                Console.WriteLine($"\nO caminhão está {UnidadeMonetaria} {valor} abaixo da tabela fipe");
            else
                Console.WriteLine("\nO caminhão está de acordo com a tabela fipe");
        }

        /// <summary>
        /// Devolve se um caminhão deve ou não pagar IPVA baseado no seu ano de fabricação.
        /// </summary>
        /// <param name="anoFabricacao"></param>
        /// <returns></returns>
        private static bool PagaIPVA(int anoFabricacao)
        {
            // Diferentemente dos carros, os caminhões deixam de pagar IPVA após 10 anos de fabricação.
            return DateTime.Now.Year - anoFabricacao <= 9 ? true : false;
        }

        /// <summary>
        /// Devolve o valor que o caminhão deve pagar de IPVA baseado no seu valor e no seu ano de fabricação.
        /// </summary>
        /// <param name="anoFabricacao"></param>
        /// <param name="valorFipe"></param>
        /// <returns></returns>
        private static float IPVA(int anoFabricacao, float valorFipe)
        {
            if (PagaIPVA(anoFabricacao))
                return valorFipe * AliquotaIPVA;
            else
                return 0;
        }

        /// <summary>
        /// Exibe o valor que o caminhão deve pagar de IPVA.
        /// </summary>
        /// <param name="anoFabricacao"></param>
        /// <param name="valorFipe"></param>
        public void ExibeIPVA(int anoFabricacao, float valorFipe)
        {
            Console.WriteLine($"IPVA: {UnidadeMonetaria} {IPVA(anoFabricacao, valorFipe)}");
        }
    }
}
