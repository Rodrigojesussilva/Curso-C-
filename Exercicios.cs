using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    public class Pai
    {
        public string Nome;
        public int Idade;
        public int QtdFh;
        public bool Vivo;

        public Pai(string nome, int idade, int qtdfh, bool vivo)
        {
            Nome = nome;
            Idade = idade;
            QtdFh = qtdfh;
            Vivo = vivo;
        }

        public void Exibir()
        {
            Console.WriteLine($"O nome do pai e:{Nome}, a idade dele e:{Idade}, A quantidade de filhos e:{QtdFh}, Ele esta vivo?{Vivo}");
        }

    }
}
