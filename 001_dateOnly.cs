
public class DateOnlyExample
{
    public static void Main()
    {

        string input = Console.ReadLine("Please enter your birthday (MM/DD/YYYY): ");
        DateOnly birthday = DateOnly.Parse(input);

        DateOnly now = DateOnly.FromDateTime(DateTime.Now);

        if (birthday > now)
        {
            print("This is invalid, you haven't been born yet?");
            return;
        } else if (birthday.Month == now.Month && birthday.Day == now.Day)
        {
            print("Happy birthday!");
            return;
        } else if (birthday.Month )
        {
            // I stoped here !!!!!!!!!!!!!
        }
        int ageInYears = DateOnly.FromDateTime(DateTime.Now).Year - birthday.Year;
        int ageInMonths = ageInYears * 12 + DateOnly.FromDateTime(DateTime.Now).Month - birthday.Month;
        print($"Your age in years is {ageInYears}.");
        print($"Your age in months is {ageInMonths}.");

        // 1 e 2 meses;
    }

    public static void print(string message)
    {
        Console.WriteLine(message);
    }
}


/* This example produces output similar to the following:
 * 
 * Today is 12/28/2022
*/