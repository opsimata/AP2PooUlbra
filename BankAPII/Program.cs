using BankAPII.Domain.Entities;

namespace BankAPII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new DataContext();
            var clientRepository = new ClientRepository(db);
            Client client = new Client();
            var loop = 1;
            // Criação de clientes
            #region
            Console.WriteLine("\nCreate a client?\nType '1' for yes.\nType '2' for no.");
            Console.Write("Type your choice: ");
            var choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                do
                {
                    Console.Write("\nType the client ID: ");
                    client.Id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Type the client Name: ");
                    client.Name = Console.ReadLine();
                    clientRepository.Save(client);
                    Console.WriteLine();
                    Console.WriteLine("Create another client?\nType '1' for yes.\nType '2' for no.");
                    Console.Write("Type your choice: ");
                    loop = Convert.ToInt32(Console.ReadLine());
                    if (loop == 2)
                    {
                        Console.WriteLine();
                    }
                } while (loop == 1);
            }
            else
            {
                Console.WriteLine();
            }
            #endregion

            // Client cliente1 = new Client(12345678901, "João");
            // Client cliente2 = new Client(98765432109, "Maria");

            // Criação de contas correntes
            BankAccount conta1 = new BankAccount(client);
            // BankAccount conta2 = new BankAccount(cliente2);

            // Realização de transações
            conta1.Deposit(1000);
            conta1.Withdraw(5000);
            // conta1.Transfer(conta2, 500);

            // Exibição dos saldos
            Console.WriteLine($"{client.Name} account balance: ${conta1.Balance}");
            // Console.WriteLine($"Saldo da conta de {cliente2.Name}: R$ {conta2.Balance}");
        }
    }
}