using POO_AULA04.Classes;

Calculadora calc = new();

// Criamos o utilizador oficial com dados encapsulados de teste
// 1. Criamos os dados do utilizador
Usuario meuUsuario = new("admin@teste.com", "1234", "9999");

// 2. Criamos o sistema de login e passamos o utilizador para ele proteger
Login sistemaLogin = new(meuUsuario);

// Criamos a instância do serviço de notificações
Notificacao sistemaNotificacao = new();

bool continuar = true;

while (continuar)
{
    Console.Clear(); // Limpa o ecrã
    Console.WriteLine("===================================");
    Console.WriteLine("          SISTEMA CENTRAL          ");
    Console.WriteLine("===================================");
    Console.WriteLine("--- CALCULADORA ---");
    Console.WriteLine("[1 a 4] Operações Matemáticas");
    Console.WriteLine("--- CADASTRO DE PRODUTOS ---");
    Console.WriteLine("[5 a 7] Criar Produtos");
    Console.WriteLine("--- SISTEMA DE LOGIN SEGURO ---");
    Console.WriteLine("[8] Login Simples (Só E-mail)");
    Console.WriteLine("[9] Login Padrão (E-mail e Senha)");
    Console.WriteLine("[10] Login Seguro (Duas Etapas)");
    Console.WriteLine("--- SISTEMA DE NOTIFICAÇÕES ---");
    Console.WriteLine("[11] Enviar Notificação Simples");
    Console.WriteLine("[12] Enviar Notificação para Utilizador");
    Console.WriteLine("[13] Enviar Notificação Urgente");
    Console.WriteLine("===================================");
    Console.WriteLine("[0] Sair");
    Console.WriteLine("===================================");
    Console.Write("Escolha uma opção: ");
    
    string opcao = Console.ReadLine() ?? "";

    if (opcao == "0")
    {
        continuar = false;
        Console.WriteLine("\nEncerrando o sistema. Até logo!");
        break; 
    }

    try
    {
        switch (opcao)
        {
// ===== LÓGICA DA CALCULADORA =====
            case "1":
            case "2":
            case "3":
            case "4":
                Console.Write("Digite o primeiro número: ");
                double num1 = double.Parse(Console.ReadLine() ?? "0");
                
                Console.Write("Digite o segundo número: ");
                double num2 = double.Parse(Console.ReadLine() ?? "0");

                if (opcao == "1") Console.WriteLine($"Resultado: {calc.Somar(num1, num2)}");
                if (opcao == "2") Console.WriteLine($"Resultado: {calc.Subtrair(num1, num2)}");
                if (opcao == "3") Console.WriteLine($"Resultado: {calc.Multiplicar(num1, num2)}");
                if (opcao == "4") Console.WriteLine($"Resultado: {calc.Dividir(num1, num2)}");
                break;

            // ===== LÓGICA DE PRODUTOS =====
            case "5":
                Produto prod1 = new Produto();
                Console.WriteLine(prod1.Exibir());
                break;

            case "6":
                Console.Write("Digite o nome do produto: ");
                string nomeSimples = Console.ReadLine() ?? "";
                
                Produto prod2 = new Produto(nomeSimples);
                Console.WriteLine(prod2.Exibir());
                break;

            case "7":
                Console.Write("Digite o nome do produto: ");
                string nomeCompleto = Console.ReadLine() ?? "";
                
                Console.Write("Digite o preço do produto: ");
                double preco = double.Parse(Console.ReadLine() ?? "0");
                
                Console.Write("Digite o estoque do produto: ");
                int estoque = int.Parse(Console.ReadLine() ?? "0");
                
                Produto prod3 = new Produto(nomeCompleto, preco, estoque);
                Console.WriteLine(prod3.Exibir());
                break;

            // ===== LÓGICA DE LOGIN ENCAPSULADO =====
            case "8":
                Console.Write("Introduza o seu e-mail: ");
                string email1 = Console.ReadLine() ?? "";
                
                // O método recebe o parâmetro, valida internamente e devolve o resultado
                string resultado1 = sistemaLogin.Autenticar(email1);
                Console.WriteLine(resultado1);
                break;

            case "9":
                Console.Write("Introduza o seu e-mail: ");
                string email2 = Console.ReadLine() ?? "";
                
                Console.Write("Introduza a sua senha: ");
                string senha2 = Console.ReadLine() ?? "";
                
                string resultado2 = sistemaLogin.Autenticar(email2, senha2);
                Console.WriteLine(resultado2);
                break;

            case "10":
                Console.Write("Introduza o seu e-mail: ");
                string email3 = Console.ReadLine() ?? "";
                
                Console.Write("Introduza a sua senha: ");
                string senha3 = Console.ReadLine() ?? "";
                
                Console.Write("Introduza o token de segurança (MFA): ");
                string token3 = Console.ReadLine() ?? "";
                
                string resultado3 = sistemaLogin.Autenticar(email3, senha3, token3);
                Console.WriteLine(resultado3);
                break;

            case "11":
                Console.Write("Digite a mensagem: ");
                string msg1 = Console.ReadLine() ?? "";
                
                // Chama o Método 1
                Console.WriteLine(sistemaNotificacao.Enviar(msg1));
                break;

            case "12":
                Console.Write("Digite a mensagem: ");
                string msg2 = Console.ReadLine() ?? "";
                
                Console.Write("Digite o nome do destinatário: ");
                string destinatario = Console.ReadLine() ?? "";
                
                // Chama o Método 2
                Console.WriteLine(sistemaNotificacao.Enviar(msg2, destinatario));
                break;

            case "13":
                Console.Write("Digite a mensagem: ");
                string msg3 = Console.ReadLine() ?? "";
                Console.Write("Digite o nome do destinatário: ");
                string destinatario3 = Console.ReadLine() ?? "";
                Console.Write("É uma notificação urgente? (true/false): ");
                bool urgente3 = bool.Parse(Console.ReadLine() ?? "false");
                // Chama o Método 3
                Console.WriteLine(sistemaNotificacao.Enviar(msg3, destinatario3, urgente3));
                break;

            default:
                Console.WriteLine("Opção inválida ou oculta neste teste! Tente novamente.");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Erro inesperado no sistema: " + ex.Message);
    }

    Console.WriteLine("\n-----------------");
    Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
    Console.ReadKey();
}