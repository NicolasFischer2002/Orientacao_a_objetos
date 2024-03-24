

using Orientacao_a_objetos.Classes;

try
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Hello, World!");

    Console.WriteLine("\n═════ Carro ═════");
    Carro carro = new Carro("9BWHE21JX24060831", "Hyundai", "Azera", 2011, true, Veiculo.TiposCombustivel.Gasolina, 75,
         265, true, Veiculo.Tracoes.Dianteira, Veiculo.Cores.Preto, "FET6458", 5, 2, 5, 30000, 35000, true, 469, 4, true);

    carro.Exibe();
    carro.ExibeRelacaoValorFipe(carro.Valor, carro.TabelaFipe);
    carro.ExibeIPVA(carro.AnoFabricacao, carro.TabelaFipe);

    Console.WriteLine("\n═════ Caminhão ═════");
    Caminhao caminhao = new Caminhao("VIN12345678901234", "Volvo", "FH 540", 2023, false, Veiculo.TiposCombustivel.Diesel, 500, 540, true, 
        Veiculo.Tracoes.QuatroPorQuatro, Veiculo.Cores.Prata, "ABC1234", 12, 4, 2, 500000, 550000, 25, 4, Caminhao.TiposCarroceria.Bau, 
        Caminhao.TiposSuspensao.FeixeDeMolas, 4.5f);

    caminhao.Exibe();
    caminhao.ExibeRelacaoValorFipe(caminhao.Valor, caminhao.TabelaFipe);
    caminhao.ExibeIPVA(caminhao.AnoFabricacao, caminhao.TabelaFipe);
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

