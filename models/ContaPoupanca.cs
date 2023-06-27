public class ContaPoupanca : Conta, IDepositavel
{

    public ContaPoupanca(Pessoa pessoa, long numero, int agencia, double taxaSaque) : base(pessoa, numero, agencia, taxaSaque) { }

    public override void Sacar(double valor)
    {
        if (valor <= base.Saldo)
        {
            valor -= base.Saldo;
        }
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
}