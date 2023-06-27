using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        List<PessoaFisica> socios = new List<PessoaFisica>();
        socios.Add(
           new PessoaFisica("Lucas", "Vargas", "123", "456", new DateTime(1994, 10, 19), 16000.0, 1, 13, "Brasil", "lv@email.com", "789")
        );
        Console.WriteLine(socios[0].Email);
        Console.WriteLine(socios[0].getIdade());
        Console.WriteLine(socios[0].getFaixaEtaria());

        PessoaJuridica empresa = new PessoaJuridica(
          socios,
          "Empresa Feliz LTDA",
          "Espaço Alegria",
          123,
          456,
          2.0,
          new DateTime(200, 12, 10),
          60,
          8888,
          "Brasil",
          "empres@email.com",
          "789"
        );
        Console.WriteLine(empresa.RazaoSocial);

        ContaCorrente contaC = new ContaCorrente("A", socios[0], 100, 9090, 11.0);
        Console.WriteLine(contaC.Tipo);
    }
}