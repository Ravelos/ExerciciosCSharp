using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            Console.WriteLine(contaDoBruno.saldo);

           bool resultadoSaque = contaDoBruno.Sacar(500);

            Console.WriteLine(contaDoBruno.saldo);

            Console.WriteLine(resultadoSaque);

            contaDoBruno.Depositar(500);

            Console.WriteLine(contaDoBruno.saldo);

            ContaCorrente ContaDaMaria =new ContaCorrente();

            ContaDaMaria.titular = "María";

            Console.WriteLine("Saldo da María = " + ContaDaMaria.saldo);
            Console.WriteLine("Saldo do Bruno = " + contaDoBruno.saldo);

            bool resultadoTransferencia = contaDoBruno.Transferir(2000, ContaDaMaria);

            Console.WriteLine("Saldo da María = " + ContaDaMaria.saldo);
            Console.WriteLine("Saldo do Bruno = " + contaDoBruno.saldo);

            Console.WriteLine("O resultado da transferência " + resultadoTransferencia);

            ContaDaMaria.Transferir(100, contaDoBruno);

            Console.WriteLine("Saldo da María = " + ContaDaMaria.saldo);
            Console.WriteLine("Saldo do Bruno = " + contaDoBruno.saldo);


            Console.ReadLine();

        }
    }
}
