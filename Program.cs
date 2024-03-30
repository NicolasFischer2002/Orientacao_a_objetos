

using Orientacao_a_objetos.Classes;

try
{
    // Exemplo prático de como montar um objeto da classe concreta Carro herdado da classe abstrata Veiculo
    Carro carro = new Carro("9BWHE21JX24060831", "Hyundai", "Azera", 2011, true, Veiculo.TiposCombustivel.Gasolina, 75,
         265, true, Veiculo.Tracoes.Dianteira, Veiculo.Cores.Preto, "FET6458", 5, 2, 5, 30000, 35000, true, 469, 4, true);

    // Exemplo prático de como montar um objeto da classe concreta Caminhao herdado da classe abstrata Veiculo
    Caminhao caminhao = new Caminhao("VIN12345678901234", "Volvo", "FH 540", 2023, false, Veiculo.TiposCombustivel.Diesel, 500, 540, true,
        Veiculo.Tracoes.QuatroPorQuatro, Veiculo.Cores.Prata, "ABC1234", 12, 4, 2, 500000, 550000, 25, 4, Caminhao.TiposCarroceria.Bau,
        Caminhao.TiposSuspensao.FeixeDeMolas, 4.5f);

    // Antes de realizar a confecção dos objetos relativos à Venda, é necessário confeccionar os objetos que serão anexados na venda
    // Em especial, os cartões, para vendas crédito

    // Exemplo prático de como montar um objeto da classe concreta CartaoCreditoPessoal herdada da classe abstrata CartaoCredito
    CartaoCreditoPessoal cartaoCreditoPessoal = new CartaoCreditoPessoal(CartaoCredito.TiposCartao.Pessoal, "0123456789012345", 100, 
        DateOnly.MaxValue, "Visa", false, "Nicolas C Fischer");

    // Exemplo prático de como montar um objeto da classe concreta CartaoCreditoCorporativo herdada da classe abstrata CartaoCredito
    CartaoCreditoCorporativo cartaoCreditoCorporativo = new CartaoCreditoCorporativo(CartaoCredito.TiposCartao.Corporativo, "0123456789012345",
        101, DateOnly.MaxValue, "Cielo", true, "098765432109876", "Fischer Digital Dynamics");

    // Exemplo prático de como montar um objeto da classe concreta VendaCreditoCartaoPessoal herdada da classe abstrata Venda
    VendaCreditoCartaoPessoal vendaCreditoCartaoPessoal = new VendaCreditoCartaoPessoal(Venda.MetodoVenda.Credito, 35000, 12, DateTime.Now,
        "55928023300", "66920423355", "9BWHE21JX24060831", cartaoCreditoPessoal);

    // Exemplo prático de como montar um objeto da classe concreta VendaCreditoCartaoCorporativo herdada da classe abstrata Venda
    VendaCreditoCartaoCorporativo vendaCreditoCartaoCorporativo = new VendaCreditoCartaoCorporativo(Venda.MetodoVenda.Credito, 550000, 1, DateTime.Now,
        "55928023300", "99925223341", "VIN12345678901234", cartaoCreditoCorporativo);

    // Exemplo prático de como montar um objeto da classe concreta VendaDeposito herdada da classe abstrata Venda
    VendaDeposito vendaDeposito = new VendaDeposito(Venda.MetodoVenda.Deposito, 550000, 1, DateTime.Now, "55928023300", "99925223341", "VIN12345678901234",
        "Nubank", "000001-01", "000001");

    // Exemplo prático de como montar um objeto da classe concreta VendaBoleto herdada da classe abstrata Venda
    VendaBoleto vendaBoleto = new VendaBoleto(Venda.MetodoVenda.Boleto, 35000, 12, DateTime.Now, "55928023300", "66920423355", "9BWHE21JX24060831",
        DateOnly.MaxValue);

    do
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("Digite 1 - Para ver todos os veículos cadastrados");
        Console.WriteLine("Digite 2 - Para ver todos os carros cadastrados");
        Console.WriteLine("Digite 3 - Para ver todos os caminhões cadastrados");
        Console.WriteLine("Digite 4 - Para ir para tela de vendas");
        Console.WriteLine("Digite 0 - Para sair do programa");

        Console.Write("\nDigite o número correspondente à opção desejada: ");
        string? codSelecionado = Console.ReadLine();

        if (!string.IsNullOrEmpty(codSelecionado))
        {
            switch (codSelecionado)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("══════════ Todos os veículos cadastrados ══════════");
                    Console.WriteLine($"\n═════ {carro.Montadora} {carro.Modelo} ═════");
                    carro.Exibe();
                    carro.ExibeRelacaoValorFipe(carro.Valor, carro.TabelaFipe);
                    carro.ExibeIPVA(carro.AnoFabricacao, carro.TabelaFipe);
                    Console.WriteLine($"\n═════ {caminhao.Montadora} {caminhao.Modelo} ═════");
                    caminhao.Exibe();
                    caminhao.ExibeRelacaoValorFipe(caminhao.Valor, caminhao.TabelaFipe);
                    caminhao.ExibeIPVA(caminhao.AnoFabricacao, caminhao.TabelaFipe);
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("══════════ Todos os carros cadastrados ══════════");
                    Console.WriteLine($"\n═════ {carro.Montadora} {carro.Modelo} ═════");
                    carro.Exibe();
                    carro.ExibeRelacaoValorFipe(carro.Valor, carro.TabelaFipe);
                    carro.ExibeIPVA(carro.AnoFabricacao, carro.TabelaFipe);
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("══════════ Todos os caminhões cadastrados ══════════");
                    Console.WriteLine($"\n═════ {caminhao.Montadora} {caminhao.Modelo} ═════");
                    caminhao.Exibe();
                    caminhao.ExibeRelacaoValorFipe(caminhao.Valor, caminhao.TabelaFipe);
                    caminhao.ExibeIPVA(caminhao.AnoFabricacao, caminhao.TabelaFipe);
                    break;

                case "4":
                    Console.Clear();
                    Console.WriteLine("Digite 1 - Para realizar uma venda no cartão de crédito");
                    Console.WriteLine("Digite 2 - Para realizar uma venda no depósito");
                    Console.WriteLine("Digite 3 - Para realizar uma venda no boleto");
                    Console.Write("\nDigite o número correspondente à opção desejada: ");
                    string? codSelecionadoVenda = Console.ReadLine();

                    switch (codSelecionadoVenda)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("Digite 1 - Para cartão pessoal");
                            Console.WriteLine("Digite 2 - Para cartão corporativo");
                            Console.WriteLine("Digite 3 - Para voltar ao menu principal");

                            Console.Write("\nDigite o número correspondente à opção desejada: ");
                            string? codSelecionadoCartao = Console.ReadLine();

                            while (true)
                            {
                                if (codSelecionadoCartao == "1")
                                {
                                    Console.Clear();
                                    vendaCreditoCartaoPessoal.FazVenda();
                                    break;
                                }
                                else if (codSelecionadoCartao == "2")
                                {
                                    Console.Clear();
                                    vendaCreditoCartaoCorporativo.FazVenda();
                                    break;
                                }
                                else if (codSelecionadoCartao == "3")
                                    break;
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Digite 1 - Para cartão pessoal");
                                    Console.WriteLine("Digite 2 - Para cartão corporativo");
                                    Console.WriteLine("Digite 3 - Para voltar ao menu principal");
                                }
                            }
                            break;

                        case "2":
                            Console.Clear();
                            vendaDeposito.FazVenda();
                            break;

                        case "3":
                            Console.Clear();
                            vendaBoleto.FazVenda();
                            break;
                    }
                    break;

                case "0":
                    Console.Clear();
                    Console.WriteLine("Obrigado por participar! :)");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("\nOpção inválida! Por favor, escolha um número válido!");
                    Console.Clear();
                    break;
            }

            Console.WriteLine("\nPrecione enter para continuar...");
            Console.ReadLine();
        }
        else
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nOpção inválida! Precione enter para continuar...");
            Console.ReadLine();
        }

    } while (true);
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
    Console.ReadLine();
}

