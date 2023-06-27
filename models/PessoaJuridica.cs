using System;
using System.Collections.Generic;

public class PessoaJuridica : Pessoa
{
    public List<PessoaFisica> Socios { get; set; }
    public string RazaoSocial { get; set; }
    public string NomeFantasia { get; set; }
    public int Cnpj { get; set; }
    public int InscrEstadual { get; set; }
    public double Faturamento { get; set; }
    public DateTime DataAbertura { get; set; }

    public PessoaJuridica(
      List<PessoaFisica> socios,
      string razaoSocial,
      string nomeFantasia,
      int cnpj,
      int inscrEstadual,
      double faturamento,
      DateTime dataAbertura,
      int numeroDePessoas,
      int id,
      string endereco,
      string email,
      string tel
    ) : base(numeroDePessoas, id, endereco, email, tel)
    {
        Socios = socios;
        RazaoSocial = razaoSocial;
        NomeFantasia = nomeFantasia;
        Cnpj = cnpj;
        InscrEstadual = inscrEstadual;
        Faturamento = faturamento;
        DataAbertura = dataAbertura;
    }

    public override int getIdade()
    {
        return Auxiliar.CalculaIdade(this.DataAbertura);
    }
}