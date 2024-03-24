
using Orientacao_a_objetos.Interfaces;

namespace Orientacao_a_objetos.Classes
{
    internal class Caminhao : Veiculo, IVeiculo
    {
        public enum TiposCarroceria
        {
            Bau,
            Cacamba
        }

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

        public void Exibe()
        {
            ExibeVeiculo();
            Console.WriteLine($"Capacidade de carga: {CapacidadeCarga} {UnidadeMedidaCapacidadeCarga}");
            Console.WriteLine($"Número de eixos: {NumeroEixos}");
            Console.WriteLine($"Carroceria: {TipoCarroceria}");
            Console.WriteLine($"Suspensão: {TipoSuspensao}");
            Console.WriteLine($"Altura máxima permitida: {AlturaMaximaPermitida} {UnidadeMedidaAltura}");
        }

        private static float ValorVeiculoMenosFipe(float valorFipe, float valorVeiculo)
        {
            return valorFipe - valorVeiculo;
        }

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

        private static float IPVA(int anoFabricacao, float valorFipe)
        {
            return (DateTime.Now.Year - anoFabricacao) >= 10 ? 0 : valorFipe * AliquotaIPVA;
        }

        public void ExibeIPVA(int anoFabricacao, float valorFipe)
        {
            Console.WriteLine($"IPVA: {UnidadeMonetaria} {IPVA(anoFabricacao, valorFipe)}");
        }
    }
}
