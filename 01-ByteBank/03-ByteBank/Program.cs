using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaDaMaria = new ContaCorrente();
            contaDaMaria.titular = "María";
            contaDaMaria.agencia = 863;
            contaDaMaria.numero = 863452;

            ContaCorrente contaDaMariaCosta = new ContaCorrente();
            contaDaMariaCosta.titular = "María";
            contaDaMariaCosta.agencia = 863;
            contaDaMariaCosta.numero = 863452;

            Console.WriteLine("Igualdade de tipo de referencia " +(contaDaMaria == contaDaMariaCosta));

            int idade = 27;

            int idadeMaisUmaVez = 27;

            Console.WriteLine("igualdade de tipo de valor " + (idade == idadeMaisUmaVez));

            contaDaMaria = contaDaMariaCosta;

            Console.WriteLine(contaDaMaria == contaDaMariaCosta);

            contaDaMaria.saldo = 400;

            Console.WriteLine(contaDaMaria.saldo);
            Console.WriteLine(contaDaMariaCosta.saldo);

            Console.ReadLine();

        }
    }
}
