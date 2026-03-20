public class InitialClass
{
    public static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa("João", 25);
        Ticket bgs = new Ticket(pessoa, "Brasil Game Show", 150.00m, 500);

        Console.WriteLine(bgs.ticketHolder.Nome);
    }
}

public class Ticket
{
    private string eventName;
    private decimal price;
    private int quantity;
    public Pessoa ticketHolder;

    public Ticket(Pessoa ticketHolder, string eventName, decimal price, int quantity)
    {
        this.ticketHolder = ticketHolder;
        this.eventName = eventName;
        this.price = price;
        this.quantity = quantity;
    }

    public void BuyTicket(int quantityBuyed)
    {
        if (quantityBuyed > 0 && quantityBuyed <= this.quantity)
        {
            this.quantity -= quantityBuyed;
            Console.WriteLine($"Ingressos comprados: {quantityBuyed}. Quantidade restante: {this.quantity}");
        }
        else
        {
            Console.WriteLine("Quantidade inválida ou insuficiente.");
        }
    }
}

public class Pessoa
{
    public string Nome { get; private set; }
    public int Idade { get; private set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}