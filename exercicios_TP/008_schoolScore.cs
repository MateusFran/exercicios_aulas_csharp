using System.Runtime.InteropServices;

public class SchoolScore
{
    public static void Main()
    {
        print("Digite a nota do aluno (0-10): ");
        string input = Console.ReadLine();
        if (!float.TryParse(input, out float score) || score < 0 || score > 10) {
            print("Nota inválida. Por favor, insira um número entre 0 e 10.");
            return;
        }

        if (score >= 9) print("Excelente!");
        else if (score >= 8) print("Bom");
        else if (score >= 7) print("Regular");
        else print("Insuficiente");
    }

    public static void print(string message)
    {
        Console.WriteLine(message);
    }

}