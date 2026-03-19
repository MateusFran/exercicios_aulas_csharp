
public class DateOnlyExample
{
    public static void Main()
    {
        print("Please enter your birthday (DD/MM/YYYY): ");
        string input = Console.ReadLine();
        DateOnly birthday = DateOnly.ParseExact(input, "dd/MM/yyyy", null);

        DateOnly now = DateOnly.FromDateTime(DateTime.Now);

        if (birthday > now) {
            print("This is invalid, you haven't been born yet?");
            return;
        }

        int years = now.Year - birthday.Year;
        int months = now.Month - birthday.Month;
        int days = now.Day - birthday.Day;

        if (days < 0) {
            months--;
            // print(DateTime.DaysInMonth(now.Year, now.Month - 1).ToString());
            days += DateTime.DaysInMonth(now.Year, now.Month - 1);
        }

        if (months < 0) {
            years--;
            months += 12;
        }

        print($"You are {years} years, {months} months, and {days} days old.");
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