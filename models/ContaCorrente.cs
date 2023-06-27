public class ContaCorrente : Conta, IDepositavel
{
    public string Tipo;
    public double Limite;
    public double TaxaDolimite;

    public ContaCorrente(
      string tipo,
      PessoaFisica pessoa,
      long numero,
      int agencia,
      double taxaSaque
      ) : base(pessoa, numero, agencia, taxaSaque)
    {
        Tipo = DefineTipo(pessoa.Renda);
        Limite = getLimite(pessoa.Renda);
        TaxaDolimite = getTaxaLimite(Tipo);
    }

    public ContaCorrente(
    string tipo,
    double limite,
    PessoaJuridica pessoa,
    long numero,
    int agencia,
    double taxaSaque
    ) : base(pessoa, numero, agencia, taxaSaque)
    {
        Tipo = DefineTipo(pessoa.Faturamento);
        Limite = limite;
        TaxaDolimite = getTaxaLimite(Tipo);
    }

    public override void Sacar(double valor)
    {
        if (base.Saldo < 0)
        {
            base.Saldo -= base.Saldo * TaxaDolimite;
        }
        base.Saldo -= valor;
    }

    public override double ConsultarSaldo()
    {
        return base.Saldo;
    }

    public override void Transferir(Conta conta, double valor) { }

    public void Depositar(double valor)
    {
        base.Saldo += valor;
    }

    public void Pagar() { }

    public double Emprestimo(double valor)
    {
        return valor -= base.Saldo;
    }

    private string DefineTipo(double renda)
    {
        if (renda > 5000.00)
        {
            return "ESPECIAL";
        }

        return "SIMPLES";
    }

    private double getLimite(double valor)
    {
        double porcetagem = (Tipo == "SIMPLES") ? 1.5 : 2.5;
        double limite = valor * porcetagem;

        return limite;
    }

    private double getTaxaLimite(string tipo)
    {
        return (tipo == "SIMPLES") ? 0.95 : 0.98;
    }
}