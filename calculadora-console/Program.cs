internal class Program
{
    private static void Main(string[] args)
    {
        double num1, num2, resultado;
        int opcao, escolha, repetir;

        do
        {
            Console.Clear();
            Console.WriteLine("Deseja fazer cálculo com quantos números?");
            Console.WriteLine("1 - Um número");
            Console.WriteLine("2 - Dois números");
            Console.WriteLine("3 - Três números");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Escolha uma opção:");
            escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("--- Calculadora com 1 número ---");
                        Console.WriteLine("Digite um número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("1 - Raiz quadrada");
                        Console.WriteLine("2 - Fatorial");
                        Console.WriteLine("Escolha uma opção: ");
                        opcao = Convert.ToInt32(Console.ReadLine());
                        switch (opcao)
                        {
                            case 1:
                                resultado = Math.Sqrt(num1);
                                Console.WriteLine($"\nRaiz quadrada de {num1} é: {resultado}\n");
                                break;
                            case 2:
                                resultado = 1;
                                for (int i = 1; i <= num1; i++)
                                    resultado *= i;
                                Console.WriteLine($"\nFatorial de {num1} é: {resultado}\n");
                                break;
                            default:
                                Console.WriteLine("Opção inválida.");
                                break;
                        }

                        Console.WriteLine("O que deseja fazer agora?");
                        Console.WriteLine("1 - Repetir este tipo de operação");
                        Console.WriteLine("2 - Voltar ao menu principal");
                        Console.WriteLine("0 - Sair");
                        repetir = Convert.ToInt32(Console.ReadLine());

                    } while (repetir == 1);

                    if (repetir == 0) escolha = 0; // sair do menu principal também
                    break;

                case 2:
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("--- Calculadora com 2 números ---");
                        Console.WriteLine("Digite o primeiro número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número: ");
                        num2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("1 - Adição");
                        Console.WriteLine("2 - Subtração");
                        Console.WriteLine("3 - Multiplicação");
                        Console.WriteLine("4 - Divisão");
                        Console.WriteLine("Escolha uma opção: ");
                        opcao = Convert.ToInt32(Console.ReadLine());

                        switch (opcao)
                        {
                            case 1:
                                resultado = num1 + num2;
                                Console.WriteLine($"\nResultado da adição: {resultado}\n");
                                break;
                            case 2:
                                resultado = num1 - num2;
                                Console.WriteLine($"\nResultado da subtração: {resultado}\n");
                                break;
                            case 3:
                                resultado = num1 * num2;
                                Console.WriteLine($"\nResultado da multiplicação: {resultado} \n");
                                break;
                            case 4:
                                if (num2 != 0)
                                {
                                    resultado = num1 / num2;
                                    Console.WriteLine($"\nResultado da divisão: {resultado} \n");
                                }
                                else
                                {
                                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                                }
                                break;
                            default:
                                Console.WriteLine("Opção inválida.");
                                break;
                        }

                        Console.WriteLine("O que deseja fazer agora?");
                        Console.WriteLine("1 - Repetir este tipo de operação");
                        Console.WriteLine("2 - Voltar ao menu principal");
                        Console.WriteLine("0 - Sair");
                        repetir = Convert.ToInt32(Console.ReadLine());

                    } while (repetir == 1);

                    if (repetir == 0) escolha = 0;
                    break;

                case 3:
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("--- Calculadora com 3 números ---");
                        Console.WriteLine("Digite o primeiro número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o terceiro número: ");
                        double num3 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("1 - Adição");
                        Console.WriteLine("2 - Subtração");
                        Console.WriteLine("3 - Multiplicação");
                        Console.WriteLine("4 - Divisão");
                        Console.WriteLine("Escolha uma opção: ");
                        opcao = Convert.ToInt32(Console.ReadLine());

                        switch (opcao)
                        {
                            case 1:
                                resultado = num1 + num2 + num3;
                                Console.WriteLine($"\nResultado da adição: {resultado} \n");
                                break;
                            case 2:
                                resultado = num1 - num2 - num3;
                                Console.WriteLine($"\nResultado da subtração: {resultado}  \n");
                                break;
                            case 3:
                                resultado = num1 * num2 * num3;
                                Console.WriteLine($"\nResultado da multiplicação: {resultado}  \n");
                                break;
                            case 4:
                                if (num2 != 0 && num3 != 0)
                                {
                                    resultado = num1 / num2 / num3;
                                    Console.WriteLine($"\nResultado da divisão: {resultado}  \n");
                                }
                                else
                                {
                                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                                }
                                break;
                            default:
                                Console.WriteLine("Opção inválida.");
                                break;
                        }

                        Console.WriteLine("O que deseja fazer agora?");
                        Console.WriteLine("1 - Repetir este tipo de operação");
                        Console.WriteLine("2 - Voltar ao menu principal");
                        Console.WriteLine("0 - Sair");
                        repetir = Convert.ToInt32(Console.ReadLine());

                    } while (repetir == 1);

                    if (repetir == 0) escolha = 0;
                    break;

                case 0:
                    Console.WriteLine("Saindo da calculadora. Até logo!");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (escolha != 0);
    }
}