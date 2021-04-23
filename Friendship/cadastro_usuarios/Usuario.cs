


public class Usuario
{
    public string Nome { get; set; }
    public string Sobrenome { get; set; }

    public Usuario(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }
    public string ObterNomeCompleto()
    {
        return (Nome + " " + Sobrenome);
    }
}