
using Arquivo013_ExercicioResolvidoFolhaDePonto.Entities.Enum;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquivo013_ExercicioResolvidoFolhaDePonto.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double Salary { get; set; }
        private List<HourContract> Contracts { get; set; } = new List<HourContract>();
        public Worker()
        {
        }
        public Worker(string name, WorkerLevel level, double salary)
        {
            Name = name;
            Level = level;
            Salary = salary;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(List<HourContract> Contracts, HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double valueSalary = 0;
            if (Contracts.Count != 0)
            {
                foreach (HourContract contract in Contracts)
                {
                    if (contract.Date.Month == month && contract.Date.Year == year)
                    {
                        valueSalary += contract.TotalValue();
                    }
                }
            }
            return Salary + valueSalary;
        }

        public string Relatorio(int year, int month)
        {
            return "-----------------" +
                "\nNome:" + Name
                + "\nLevel:" + Level
                + "\nSalario" + Income(year, month)
                + "\n";

        }

        public override string ToString()
        {
            return "\nNome:" + Name
                + "\nLevel:" + Level
                + "\nSalario" + Salary;
        }
        
    }
}