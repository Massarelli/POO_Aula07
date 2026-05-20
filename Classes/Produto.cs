namespace POO_AULA04.Classes;

public class Produto
{
    // Propriedades (Atributos)
    public string? Nome { get; private set; }
    public double Preco { get; private set; }
    public int Estoque { get; private set; }
    private bool SemDados { get; set; } // Flag para controle interno

    // ==========================================
    // ✅ EXERCÍCIO 2 - SOBRECARGA DE CONSTRUTORES
    // ==========================================

    // Construtor 1: Sem parâmetros
    public Produto()
    {
        SemDados = true;
    }

    // Construtor 2: Apenas Nome
    public Produto(string nome)
    {
        ValidarNome(nome);
        Nome = nome;
        SemDados = false;
    }

    // Construtor 3: Nome, Preço e Estoque (Com Validações - 🚀 Desafio Extra)
    public Produto(string nome, double preco, int estoque)
    {
        ValidarNome(nome);
        if (preco < 0) throw new ArgumentException("Erro: O preço não pode ser negativo!");
        if (estoque < 0) throw new ArgumentException("Erro: O estoque não pode ser negativo!");

        Nome = nome;
        Preco = preco;
        Estoque = estoque;
        SemDados = false;
    }

    // ==========================================
    // MÉTODOS AUXILIARES
    // ==========================================

    private void ValidarNome(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            throw new ArgumentException("Erro: O nome do produto não pode ficar em branco!");
        }
    }

    // Método para formatar a saída conforme o exemplo esperado
    public string Exibir()
    {
        if (SemDados)
            return "Produto criado sem dados";
        
        if (Preco == 0 && Estoque == 0)
            return $"Produto: {Nome}";
        
        return $"Produto: {Nome} - R$ {Preco}";
    }
}