namespace POO_AULA04.Classes;

public class Login
{
    // A classe Login guarda o utilizador oficial internamente para comparar
    private Usuario _usuarioOficial;

    // Construtor: Injeta o utilizador na classe de Login
    public Login(Usuario usuario)
    {
        _usuarioOficial = usuario;
    }

    // ==========================================
    // ✅ SOBRECARGA DE MÉTODOS DE AUTENTICAÇÃO
    // ==========================================

    public string Autenticar(string email)
    {
        if (email == _usuarioOficial.Email)
            return "✅ Login por email efetuado! Link enviado.";
            
        return "❌ Erro: Email não registado.";
    }

    public string Autenticar(string email, string senha)
    {
        if (email == _usuarioOficial.Email && senha == _usuarioOficial.Senha)
            return "✅ Login com email e senha efetuado com sucesso!";
            
        return "❌ Erro: Email ou senha incorretos.";
    }

    public string Autenticar(string email, string senha, string token)
    {
        if (email == _usuarioOficial.Email && senha == _usuarioOficial.Senha && token == _usuarioOficial.Token)
            return "✅ Login seguro em duas etapas efetuado!";
            
        return "❌ Erro: Credenciais ou Token inválidos.";
    }
}