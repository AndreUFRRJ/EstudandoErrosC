using System.ComponentModel.Design;
using System.Diagnostics.Tracing;
using Arquivo013_ExercicioResolvidoFolhaDePonto.Entities;
using Arquivo013_ExercicioResolvidoFolhaDePonto.Utilitarios;
internal class Program
{
    private static void Main(string[] args)
    {
        List<Worker> worker = new List<Worker>();
        bool loop = true;
        while (loop)
        {
            Principal.Menu();

            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    worker.Add(Principal.CreateWorker());
                    break;
                case 2:
                    Console.WriteLine("EM CONSTRUÇÃO");
                    break;
                case 3:
                    Console.WriteLine("Nome do funcionario");
                     Worker worker1 = worker.Find(x=>x.Name.Equals(Console.ReadLine()));
                    if(worker1 != null) worker1.AddContract(Principal.CreateContract());
                    else Console.WriteLine("nao encontrado");
                    break;
                case 4:
                    Console.WriteLine("EM CONSTRUÇÃO");
                    break;
                case 5:
                    Console.WriteLine("Mes: ");
                    int mes = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ano: ");
                    int ano=int.Parse(Console.ReadLine());
                    foreach (Worker x in worker)
                    {
                        Console.WriteLine(x.Relatorio(ano,mes));
                    }
                    break;
                case 6:
                    loop = false;
                    break;
            }
        }
    }
}