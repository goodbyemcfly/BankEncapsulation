namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();


            Console.WriteLine("Welcome to Banking App");
            Console.WriteLine("----------------------");

            while (true)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1 - Deposit");
                Console.WriteLine("2 - Check Balance");
                Console.WriteLine("3 - Exit");

                int userInput;

                if (!int.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.WriteLine("Invalid input. Please enter a valid option");
                    continue;
                }

                switch(userInput)
                {
                    case 1: 
                        Console.WriteLine("Enter the amount you would like to deposit:");
                        double amount;
                        if (!double.TryParse(Console.ReadLine(),out amount))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid amount.");
                            continue;
                        }

                        account.Deposit(amount);
                        Console.WriteLine($"Deposit of ${amount} was succesful");
                        break;

                    case 2:
                        Console.WriteLine($"Current balance {account.GetBalance()}");
                        break;

                    case 3:
                        Console.WriteLine("Thank you for banking with us!");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please enter a valid option.");
                        break;

                } 
            }
                

                
            
        }
    }
}
