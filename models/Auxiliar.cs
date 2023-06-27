using System;

public static class Auxiliar
{
    public static int CalculaIdade(DateTime data)
    {
        int idade = DateTime.Now.Year - data.Year;

        if (DateTime.Now.Month < data.Month || (DateTime.Now.Month == data.Month && DateTime.Now.Day < data.Day))
        {
            idade--;
        }

        return idade;
    }

    public static string FaixaEtaria(int idade)
    {
        if (idade <= 11)
        {
            return "criança";
        }
        else if (idade >= 12 && idade <= 21)
        {
            return "jovem";
        }
        else if (idade >= 22 && idade <= 59)
        {
            return "adulto";
        }
        else
        {
            return "idoso";
        }
    }
}