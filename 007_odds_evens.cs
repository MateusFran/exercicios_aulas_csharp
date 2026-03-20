public class OddsEvens
{
    public static void Main()
    {
        print("Digite um número inteiro: ");
        string input = Console.ReadLine();
        int number;
        if (!int.TryParse(input, out number)) {
            print("Entrada inválida. Por favor, insira um número inteiro.");
            return;
        }

        if (number % 2 == 0) {
            print($"O número {number} é par.");
        } else {
            print($"O número {number} é ímpar.");
        }
    }

    public static void print(string message)
    {
        Console.WriteLine(message);
    }
}