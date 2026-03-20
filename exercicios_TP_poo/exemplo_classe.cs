public class InitialClass
{
    public static void Main(string[] args)
    {
        // Criando uma conta bancária
        Bank b1 = new Bank("0001", "Daniel Knupp", 3000);
        Bank b2 = new Bank("0002", "Maria Silva", 5000);
        Bank b3 = new Bank("0003", "Mateus Francisco", 2000);

        b1.Deposit(500);

        Console.WriteLine("Saldo de " + b1.AccountHolder() + ": " + b1.Balance());
    }
}

public class Pessoa
{
    // Atributos
    public string Id { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }

    // Construtor
    public Pessoa(string id, string nome, int idade)
    {
        Id = id;
        Nome = nome;
        Idade = idade;
    }

    // Método para simular um aniversário
    public void FazerAniversario()
    {
        Idade++;
        Console.WriteLine("Parabéns! Você fez aniversário.");
    }
}

public class Bank
{
    private string userId;
    private string accountHolder;
    private decimal balance;

    public Bank(string userId, string accountHolder, decimal initialBalance = 0)
    {
        this.userId = userId;
        this.accountHolder = accountHolder;
        this.balance = initialBalance;
    }

    public string AccountHolder()
    {
        return this.accountHolder;
    }

    public decimal Balance()
    {
        return this.balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Depositado: {amount:C}. Saldo atual: {balance:C}");
        }
        else
        {
            Console.WriteLine("O valor do depósito deve ser positivo.");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Retirado: {amount:C}. Saldo atual: {balance:C}");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente ou valor inválido para retirada.");
        }
    }
}