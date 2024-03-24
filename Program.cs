

using Orientacao_a_objetos.Classes;

try
{

    /*
     Criar uma classe caminhão e implementar de forma diferente o método de cálculo de IPVA

     Criar classe venda
     Interface para venda: FazVenda, EstornaVenda, CancelaVenda
     Para cada modalidade da venda terá uma implementação diferente, exemplo:
     Faz venda crédito, boleto e depósito
     Estorna venda crédito, boleto e depósito
     Cancela venda crédito, boleto e depósito
     Cada classe concreta terá será obrigada a implementar esses métodos comuns, porém cada qual
     a sua maneira e necessidade
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

