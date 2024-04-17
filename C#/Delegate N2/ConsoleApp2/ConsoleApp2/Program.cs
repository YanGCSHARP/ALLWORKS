public delegate void AccountHandler(string message);

class Program
{
    static void Main(string[] args)
    {
        // создаем банковский счет
        Account account = new Account(200);
// Добавляем в делегат ссылку на метод PrintSimpleMessage
        account.RegisterHandler(PrintSimpleMessage);
// Два раза подряд пытаемся снять деньги
        account.Take(300);
        account.Take(150);
        void PrintSimpleMessage(string message) => Console.WriteLine(message);
    }
    
}

class Account
{
    private int sum;

    public Account(int sum) => this.sum = sum;
    private AccountHandler? taken;

    public void RegisterHandler(AccountHandler del)
    {
        taken = del;
    }

    public void add(int sum) => this.sum += sum;

    public void Take(int sum)
    {
        if (this.sum >= sum)
        {
            this.sum -= sum;
            taken?.Invoke($"You taked {sum}");
        }
        else
        {
            taken?.Invoke($"You need more money, you balance {this.sum}");
        }
    }
}


