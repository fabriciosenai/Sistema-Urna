using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Candidato
    {
        private string nome;
        private int numeroCandidato;


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int NumeroCandidato
        {
            get { return numeroCandidato; }
            set { numeroCandidato = value; }
        }
        public Candidato(string _nome, int _numeroCandidato)
        {
            nome = _nome;
            NumeroCandidato = _numeroCandidato;

        }


    }

}

