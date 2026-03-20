public class Countdown
{
    public static void Main()
    {
        print("Digite um número inteiro para iniciar a contagem regressiva: ");
        string input = Console.ReadLine();
        int number;
        if (!int.TryParse(input, out number) || number < 0) {
            print("Entrada inválida. Por favor, insira um número inteiro positivo.");
            return;
        }

        for (int i = number; i > 0; i--) {
            printLine(i.ToString() + ", ");
        }
        printLine("0");
        print("\nContagem regressiva concluída!");
    }

    public static void print(string message) => Console.WriteLine(message);

    public static void printLine(string message) => Console.Write(message);
}