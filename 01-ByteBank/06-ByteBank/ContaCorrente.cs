﻿


namespace _06_ByteBank 
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        private double saldo = 100;

        public void DefinirSaldo(double saldo)
        {
            if (saldo < 0)
            {
                return;
            }
            this.saldo = saldo;
                       
        }
        // Método para obter o saldo

        public double ObterSaldo()
        {
            return saldo;
        }

        //Criamos metodos sacar depositar transferir
        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }

            saldo -= valor;
            return true;

        }

        // As clases VOID não retornam nehum valor
        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (saldo < valor)
            {
                return false;
            }

            saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }
    }
}

  




