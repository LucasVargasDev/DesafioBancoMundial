public abstract class Conta
{
    public Pessoa Pessoa { get; set; }
    public long Numero { get; set; }
    public int Agencia { get; set; }
    public double Saldo { get; set; }
    public double TaxaSaque { get; set; }

    public Conta(Pessoa pessoa, long numero, int agencia, double saldo, double taxaSaque)
    {
        Pessoa = pessoa;
        Numero = numero;
        Agencia = agencia;
        Saldo = saldo;
        TaxaSaque = taxaSaque;
    }

    public Conta(Pessoa pessoa, long numero, int agencia, double taxaSaque)
    {
        Pessoa = pessoa;
        Numero = numero;
        Agencia = agencia;
        Saldo = 0;
        TaxaSaque = taxaSaque;
    }

    public abstract void Sacar(double valor);

    public abstract double ConsultarSaldo();

    public abstract void Transferir(Conta conta, double valor);
}