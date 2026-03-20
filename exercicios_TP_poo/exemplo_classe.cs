public class InitialClass
{
    public static void Main(string[] args)
    {
        // Criando um objeto da classe Pessoa
        Pessoa pessoa1 = new Pessoa("João", 30);

        // Acessando os atributos e métodos do objeto
        Console.WriteLine("Nome: " + pessoa1.Nome);
        Console.WriteLine("Idade: " + pessoa1.Idade);

        pessoa1.FazerAniversario();
        Console.WriteLine("Idade após aniversário: " + pessoa1.Idade);
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

    public Bank(string accountHolder, decimal initialBalance = 0)
    {
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