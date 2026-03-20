public class DateDifference
{
    public static void Main()
    {
        print("Digite a primeira data (DD/MM/AAAA): ");
        string input1 = Console.ReadLine();
        
        print("Digite a segunda data (DD/MM/AAAA): ");
        string input2 = Console.ReadLine();
        
        DateTime d1 = DateTime.ParseExact(input1, "dd/MM/yyyy", null);
        DateTime d2 = DateTime.ParseExact(input2, "dd/MM/yyyy", null);

        // Operador ternário para organizar a datas de início e fim
        DateTime dataInicio = d1 < d2 ? d1 : d2;
        DateTime dataFim = d1 < d2 ? d2 : d1;

        TimeSpan ts = dataFim - dataInicio;

        int anos = dataFim.Year - dataInicio.Year;
        int meses = dataFim.Month - dataInicio.Month;
        int dias = dataFim.Day - dataInicio.Day;

        if (dias < 0)
        {
            meses--;
            DateTime mesAnterior = dataFim.AddMonths(-1);
            dias += DateTime.DaysInMonth(mesAnterior.Year, mesAnterior.Month);
        }

        if (meses < 0)
        {
            anos--;
            meses += 12;
        }

        print($"\nTotal absoluto em dias: {ts.TotalDays} dias.");
        print($"Formatado: {anos} anos, {meses} meses e {dias} dias.");
    }

    public static void print(string message)
    {
        Console.WriteLine(message);
    }
}