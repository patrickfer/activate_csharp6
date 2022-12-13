using System;
using System.Collections.Generic;
using ConsoleApplication7.Entities.Enums;


namespace ConsoleApplication7.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; } // Pegando a enumeração do WorkerLevel e declarando o mesmo
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); // criação da list para guardar as horas trabalhadas

        public Worker ()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month) // somando os anos e meses de contrato jogando o valor pro TotalValue
                {
                    sum += contract.TotalValue();
                }

            }
            return sum;
        }

    }
}
