namespace POO_AULA04.Classes;

public class Calculadora
{
    // ==========================================
    // ✅ EXERCÍCIO 1 - SOBRECARGA DO MÉTODO SOMAR
    // ==========================================
    
    public int Somar(int a, int b)
    {
        return a + b;
    }

    public double Somar(double a, double b)
    {
        return a + b;
    }

    public int Somar(int a, int b, int c)
    {
        return a + b + c;
    }

    // ==========================================
    // 🚀 DESAFIO EXTRA - SUBTRAIR, MULTIPLICAR, DIVIDIR
    // ==========================================
    
    // --- Subtrair ---
    public int Subtrair(int a, int b) => a - b;
    public double Subtrair(double a, double b) => a - b;

    // --- Multiplicar ---
    public int Multiplicar(int a, int b) => a * b;
    public double Multiplicar(double a, double b) => a * b;

    // --- Dividir ---
    // Nota: Retornar 'double' na divisão de inteiros evita perda de precisão (ex: 5 / 2 = 2.5)
    public double Dividir(int a, int b)
    {
        if (b == 0) throw new DivideByZeroException("Erro: Divisão por zero!");
        return (double)a / b; 
    }
    
    public double Dividir(double a, double b)
    {
        if (b == 0.0) throw new DivideByZeroException("Erro: Divisão por zero!");
        return a / b;
    }
}