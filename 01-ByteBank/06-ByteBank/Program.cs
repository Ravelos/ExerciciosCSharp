using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
     class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente();

            Cliente cliente = new Cliente();

            // Foram modificados os campos nome, profissao e cpf

            cliente.Nome = "Oswaldo";
            cliente.CPF = "789.654.789-32";
            cliente.Profissao = "Desenvolvedor";


            conta.Saldo= -10;
            conta.Titular = cliente;

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);
            

            Console.ReadLine();

        }
    }
}
