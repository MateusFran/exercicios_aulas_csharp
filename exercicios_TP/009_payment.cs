public class Payment
{
    public static void Main()
    {
        print("Digite o salário bruto: ");
        string input = Console.ReadLine();
        if (!float.TryParse(input, out float amount) || amount < 0) {
            print("Valor inválido. Por favor, insira um número positivo.");
            return;
        }

        float discount;
        if (amount <= 1903.98) discount = 0; // 10% de desconto para compras acima de R$100
        else if (amount <= 2826.65) discount = 0.075f; // 7.5% de desconto para salários entre R$1903.99 e R$2826.65
        else if (amount <= 3751.05) discount = 0.15f; // 15% de desconto para salários entre R$2826.66 e R$3751.05
        else if (amount <= 4664.68) discount = 0.225f; // 22.5% de desconto para salários entre R$3751.06 e R$4664.68
        else discount = 0.275f; // 27.5% de desconto para salários acima de R$4664.68

        float finalAmount = amount * (1 - discount);
        
        print($"Salário bruto: R${amount.ToString("F2")}");
        print($"Desconto aplicado: {(discount * 100).ToString("F1")}%");
        print($"Valor final: R${finalAmount.ToString("F2")}");
    }

    public static void print(string message)
    {
        Console.WriteLine(message);
    }
}