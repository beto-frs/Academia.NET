
using DesingPatterns;

Console.WriteLine("Padrão Factory Method");
PessoaFisica pessoaFisica = new PessoaFisica("Pessoa");
PessoaJuridica PessoaJuridica = new PessoaJuridica("Pessoa");

Console.WriteLine($"{pessoaFisica.Nome}-{pessoaFisica.Tipo}\n{PessoaJuridica.Nome} - {PessoaJuridica.Tipo}");