using System;
using System.Collections.Generic;
using InventoryLibrary;

namespace InventoryManager
{
    class Program
    {
        static JSONStorage storage = new JSONStorage();

        static void Main(string[] args)
        {
            storage.Load();
            ShowPrompt();
        }

        static void ShowPrompt()
        {
            Console.WriteLine("Inventory Manager");
            Console.WriteLine("-------------------------");
            Console.WriteLine("<ClassNames> show all ClassNames of objects");
            Console.WriteLine("<All> show all objects");
            Console.WriteLine("<All [ClassName]> show all objects of a ClassName");
            Console.WriteLine("<Create [ClassName]> a new object");
            Console.WriteLine("<Show [ClassName object_id]> an object");
            Console.WriteLine("<Update [ClassName object_id]> an object");
            Console.WriteLine("<Delete [ClassName object_id]> an object");
            Console.WriteLine("<Exit>");

            while (true)
            {
                string input = Console.ReadLine();
                ProcessCommand(input);
            }
        }

        static void ProcessCommand(string input)
        {
            string[] parts = input.Split(' ', 2);
            string command = parts[0].ToLower();

            switch (command)
            {
                case "classnames":
                    ShowClassNames();
                    break;
                case "all":
                    if (parts.Length > 1)
                    {
                        ShowAll(parts[1]);
                    }
                    else
                    {
                        ShowAll();
                    }
                    break;
                case "create":
                    if (parts.Length > 1)
                    {
                        Create(parts[1]);
                    }
                    else
                    {
                        Console.WriteLine("Create command requires a ClassName");
                    }
                    break;
                case "show":
                    if (parts.Length > 1)
                    {
                        Show(parts[1]);
                    }
                    else
                    {
                        Console.WriteLine("Show command requires ClassName and object_id");
                    }
                    break;
                case "update":
                    if (parts.Length > 1)
                    {
                        Update(parts[1]);
                    }
                    else
                    {
                        Console.WriteLine("Update command requires ClassName and object_id");
                    }
                    break;
                case "delete":
                    if (parts.Length > 1)
                    {
                        Delete(parts[1]);
                    }
                    else
                    {
                        Console.WriteLine("Delete command requires ClassName and object_id");
                    }
                    break;
                case "exit":
                    storage.Save();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid command");
                    break;
            }
        }

        static void ShowClassNames()
        {
            Console.WriteLine("Available Class Names:");
            Console.WriteLine("Inventory");
            Console.WriteLine("Item");
            Console.WriteLine("User");
        }

        static void ShowAll()
        {
            Console.WriteLine("All objects:");
            foreach (var obj in storage.objects)
            {
                Console.WriteLine(obj.Key);
            }
        }

        static void ShowAll(string className)
        {
            Console.WriteLine($"All objects of type {className}:");
            foreach (var obj in storage.objects)
            {
                if (obj.Key.StartsWith(className))
                {
                    Console.WriteLine(obj.Key);
                }
            }
        }

        static void Create(string className)
        {
            switch (className.ToLower())
            {
                case "inventory":
                    Console.WriteLine("Creating a new Inventory object.");
                    Console.Write("User ID: ");
                    string userId = Console.ReadLine();
                    Console.Write("Item ID: ");
                    string itemId = Console.ReadLine();
                    Console.Write("Quantity: ");
                    int quantity = int.Parse(Console.ReadLine());
                    Inventory inventory = new Inventory(userId, itemId, quantity);
                    storage.New(inventory);
                    break;
                case "item":
                    Console.WriteLine("Creating a new Item object.");
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Description: ");
                    string description = Console.ReadLine();
                    Console.Write("Price: ");
                    float price = float.Parse(Console.ReadLine());
                    Console.Write("Tags (comma separated): ");
                    string tagsInput = Console.ReadLine();
                    List<string> tags = new List<string>(tagsInput.Split(','));
                    Item item = new Item(name, description, price, tags);
                    storage.New(item);
                    break;
                case "user":
                    Console.WriteLine("Creating a new User object.");
                    Console.Write("Name: ");
                    string userName = Console.ReadLine();
                    User user = new User(userName);
                    storage.New(user);
                    break;
                default:
                    Console.WriteLine($"{className} is not a valid object type");
                    break;
            }
        }

        static void Show(string input)
        {
            string[] parts = input.Split(' ');
            if (parts.Length < 2)
            {
                Console.WriteLine("Show command requires ClassName and object_id");
                return;
            }

            string className = parts[0];
            string objectId = parts[1];
            string key = $"{className}.{objectId}";

            if (storage.objects.ContainsKey(key))
            {
                Console.WriteLine(storage.objects[key]);
            }
            else
            {
                Console.WriteLine($"Object {objectId} could not be found");
            }
        }

        static void Update(string input)
        {
            string[] parts = input.Split(' ');
            if (parts.Length < 2)
            {
                Console.WriteLine("Update command requires ClassName and object_id");
                return;
            }

            string className = parts[0];
            string objectId = parts[1];
            string key = $"{className}.{objectId}";

            if (storage.objects.ContainsKey(key))
            {
                string jsonString = storage.objects[key];
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                switch (className.ToLower())
                {
                    case "inventory":
                        Inventory inventory = JsonSerializer.Deserialize<Inventory>(jsonString, options);
                        Console.Write("New User ID: ");
                        inventory.user_id = Console.ReadLine();
                        Console.Write("New Item ID: ");
                        inventory.item_id = Console.ReadLine();
                        Console.Write("New Quantity: ");
                        inventory.quantity = int.Parse(Console.ReadLine());
                        storage.New(inventory);
                        break;
                    case "item":
                        Item item = JsonSerializer.Deserialize<Item>(jsonString, options);
                        Console.Write("New Name: ");
                        item.name = Console.ReadLine();
                        Console.Write("New Description: ");
                        item.description = Console.ReadLine();
                        Console.Write("New Price: ");
                        item.price = float.Parse(Console.ReadLine());
                        Console.Write("New Tags (comma separated): ");
                        string tagsInput = Console.ReadLine();
                        item.tags = new List<string>(tagsInput.Split(','));
                        storage.New(item);
                        break;
                    case "user":
                        User user = JsonSerializer.Deserialize<User>(jsonString, options);
                        Console.Write("New Name: ");
                        user.name = Console.ReadLine();
                        storage.New(user);
                        break;
                    default:
                        Console.WriteLine($"{className} is not a valid object type");
                        break;
                }
            }
            else
            {
                Console.WriteLine($"Object {objectId} could not be found");
            }
        }

        static void Delete(string input)
        {
            string[] parts = input.Split(' ');
            if (parts.Length < 2)
            {
                Console.WriteLine("Delete command requires ClassName and object_id");
                return;
            }

            string className = parts[0];
            string objectId = parts[1];
            string key = $"{className}.{objectId}";

            if (storage.objects.Remove(key))
            {
                Console.WriteLine($"Deleted object {objectId}");
            }
            else
            {
                Console.WriteLine($"Object {objectId} could not be found");
            }
        }
    }
}
