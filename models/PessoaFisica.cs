using System;

public class PessoaFisica : Pessoa
{
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string Rg { get; set; }
    public string Cpf { get; set; }
    public DateTime DataNasc { get; set; }
    public double Renda { get; set; }

    public PessoaFisica(
      string nome,
      string sobrenome,
      string rg,
      string cpf,
      DateTime dataNasc,
      double renda,
      int numeroDePessoas,
      int id,
      string endereco,
      string email,
      string tel
    ) : base(numeroDePessoas, id, endereco, email, tel)
    {
        Nome = nome;
        Sobrenome = sobrenome;
        Rg = rg;
        Cpf = cpf;
        DataNasc = dataNasc;
        Renda = renda;
    }

    public override int getIdade()
    {
        return Auxiliar.CalculaIdade(this.DataNasc);
    }

    public string getFaixaEtaria(){
      return Auxiliar.FaixaEtaria(this.getIdade());
    }
}