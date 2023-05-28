using BankAPII.Data.Repositories;
using BankAPII.Domain.Entities;
using Data;

namespace BankAPII
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var loop = 1;

            #region // Criação de clientes

            var db = new DataContext();
            var clientRepository = new ClientRepository(db);

            Console.WriteLine();
            ListClients();

            Console.WriteLine("Create new client?\nType '1' for yes.\nType '2' for no.");
            Console.Write("Type your choice: ");
            var choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                do
                {
                    Client client = new Client();
                    Console.Write("\nType the client ID: ");
                    client.Id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Type the client Name: ");
                    client.Name = Console.ReadLine();
                    Console.Write("Type the client age: ");
                    client.Age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Type the client phone number: ");
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

            #region // Procurar cliente por Id

            Console.WriteLine("Search client by ID?\nType '1' for yes.\nType '2' for no.");
            Console.Write("Type your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                do
                {
                    Console.Write("\nType the ID of the person you're searching for: ");
                    int searchedID = Convert.ToInt32(Console.ReadLine());
                    var clientFindById = clientRepository.GetById(searchedID);
                    Console.WriteLine();
                    Console.WriteLine("REQUESTED DATA:");
                    Console.WriteLine($"ID: {clientFindById.Id} | Name: {clientFindById.Name} | Age: {clientFindById.Age} years old | Phone Number: {clientFindById.PhoneNumber}");
                    Console.WriteLine("\nSearch another person on the database?\nType '1' for yes.\nType '2' for no.");
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

            #region // Atualizar dados do cliente
            loop = 1;
            Console.WriteLine("Update client data?\nType '1' for yes.\nType '2' for no.");
            Console.Write("Type your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                do
                {
                    Console.Write("\nType the ID of the person's data you're updating: ");
                    int alterByID = Convert.ToInt32(Console.ReadLine());
                    var clientDataAlter = clientRepository.GetById(alterByID);
                    Console.WriteLine();
                    Console.WriteLine("Updating person data...");
                    Console.Write($"Person ID: {clientDataAlter.Id}\n");
                    Console.Write($"Current name: {clientDataAlter.Name}\nType the updated name: ");
                    clientDataAlter.Name = Console.ReadLine();
                    Console.Write($"Current phone number: {clientDataAlter.PhoneNumber}\nType the updated phone number: ");
                    clientDataAlter.PhoneNumber = Console.ReadLine();
                    Console.Write($"Current age: {clientDataAlter.Age}\nType the updated age: ");
                    clientDataAlter.Age = Convert.ToInt32(Console.ReadLine());
                    clientRepository.Update(clientDataAlter);
                    Console.WriteLine("\nupdate another client data?\nType '1' for yes.\nType '2' for no.");
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

            #region // Deletando clientes do banco
            Console.WriteLine("Delete client?\nType '1' for yes.\nType '2' for no.");
            Console.Write("Type your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.Write("\nType the ID of the person registration to be deleted: ");
                int deletedID = Convert.ToInt32(Console.ReadLine());
                clientRepository.Delete(deletedID);
            }
            else
            {
                Console.WriteLine();
            }
            #endregion

            ListClients();

            #region // Métodos utilitários
            // Exibição das informações de cliente e conta
            void ListClients()
            {
                var client = clientRepository.GetAll(); // Get em todas as pessoas salvas no banco
                Console.WriteLine("CLIENTS LIST:");
                foreach (var item in client) // Lista as pessoas salvas no banco em print na tela
                {
                    Console.WriteLine($"ID: {item.Id} | Name: {item.Name} | Age: {item.Age} years old | Phone Number: {item.PhoneNumber}");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}