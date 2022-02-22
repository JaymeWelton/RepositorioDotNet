using static System.Console;

Pessoa p1 = new Pessoa();

p1.Nome = "Ricardo";
p1.Idade = 30;
p1.EnderecoPessoa = new Endereco()
{
    Logradouro = "Rua teste",
    CEP = "00000",
    Cidade = "São Paulo",
    Numero = 300
};

WriteLine("Fim");