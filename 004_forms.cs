public class UserForms
{
    public static void Main()
    {
        print("Digite seu nome: ");
        string name = Console.ReadLine();

        print("Digite sua idade: ");
        string ageInput = Console.ReadLine();
        int age;
        if (!int.TryParse(ageInput, out age))
        {
            print("Idade inválida. Por favor, insira um número.");
            return;
        }

        print("Digite seu email: ");
        string email = Console.ReadLine();

        print("Digite seu telefone: ");
        string phone = Console.ReadLine();

        print($"Olá, {name}! Você tem {age} anos, seu email é {email} e seu telefone é {phone}.");
    }

    public static void print(string message)
    {
        Console.WriteLine(message);
    }
}