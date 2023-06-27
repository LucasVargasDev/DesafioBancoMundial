public abstract class Pessoa
{
    public int NumeroDePessoas { get; set; }
    public int Id { get; set; }
    public string Endereco { get; set; }
    public string Email { get; set; }
    public string Tel { get; set; }

    public Pessoa(int numeroDePessoas, int id, string endereco, string email, string tel)
    {
        NumeroDePessoas = numeroDePessoas;
        Id = id;
        Endereco = endereco;
        Email = email;
        Tel = tel;
    }

    public abstract int getIdade();
}