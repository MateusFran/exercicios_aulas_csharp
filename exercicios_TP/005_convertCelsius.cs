public class ConvertCelsius
{
    public static void Main()
    {
        print("Digite a temperatura em Celsius: ");
        string input = Console.ReadLine();
        
        float celsius;
        if (!float.TryParse(input, out celsius))
        {
            print("Entrada inválida. Por favor, insira um número.");
            return;
        }

        print($"{celsius}°C é igual a {ConvertToFahrenheit(celsius).ToString("F2")}°F e {ConvertToKelvin(celsius).ToString("F2")} K.");
    }

    public static void print(string message)
    {
        Console.WriteLine(message);
    }

    public static float ConvertToFahrenheit(float celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    public static float ConvertToKelvin(float celsius)
    {
        return celsius + 273.15f;
    }
}