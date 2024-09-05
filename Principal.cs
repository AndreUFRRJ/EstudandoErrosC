using Arquivo013_ExercicioResolvidoFolhaDePonto.Entities;
using Arquivo013_ExercicioResolvidoFolhaDePonto.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquivo013_ExercicioResolvidoFolhaDePonto.Utilitarios
{
    internal static class Principal
    {
        public static void Menu()
        {
            Console.WriteLine(
                "\n1) adicionar trabalhador" +
                "\n2) remover trabalhador" +
                "\n3) adicionar contrato" +
                "\n4) remover contrato" +
                "\n5) relatorio" +
                "\n6) sair\n"
                );
        }
        public static Worker CreateWorker()
        {
            Console.Write("Nome:");
            string nome = Console.ReadLine();
            Console.Write("Level (0- JUNIOR,1-MID_LEVEL,2-SENIOR): ");
            int level = int.Parse(Console.ReadLine());
            WorkerLevel levelWorker = new WorkerLevel();
            switch (level)
            {
                case 0: levelWorker = Enum.Parse<WorkerLevel>("JUNIOR"); break;
                case 1: levelWorker = Enum.Parse<WorkerLevel>("MID_LEVEL"); break;
                case 2: levelWorker = Enum.Parse<WorkerLevel>("SENIOR"); break;
            }
            Console.Write("Salario: ");
            double salary = double.Parse(Console.ReadLine());
            return new Worker(nome, levelWorker, salary);
        }

        public static HourContract CreateContract()
        {
            Console.Write("Data (exemplo: 01/01/2000):");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Quantidade de horas inteiras:");
            int time=int.Parse(Console.ReadLine());
            Console.WriteLine("valor por hora:");
            double value=double.Parse(Console.ReadLine());
            return new HourContract(date, value, time);
        }
    }
}
