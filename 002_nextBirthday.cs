using System;

public class NextBirthday
{
    public static void Main()
    {
        print("Digite sua data de nascimento (DD/MM/AAAA): ");
        string input = Console.ReadLine();
        
        // Usando o seu padrão de ParseExact
        DateOnly birthDate = DateOnly.ParseExact(input, "dd/MM/yyyy", null);
        DateOnly now = DateOnly.FromDateTime(DateTime.Now);

        // 1. Criar a data do aniversário no ano atual
        DateOnly nextBirthday = new DateOnly(now.Year, birthDate.Month, birthDate.Day);

        // 2. Se o aniversário já passou este ano, somamos 1 ao ano
        if (nextBirthday < now)
        {
            nextBirthday = nextBirthday.AddYears(1);
        }

        // 3. Calcular a diferença de dias
        // No DateOnly, subtrair duas datas retorna um TimeSpan através da conversão para DateTime ou DayNumber
        int diasFaltando = nextBirthday.DayNumber - now.DayNumber;

        if (diasFaltando == 0)
        {
            print("Parabéns! Seu aniversário é hoje!");
        }
        else
        {
            print($"Faltam {diasFaltando} dias para o seu próximo aniversário.");
        }
    }

    public static void print(string message)
    {
        Console.WriteLine(message);
    }
}