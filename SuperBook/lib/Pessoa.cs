using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBook
{
    public abstract class Pessoa    //aqui o utilizador e VIP partilham as mesmas propriedades: nome,id,email e senha, por isso não precisamos por nas outras
    {
        public string nome;
        public int id;
        public string email;
        public int senha;

        public abstract string informacao();

    }
}
