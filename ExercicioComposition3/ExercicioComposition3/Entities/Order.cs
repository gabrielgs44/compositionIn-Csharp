using ExercicioComposition3.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioComposition3.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Itens { get; set; }
        public Client Client { get; set; }

        public Order(OrderStatus status, Client client)
        {
            Moment = DateTime.Now;
            Itens = new List<OrderItem>();
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Itens.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Itens.Remove(item);
        }
        public double Total()
        {
            double total = 0;
            foreach(OrderItem o in Itens)
            {
                total += o.SubTotal();
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order SUMMARY");
            sb.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)}");
            sb.AppendLine($"Order status: {Status}");
            sb.Append($"Client: {Client.Name}");
            sb.Append($" ({Client.BithDate.ToString("dd/MM/yyyy")}) - ");
            sb.AppendLine($"{Client.Email}");
            foreach(OrderItem o in Itens)
            {
                sb.Append($"{o.Product.Name}, {o.Price.ToString("F2", CultureInfo.InvariantCulture)}, Quantity: {o.Quantity}, ");
                sb.AppendLine($"Subtotal: {o.SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");
            }
            sb.AppendLine($"Total price: {Total().ToString("F2", CultureInfo.InvariantCulture)}");

            return sb.ToString();
        }
    }
}
