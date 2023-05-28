using BankAPII.Data.Repositories;
using BankAPII.Domain.Entities;
using Data;

namespace BankAPII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criação de clientes
            #region
            var db = new DataContext();
            var clientRepository = new ClientRepository(db);

            Client client = new Client();

            var loop = 1;
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

            // Criação de contas correntes

            ListClients();


            // BankAccount conta2 = new BankAccount(cliente2);

            // Realização de transações
            // conta1.Deposit(1000);
            // conta1.Withdraw(5000);
            // conta1.Transfer(conta2, 500);


            // Console.WriteLine($"Saldo da conta de {cliente2.Name}: R$ {conta2.Balance}");

            // Métodos utilitários
            #region

            // Exibição das informações de cliente e conta
            void ListClients()
            {
                var client = clientRepository.GetAll(); // Get em todas as pessoas salvas no banco
                Console.WriteLine("\nPeople list:");
                foreach (var item in client) // Lista as pessoas salvas no banco em print na tela
                {
                    Console.WriteLine($"Account holder ID: {item.Id}\nAccount holder Name: ${item.Name}");
                }
                Console.Write("\n");
            }
            #endregion
        }
    }
}