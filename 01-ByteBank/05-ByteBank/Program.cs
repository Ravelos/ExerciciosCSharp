using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cliente Maria = new Cliente();
            //Maria.nome = "Maria";
            //Maria.profissao = "Desenvolvedora C#";
            //Maria.cpf = "434.562.897-52";

            ContaCorrente conta = new ContaCorrente();

            //conta.titular = Maria;
            conta.titular = new Cliente();
            conta.titular.cpf = "434.562.897-52";
            conta.titular.nome = "Maria Costa";
            conta.titular.profissao = "Desenvolvedora C#";



            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634595;

            conta.titular.nome = "Maria Costa";

            //Console.WriteLine(Maria.nome);

            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.titular.profissao);

            Console.ReadLine();


        }
    }
}
