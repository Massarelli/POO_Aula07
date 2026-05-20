namespace POO_AULA04.Classes;

public class Usuario
{
    // Propriedades com 'private set' (O cofre: só o construtor pode definir os valores)
    public string Email { get; private set; }
    public string Senha { get; private set; }
    public string Token { get; private set; }

    public Usuario(string email, string senha, string token)
    {
        Email = email;
        Senha = senha;
        Token = token;
    }
}