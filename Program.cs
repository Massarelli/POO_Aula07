using System;
using POO_AULA04.Classes;

// ==========================================
// INICIALIZAÇÃO DOS SISTEMAS
// ==========================================
Calculadora calc = new();
Usuario meuUsuario = new("admin@teste.com", "1234", "9999");
Login sistemaLogin = new(meuUsuario);
Notificacao sistemaNotificacao = new();

bool rodarSistema = true;

// ==========================================
// LOOP DO MENU PRINCIPAL
// ==========================================
while (rodarSistema)
{
    Console.Clear();
    Console.WriteLine("===================================");
    Console.WriteLine("          SISTEMA CENTRAL          ");
    Console.WriteLine("===================================");
    Console.WriteLine("[1] Módulo Calculadora");
    Console.WriteLine("[2] Módulo Cadastro de Produtos");
    Console.WriteLine("[3] Módulo Sistema de Login");
    Console.WriteLine("[4] Módulo Sistema de Notificações");
    Console.WriteLine("===================================");
    Console.WriteLine("[0] Sair do Sistema");
    Console.WriteLine("===================================");
    Console.Write("Escolha um módulo: ");
    
    string opcaoPrincipal = Console.ReadLine() ?? "";

    if (opcaoPrincipal == "0")
    {
        rodarSistema = false;
        Console.WriteLine("\nEncerrando o sistema. Até logo!");
        break; 
    }

    try
    {
        switch (opcaoPrincipal)
        {
            case "1":
                // ==========================================
                // SUBMENU: CALCULADORA
                // ==========================================
                bool menuCalc = true;
                while (menuCalc)
                {
                    Console.Clear();
                    Console.WriteLine("--- CALCULADORA ---");
                    Console.WriteLine("[1] Somar");
                    Console.WriteLine("[2] Subtrair");
                    Console.WriteLine("[3] Multiplicar");
                    Console.WriteLine("[4] Dividir");
                    Console.WriteLine("[0] Voltar ao Menu Principal");
                    Console.Write("Escolha: ");
                    
                    string opCalc = Console.ReadLine() ?? "";
                    if (opCalc == "0") { menuCalc = false; continue; }

                    if (opCalc == "1" || opCalc == "2" || opCalc == "3" || opCalc == "4")
                    {
                        Console.Write("Digite o primeiro número: ");
                        double num1 = double.Parse(Console.ReadLine() ?? "0");
                        
                        Console.Write("Digite o segundo número: ");
                        double num2 = double.Parse(Console.ReadLine() ?? "0");

                        if (opCalc == "1") Console.WriteLine($"Resultado: {calc.Somar(num1, num2)}");
                        if (opCalc == "2") Console.WriteLine($"Resultado: {calc.Subtrair(num1, num2)}");
                        if (opCalc == "3") Console.WriteLine($"Resultado: {calc.Multiplicar(num1, num2)}");
                        if (opCalc == "4") Console.WriteLine($"Resultado: {calc.Dividir(num1, num2)}");
                    }
                    else { Console.WriteLine("Opção inválida!"); }
                    
                    Console.ReadKey();
                }
                break;

            case "2":
                // ==========================================
                // SUBMENU: PRODUTOS
                // ==========================================
                bool menuProd = true;
                while (menuProd)
                {
                    Console.Clear();
                    Console.WriteLine("--- CADASTRO DE PRODUTOS ---");
                    Console.WriteLine("[1] Criar Produto Vazio");
                    Console.WriteLine("[2] Criar Produto com Nome");
                    Console.WriteLine("[3] Criar Produto Completo");
                    Console.WriteLine("[0] Voltar ao Menu Principal");
                    Console.Write("Escolha: ");
                    
                    string opProd = Console.ReadLine() ?? "";
                    if (opProd == "0") { menuProd = false; continue; }

                    switch (opProd)
                    {
                        case "1":
                            Produto prod1 = new Produto();
                            Console.WriteLine(prod1.Exibir());
                            break;
                        case "2":
                            Console.Write("Digite o nome do produto: ");
                            Produto prod2 = new Produto(Console.ReadLine() ?? "");
                            Console.WriteLine(prod2.Exibir());
                            break;
                        case "3":
                            Console.Write("Digite o nome do produto: ");
                            string nome = Console.ReadLine() ?? "";
                            Console.Write("Digite o preço: ");
                            double preco = double.Parse(Console.ReadLine() ?? "0");
                            Console.Write("Digite o estoque: ");
                            int estoque = int.Parse(Console.ReadLine() ?? "0");
                            
                            Produto prod3 = new Produto(nome, preco, estoque);
                            Console.WriteLine(prod3.Exibir());
                            break;
                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                    Console.ReadKey();
                }
                break;

            case "3":
                // ==========================================
                // SUBMENU: LOGIN
                // ==========================================
                bool menuLogin = true;
                while (menuLogin)
                {
                    Console.Clear();
                    Console.WriteLine("--- SISTEMA DE LOGIN ---");
                    Console.WriteLine("[1] Login Simples (Só E-mail)");
                    Console.WriteLine("[2] Login Padrão (E-mail e Senha)");
                    Console.WriteLine("[3] Login Seguro (Duas Etapas)");
                    Console.WriteLine("[0] Voltar ao Menu Principal");
                    Console.Write("Escolha: ");
                    
                    string opLogin = Console.ReadLine() ?? "";
                    if (opLogin == "0") { menuLogin = false; continue; }

                    switch (opLogin)
                    {
                        case "1":
                            Console.Write("Introduza o seu e-mail: ");
                            Console.WriteLine(sistemaLogin.Autenticar(Console.ReadLine() ?? ""));
                            break;
                        case "2":
                            Console.Write("Introduza o seu e-mail: ");
                            string email2 = Console.ReadLine() ?? "";
                            Console.Write("Introduza a sua senha: ");
                            string senha2 = Console.ReadLine() ?? "";
                            Console.WriteLine(sistemaLogin.Autenticar(email2, senha2));
                            break;
                        case "3":
                            Console.Write("Introduza o seu e-mail: ");
                            string email3 = Console.ReadLine() ?? "";
                            Console.Write("Introduza a sua senha: ");
                            string senha3 = Console.ReadLine() ?? "";
                            Console.Write("Introduza o token (MFA): ");
                            string token3 = Console.ReadLine() ?? "";
                            Console.WriteLine(sistemaLogin.Autenticar(email3, senha3, token3));
                            break;
                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                    Console.ReadKey();
                }
                break;

            case "4":
                // ==========================================
                // SUBMENU: NOTIFICAÇÕES
                // ==========================================
                bool menuNotif = true;
                while (menuNotif)
                {
                    Console.Clear();
                    Console.WriteLine("--- SISTEMA DE NOTIFICAÇÕES ---");
                    Console.WriteLine("[1] Enviar Notificação Simples");
                    Console.WriteLine("[2] Enviar para Destinatário Específico");
                    Console.WriteLine("[3] Enviar Alerta Urgente");
                    Console.WriteLine("[0] Voltar ao Menu Principal");
                    Console.Write("Escolha: ");
                    
                    string opNotif = Console.ReadLine() ?? "";
                    if (opNotif == "0") { menuNotif = false; continue; }

                    switch (opNotif)
                    {
                        case "1":
                            Console.Write("Digite a mensagem: ");
                            Console.WriteLine(sistemaNotificacao.Enviar(Console.ReadLine() ?? ""));
                            break;
                        case "2":
                            Console.Write("Digite a mensagem: ");
                            string msg2 = Console.ReadLine() ?? "";
                            Console.Write("Digite o destinatário: ");
                            string dest2 = Console.ReadLine() ?? "";
                            Console.WriteLine(sistemaNotificacao.Enviar(msg2, dest2));
                            break;
                        case "3":
                            Console.Write("Digite a mensagem: ");
                            string msg3 = Console.ReadLine() ?? "";
                            Console.Write("Digite o destinatário: ");
                            string dest3 = Console.ReadLine() ?? "";
                            Console.Write("É uma notificação urgente? (true/false): ");
                            bool urgente3 = bool.Parse(Console.ReadLine() ?? "false");
                            Console.WriteLine(sistemaNotificacao.Enviar(msg3, dest3, urgente3));
                            break;
                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                    Console.ReadKey();
                }
                break;

            default:
                Console.WriteLine("\nMódulo inválido! Tente novamente.");
                Console.WriteLine("Pressione qualquer tecla...");
                Console.ReadKey();
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("\nErro inesperado: " + ex.Message);
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}