using CadastroPessoa.Classes;

// PessoaFisica novaPf = new PessoaFisica();
// PessoaFisica metodosPf = new PessoaFisica();
// Endereco novoEndPf = new Endereco();

// novaPf.Nome = "Sheyenne";
// novaPf.dataNasc = new DateTime(200, 01, 01);
// novaPf.Cpf = "1234567890";
// novaPf.Rendimento = 3500.5f;

// novoEndPf.logradouro = "Rua Fortaleza";
// novoEndPf.numero = 476;
// novoEndPf.complemento = "SENAI Informática";
// novoEndPf.endComercial = true;

// novaPf.Endereco = novoEndPf;

// Console.WriteLine(@$"
// Nome: {novaPf.Nome}
// Endereco: {novaPf.Endereco.logradouro}, {novaPf.Endereco.numero}
// Maior de idade: {metodosPf.validarDataNasc(novaPf.dataNasc)}
// ");


// Console.WriteLine($"Nome: {novaPf.Nome} Nome: {novaPf.Nome}");
// Console.WriteLine("Nome: " + novaPf.Nome + " Nome: " + novaPf.Nome);

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

// Console.WriteLine(metodosPj.ValidarCnpj(novaPj.Cnpj));
Console.WriteLine(@$"
Nome: {novaPj.Nome}
Razão Social: {novaPj.RazaoSocial}
CNPJ: {novaPj.Cnpj}. Válido: {metodosPj.ValidarCnpj(novaPj.Cnpj)}
Endereço: {novaPj.Endereco.logradouro}, Nº {novaPj.Endereco.numero}
Complemento: {novaPj.Endereco.complemento}
");
