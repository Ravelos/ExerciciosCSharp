﻿using System;
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

            cliente.nome = "Oswaldo";
            cliente.cpf = "789.654.789-32";
            cliente.profissao = "Desenvolvedor";


            conta.Saldo= -10;
            conta.Titular = cliente;

            Console.WriteLine(conta.Titular.nome);
            Console.WriteLine(conta.Saldo);
            

            Console.ReadLine();

        }
    }
}
