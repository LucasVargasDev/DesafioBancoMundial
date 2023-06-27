public class ContaSalario : Conta
{
    public ContaSalario(Pessoa pessoa, long numero, int agencia, double taxaSaque) : base(pessoa, numero, agencia, taxaSaque) { }

    public override void Sacar(double valor)
    {
        valor -= base.Saldo;
    }

    public override double ConsultarSaldo()
    {
        return base.Saldo;
    }

    public override void Transferir(Conta conta, double valor) { }
}