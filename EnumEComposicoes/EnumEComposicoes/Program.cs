using EnumEComposicoes.Entities;
using EnumEComposicoes.Entities.enums;
using System;
using System.Globalization;

namespace EnumEComposicoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter department's name: ");
            //string depName = Console.ReadLine();
            //Department dep = new Department(depName);

            //Console.WriteLine("Enter worker data:");
            //Console.Write("Name: ");
            //string name = Console.ReadLine();
            //Console.Write("Level (Junior/MidLevel/Senior): ");
            //WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            //Console.Write("Base Salary: ");
            //double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Worker worker = new Worker(name, level, baseSalary, dep);

            //Console.Write("How many contracts to this worker? ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"Enter #{i+1} contract data: ");
            //    Console.Write("Date (DD/MM/YYYY): ");
            //    string dateString = Console.ReadLine();
            //    Console.Write("Value per hour: ");
            //    double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    Console.Write("Duration (hours): ");
            //    int hour = int.Parse(Console.ReadLine());

            //    DateTime date = DateTime.Parse(dateString);

            //    HourContract contract = new HourContract(date, value, hour);
            //    worker.AddContrat(contract);
            //}

            //Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            //string dateCalculate = Console.ReadLine();

            //int year = int.Parse(dateCalculate.Substring(3, 4));

            //int month = int.Parse(dateCalculate.Substring(0, 2));
            //double income = worker.Income(year, month);

            //Console.WriteLine(worker);
            //Console.WriteLine(dep);
            //Console.WriteLine($"Income for {dateCalculate}: {income.ToString("F2", CultureInfo.InvariantCulture)}");

            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
            "Traveling to New Zealand",
            "I'm going to visit this wonderful country!",
            12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the force be with you");
            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5
                );
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
