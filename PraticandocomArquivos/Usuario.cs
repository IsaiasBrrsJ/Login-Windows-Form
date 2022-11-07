using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandocomArquivos
{
   public class Usuario
    {
        private string _nome;
        private string _email;
        private string _senha;

        public Usuario(string nome, string email, string senha)
        {
            _nome = nome;
            _email = email;
            _senha = senha;
        }

        public string getNome() => _nome;
        public string getEmail() => _email;
        public string getSenha() => _senha;
    }
}
