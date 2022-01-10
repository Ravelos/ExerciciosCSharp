using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(987, 987654234);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente Maria = new ContaCorrente(867, 94529);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

                   

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            Console.ReadLine();
        }
    }
}
