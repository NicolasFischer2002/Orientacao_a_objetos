

using Orientacao_a_objetos.Classes;

try
{

    /*
     Criar classe venda
     */

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Hello, World!");

    Carro carro = new Carro("9BWHE21JX24060831", 2011, true, Veiculo.TiposCombustivel.Gasolina, Veiculo.Cores.Preto, "FET6458",
        4, 2, 265, 35000, "Hyundai", "Azera", 30000,Carro.Tracoes.Dianteira, 469, 4, true, true, 5);

    carro.Exibe();
    carro.ExibeRelacaoValorFipe(carro.Valor, carro.TabelaFipe);
    carro.ExibeIPVA(carro.AnoFabricacao, carro.TabelaFipe);
}
catch (Exception Erro)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"\nErro inesperado: {Erro.Message}");
}
finally
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\nAplicação Finalizada!");
}

