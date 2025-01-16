using System; // Biblioteca padrão para entrada e saída

class Program{

    static void Saudacao(){
        Console.WriteLine("Seja bem vindo!");
    }
    static void Main(string[] args){
        // Menu Interativo cafeteria
        bool continuar = true; //Vamos controlar o loop do menu com isso
        string bebidaEscolhida = ""; //Usuário vai infomar a bebida
        string acompanhamentoEscolhido = ""; //Usuário vai informar a comida
        decimal total = 0; //Valor que o usuário vai pagar
        
        while (continuar){ 
            Saudacao();
            Console.WriteLine("1: Escolher bebida");
            Console.WriteLine("2: Adicionar acompanhamento");
            Console.WriteLine("3: Exibir pedido e total");
            Console.WriteLine("4: Sair");
            Console.Write("Digite sua opção: ");
            string opcao = Console.ReadLine();

            switch (opcao){
                case "1":
                    Console.WriteLine("Qual bebida? (Café, chá ou suco)");
                    bebidaEscolhida = Console.ReadLine().ToLower();
                        switch (bebidaEscolhida){
                            case "café":
                                bebidaEscolhida = "Café";
                                total += 5.00m;
                                Console.WriteLine("Você escolheu café. (R$ 5.00)");
                                break;
                            case "chá":
                                bebidaEscolhida = "Chá";
                                total += 3.50m;
                                Console.WriteLine("Você escolheu chá. (R$ 3.50)");                            
                                break;
                            case "suco":
                                bebidaEscolhida = "Suco";
                                total += 4.00m;
                                Console.WriteLine("Você escolheu suco. (R$ 4.00)");                                  
                                break;
                            default:
                                Console.WriteLine("Opção de bebida inválida.");
                                break;                                
                        }
                    break;
                case "2":
                    Console.WriteLine("Qual acompanhamento adicionar? (Bolo, croissant ou biscoito)");
                    acompanhamentoEscolhido = Console.ReadLine().ToLower();
                    switch (acompanhamentoEscolhido){
                        case "bolo":
                            acompanhamentoEscolhido = "Bolo";
                            total += 3.50m;
                            Console.WriteLine("Você adicionou bolo. (R$ 3.50)");
                            break;
                        case "croissant":
                            acompanhamentoEscolhido = "Croissant";
                            total += 5.00m;
                            Console.WriteLine("Você adicionou croissant. (R$ 5.00)");
                            break;
                        case "biscoito":
                            acompanhamentoEscolhido = "Biscoito";
                            total += 2.50m;
                            Console.WriteLine("Você adicionou biscoito. (R$ 2.50)");
                            break;
                        default:
                            Console.WriteLine("Opção de bebida inválida.");
                            break;                              
                    }
                    break;
                case "3":
                    Console.WriteLine("Seu pedido:");
                    Console.WriteLine($"Sua bebida: {bebidaEscolhida}");
                    Console.WriteLine($"Seu acompanhamento: {acompanhamentoEscolhido}");
                    Console.WriteLine($"Valor: R$ {total:F2}");
                    break;
                case "4":
                    Console.Write("Você saiu!");
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
                }
                Console.WriteLine();
        }
    }
}