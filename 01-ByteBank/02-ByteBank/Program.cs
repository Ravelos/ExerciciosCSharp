using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "María";
           
            conta.saldo = 300;

            Console.WriteLine(conta.titular);
            Console.WriteLine(conta.saldo);
            Console.WriteLine();

            // Os valores padrões geralmente é zero

            Console.ReadLine();
        }
    }
}
