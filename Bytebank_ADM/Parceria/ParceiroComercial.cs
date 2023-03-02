using Bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Parceria
{
    public class ParceiroComercial: IAutenticavel
    {
        public string Senha { get; set; }
        public string Login { get; set; }
        public bool Autenticar(string login, string senha)
        {
            return this.Login == login && this.Senha == senha;
        }
    }
}
