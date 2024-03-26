using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnuidade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe o valor da anuidade:");
            double anuidade= double.Parse(Console.ReadLine());
            double mensalidade = anuidade / 12;

            Console.WriteLine("informe o valor da matrícula:");
            double matricula=double.Parse(Console.ReadLine());

            Console.WriteLine("informe o valor do material:");
            double material= double.Parse(Console.ReadLine());

            int parcelas = int.Parse(Console.ReadLine());

            double VT = anuidade + matricula + material;

            double PU = matricula + material;

            double PM = +(VT - PU) / parcelas;

            Console.WriteLine($"valor total do curso: R${VT:F2}");
            Console.WriteLine($"valor da parcela única: R${PU:F2}");
            Console.WriteLine($"números de parcelas restantes: R${parcelas}");
            Console.WriteLine($"valor das demias parcelas: R${PM:F2}");

            Console.ReadKey();





        }
    }
}
