using Orientacao_a_objetos.Interfaces;


namespace Orientacao_a_objetos.Classes
{
    internal class Carro : Veiculo, IVeiculo
    {
        public bool RodasLigaLeve { get; }
        public int TamanhoPortamala { get; }
        public int NumeroPortas { get; }
        public bool TetoSolar { get; }
        private const float AliquotaIPVA = 0.04f;
        private const string UnidadeMedidaPortamala = "Litros";

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

        public void Exibe()
        {
            ExibeVeiculo();
            Console.WriteLine($"Possue rodas de liga leve: {RodasLigaLeve}");
            Console.WriteLine($"Tamanho do portamala: {TamanhoPortamala} {UnidadeMedidaPortamala}");
            Console.WriteLine($"Número de portas: {NumeroPortas}");
            Console.WriteLine($"Teto solar: {TetoSolar}");
            Console.WriteLine($"Número de lugares: {NumeroLugares}");
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
