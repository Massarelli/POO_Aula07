namespace POO_AULA04.Classes;

public class Notificacao
{
    // ==========================================
    // ✅ EXERCÍCIO 4 - SOBRECARGA (OVERLOAD)
    // ==========================================

    // Método 1: Apenas a mensagem (Notificação de Sistema/Geral)
    public string Enviar(string mensagem)
    {
        // Retorna exatamente o texto esperado no exercício
        return "Mensagem enviada";
    }

    // Método 2: Mensagem e Usuário (Notificação Direta)
    public string Enviar(string mensagem, string usuario)
    {
        return $"Mensagem enviada para {usuario}";
    }

    // Método 3: Mensagem, Usuário e Flag de Urgência (Alerta Crítico)
    public string Enviar(string mensagem, string usuario, bool urgente)
    {
        if (urgente)
        {
            return "Mensagem URGENTE enviada";
        }
        
        // Se não for urgente, reutiliza o formato do Método 2
        return $"Mensagem enviada para {usuario}";
    }
}