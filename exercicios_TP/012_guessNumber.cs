using System.Diagnostics.Contracts;

public class GuessNumber
{
    public static void Main()
    {
        Random random = new Random();
        int numberToGuess = random.Next(1, 101);
        int attempts = 0;
        bool guessedCorrectly = false;

        print("Bem-vindo ao jogo de adivinhação!");
        print("Tente adivinhar o número entre 1 e 100.");

        while (!guessedCorrectly) {
            print("Digite seu palpite: ");
            string input = Console.ReadLine();
            int guess;
            if (!int.TryParse(input, out guess) || guess < 1 || guess > 100) {
                print("Entrada inválida. Por favor, insira um número inteiro entre 1 e 100.");
                // Ignora essa rodada e continua para a próxima tentativa
                continue;
            }

            attempts++;

            if (guess < numberToGuess) {
                print("Muito baixo! Tente novamente.");
            } else if (guess > numberToGuess) {
                print("Muito alto! Tente novamente.");
            } else {
                guessedCorrectly = true;
                print($"Parabéns! Você adivinhou o número {numberToGuess} em {attempts} tentativas.");
            }
        }
    }

    public static void print(string message)
    {
        Console.WriteLine(message);
    }
}