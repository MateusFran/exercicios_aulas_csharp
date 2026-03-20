public class IMC
{
    public static void Main()
    {
        print("Digite seu peso em kg: ");
        string weightInput = Console.ReadLine();
        float weight;
        if (!float.TryParse(weightInput, out weight) || weight <= 0) {
            print("Peso inválido. Por favor, insira um número positivo.");
            return;
        }

        print("Digite sua altura em metros: ");
        string heightInput = Console.ReadLine();
        float height;
        if (!float.TryParse(heightInput, out height) || height <= 0) {
            print("Altura inválida. Por favor, insira um número positivo.");
            return;
        }

        float imc = weight / (height * height);
        print($"Seu IMC é {imc.ToString("F2")}..");

        if (imc < 18.5f) print("Classificação: Abaixo do peso");
        else if (imc < 25f) print("Classificação: Peso normal");
        else if (imc < 30f) print("Classificação: Sobrepeso");
        else if (imc < 35f) print("Classificação: Obesidade grau 1");
        else if (imc < 40f) print("Classificação: Obesidade grau 2");
        else print("Classificação: Obesidade grau 3");
    }

    public static void print(string message)
    {
        Console.WriteLine(message);
    }
}