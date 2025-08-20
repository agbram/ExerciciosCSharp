int tentativas = 5;
int tentativaAtual = 0;
bool acertou = false;

Random random = new Random();
int numeroAleatorio = random.Next(1, 51);

Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
Console.WriteLine($"Você tem {tentativas} tentativas para adivinhar o número entre 1 e 50.");

while (tentativaAtual < tentativas)
{
    Console.Write("Digite um número: ");
    int numeroUsuario = Convert.ToInt32(Console.ReadLine());

    if (numeroUsuario < 1 || numeroUsuario > 50)
    {
        Console.WriteLine("Número inválido! Digite entre 1 e 50.");
        continue; // Não conta como tentativa
    }

    tentativaAtual++;

    if (numeroUsuario == numeroAleatorio)
    {
        Console.WriteLine($"Parabéns! Você acertou o número {numeroAleatorio} em {tentativaAtual} tentativas.");
        acertou = true;
        break;
    }
    else if (numeroUsuario < numeroAleatorio)
    {
        Console.WriteLine("O número secreto é MAIOR.");
    }
    else
    {
        Console.WriteLine("O número secreto é MENOR.");
    }

    Console.WriteLine($"Tentativas restantes: {tentativas - tentativaAtual}");
}

if (!acertou)
{
    Console.WriteLine($"Suas tentativas acabaram. O número era: {numeroAleatorio}");
}
