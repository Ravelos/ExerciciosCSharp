using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    public class Cliente
    {
        // melhorando o código com get e set para as propiedades com prop
        private string _cpf;
        public string Nome { get; set; }
        public string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                //Criar logica aqui

                _cpf = value;
            }
        }

        public string  Profissao { get; set; }

    }
}
