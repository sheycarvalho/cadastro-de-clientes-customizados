using CadastroPessoa.Classes;

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

Console.WriteLine(@$"
Nome: {novaPf.Nome}
Endereco: {novaPf.Endereco.logradouro}, {novaPf.Endereco.numero}
Maior de idade: {metodosPf.validarDataNasc(novaPf.dataNasc)}
");


// Console.WriteLine($"Nome: {novaPf.Nome} Nome: {novaPf.Nome}");
// Console.WriteLine("Nome: " + novaPf.Nome + " Nome: " + novaPf.Nome);