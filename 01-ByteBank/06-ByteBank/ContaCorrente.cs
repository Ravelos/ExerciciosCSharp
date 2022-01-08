


namespace _06_ByteBank 
{
    public class ContaCorrente
    {
        private Cliente _titular;

        public Cliente Titular { get; set; }    




        public int agencia;
        public int numero;
        private double _saldo = 100;
        // Atualizando o nome do campo saldo com underscore para mostrar que é um campo privado

        public double Saldo
        {
            get
            {
                return _saldo;
            }

            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }
        

        //Criamos metodos sacar depositar transferir
        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;

        }

        // As clases VOID não retornam nehum valor
        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }
    }
}

  





