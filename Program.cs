using CadastroPessoa.Classes;

Console.Clear();
Console.WriteLine(@$"
===========================================
|    Bem vindo ao sistema de cadastro de  |
|        Pessoas Fisicas e Juridicas      |
===========================================
");

BarraCarregamento("Iniciando", 100, 40);


string? opcao;
do
{
    Console.Clear();
    Console.WriteLine(@$"
============================================
|    Escolha uma das opções abaixo         |
|------------------------------------------|
|       1 - Pessoa Fisica                  |
|       2 - Pessoa Juridica                |
|                                          |
|       0 - Sair                           |
============================================
");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            PessoaFisica novaPf = new PessoaFisica();
            PessoaFisica metodosPf = new PessoaFisica();
            Endereco novoEndPf = new Endereco();

            novaPf.Nome = "Sheyenne";
            novaPf.dataNasc = new DateTime(200, 01, 01);
            novaPf.Cpf = "1234567890";
            novaPf.Rendimento = 3500.5f;

            novoEndPf.logradouro = "Rua Fortaleza";
            novoEndPf.numero = 476;
            novoEndPf.complemento = "SENAI Informática";
            novoEndPf.endComercial = true;

            novaPf.Endereco = novoEndPf;

            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPf.Nome}
Endereco: {novaPf.Endereco.logradouro}, {novaPf.Endereco.numero}
Maior de idade: {(metodosPf.validarDataNasc(novaPf.dataNasc) ? "Sim" : "Não")}
Imposto a ser pago: {metodosPf.PagarImposto(novaPf.Rendimento).ToString("C")}
");

            Console.WriteLine($"Nome: {novaPf.Nome} Nome: {novaPf.Nome}");
            Console.WriteLine("Nome: " + novaPf.Nome + " Nome: " + novaPf.Nome);
            
            Console.WriteLine($"Aperte ENTER para continuar");
            Console.ReadLine();

            break;

        case "2":
            PessoaJuridica novaPj = new PessoaJuridica();
            PessoaJuridica metodoPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            novaPj.Nome = "Nome Pj";
            novaPj.RazaoSocial = "Razao Social Pj";
            novaPj.Cnpj = "00.000.000/0001-00";
            novaPj.Rendimento = 10000.5f;

            novoEndPj.logradouro = "Rua Santa Maria Bertila";
            novoEndPj.numero = 476;
            novoEndPj.complemento = "Senai Informática";
            novoEndPj.endComercial = true;

            novaPj.Endereco = novoEndPj;

            Console.Clear();
            // Console.WriteLine(metodosPj.ValidarCnpj(novaPj.Cnpj));
            Console.WriteLine(@$"
Nome: {novaPj.Nome}
Razão Social: {novaPj.RazaoSocial}
CNPJ: {novaPj.Cnpj}. Válido: {(metodosPj.ValidarCnpj(novaPj.Cnpj)} ? "Sim" : "Não")}
Endereço: {novaPj.Endereco.logradouro}, Nº {novaPj.Endereco.numero}
Complemento: {novaPj.Endereco.complemento}
Imposto a ser pago: {metodosPJ.PagarImposto(novaPj.Rendimento).ToString("C")}
");

            Console.WriteLine($"Aperte ENTER para continuar");
            Console.ReadLine();

            break;

        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar nosso sistema!");
            Thread.Sleep(3000);

            BarraCarregamento("Finalizando", 500, 6);

            break;

        default:
            Console.Clear();
            Console.ForegroundColor - ConsoleColor.DarkRed;
            Console.WriteLine($"Opção Inválida, por favor digite uma opção válida");
            Console.ResetColor();
            Thred.Sleep(3000)
            break;
    }
    
} while (opcao !="0");

static void BarraCarregamento(string texto, int tempo, int quantidade)
{
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            
            Console.Write(texto); 
            
            for (var contador = 0; contador < quantidade; contador++)
            {
                Console.Write(".");
                Thread.Sleep(tempo);
            }
            
            Console.ResetColor();
}