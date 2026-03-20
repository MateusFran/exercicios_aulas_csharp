using System;

public class NextBirthday
{
    public static void Main()
    {
        print("Digite sua data de nascimento (DD/MM/AAAA): ");
        string input = Console.ReadLine();
        
        DateOnly birthDate = DateOnly.ParseExact(input, "dd/MM/yyyy", null);
        DateOnly now = DateOnly.FromDateTime(DateTime.Now);

        // Criar a data do aniversário no ano atual
        DateOnly nextBirthday = new DateOnly(now.Year, birthDate.Month, birthDate.Day);

        // Se o aniversário já passou este ano, somamos 1 ao ano
        if (nextBirthday < now)
        {
            nextBirthday = nextBirthday.AddYears(1);
        }

        // Calcular a diferença de dias
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