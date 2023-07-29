using System;
using System.Collections.Generic;
using System.Globalization;
using Herenca_Polimorfismo.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Herenca_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionarios> list = new List<Funcionarios>();

            Console.Write("Entre com nome do Funcionario: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Funcionario #{i} data:");
                Console.Write("Tercerizado (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                String name = Console.ReadLine();
                Console.Write("Horas: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Valor da Hora: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'y')
                {
                    Console.Write("Hora adicional: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new FuncionarioTercerizado(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Funcionarios( name, hours, valuePerHour));
                }
            }

            //EXECUÇÃO POLIMORFISMO

            Console.WriteLine();
            Console.WriteLine("Pagamento:");
            foreach (Funcionarios emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Pagamento().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}

