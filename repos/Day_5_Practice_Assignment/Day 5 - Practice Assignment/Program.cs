using Day_5_Practice_Assignment.BankingTransactionSystem;

namespace Day_5_Practice_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = null;
            bool accountCreated = false;
            while (!accountCreated)
            {
                try
                {
                    Console.WriteLine("=== Account Creation ===");
                    Console.Write("Enter Account Holder Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Initial Balance (>= ₹1000): ");
                    if (!double.TryParse(Console.ReadLine(), out double initialBalance))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number for balance.\n");
                        continue;
                    }
                    account = new BankAccount(name, initialBalance);
                    Console.WriteLine("Account Created Successfully\n");
                    accountCreated = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}\n");
                }
            }

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n=== Banking Menu ===");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();
                try
                {
                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter amount to deposit: ");
                            if (double.TryParse(Console.ReadLine(), out double depositAmt))
                            {
                                account.Deposit(depositAmt);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number.");
                            }
                            break;
                        case "2":
                            Console.Write("Enter amount to withdraw: ");
                            if (double.TryParse(Console.ReadLine(), out double withdrawAmt))
                            {
                                account.Withdraw(withdrawAmt);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number.");
                            }
                            break;
                        case "3":
                            account.CheckBalance();
                            break;
                        case "4":
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            break;
                    }
                }
                catch (InvalidAmountException ex)
                {
                    Console.WriteLine("Invalid Amount Exception: " + ex.Message);
                }
                catch (InsufficientBalanceException ex)
                {
                    Console.WriteLine("Insufficient Balance Exception: " + ex.Message);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Argument Exception: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("General Exception: " + ex.Message);
                }
            }
            Console.WriteLine("\nTransaction process completed.");
        }
    }
}