using ExercicioComposition3.Entities;
using ExercicioComposition3.Entities.Enums;
using System;
using System.Globalization;

namespace ExercicioComposition3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate= DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.Write("Product name: ");
                string nameProd = Console.ReadLine();
                Console.Write("product Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int qtt = int.Parse(Console.ReadLine());

                Product prod = new Product(nameProd, price);
                OrderItem orderItem = new OrderItem(qtt, price, prod);
                order.AddItem(orderItem);
            }

            Console.WriteLine(order);
        }
    }
}
