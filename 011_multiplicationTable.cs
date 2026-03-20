public class MultiplicationTable
{
    public static void Main()
    {
        print("Digite um número inteiro para ver a tabuada: ");
        string input = Console.ReadLine();
        int number;
        if (!int.TryParse(input, out number) || number < 0) {
            print("Entrada inválida. Por favor, insira um número inteiro positivo.");
            return;
        }

        print($"Tabuada do {number}:");
        for (int i = 1; i <= 10; i++) {
            print($"{number} x {i} = {number * i}");
        }
    }

    public static void print(string message)
    {
        Console.WriteLine(message);
    }
}