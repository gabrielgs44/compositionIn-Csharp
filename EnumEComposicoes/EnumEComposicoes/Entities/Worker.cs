using EnumEComposicoes.Entities.enums;
using System.Collections.Generic;

namespace EnumEComposicoes.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; private set; }
        public List<HourContract> Contracts { get; set; }
        public Department Department { get; set; }
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Contracts = new List<HourContract>();
            Department = department;
        }
        public void AddContrat(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract exContract)
        {
            Contracts.Remove(exContract);
        }
        public double Income(int year, int month)
        {
            double income = BaseSalary;

            foreach (HourContract c in Contracts)
            {
                income += c.Date.Month.Equals(month) && c.Date.Year.Equals(year) ? c.TotalValue() : 0;
            }
            return income;
        }

        public override string ToString()
        {
            return $"Name: {Name}";
        }
    }
}
