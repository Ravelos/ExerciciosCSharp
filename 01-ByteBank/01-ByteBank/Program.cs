using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaMaria = new ContaCorrente();

            contaDaMaria.titular = "María";
            contaDaMaria.agencia = 863;
            contaDaMaria.numero = 863146;
            contaDaMaria.saldo = 100;

            Console.WriteLine("Titular "+ contaDaMaria.titular);
            Console.WriteLine("Agência " + contaDaMaria.agencia);
            Console.WriteLine("Número " + contaDaMaria.numero);
            Console.WriteLine("Saldo " + contaDaMaria.saldo);

            contaDaMaria.saldo += 200;

            Console.WriteLine("Saldo " + contaDaMaria.saldo);

            Console.ReadLine();

        }
    }
}
