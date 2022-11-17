using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Models
{
    public class Eleitor
    {
        private string nome;
        private string titulo;
        private bool votou;
        private int Id;


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public bool Votou
        {
            get { return votou; }
            set { votou = value; }
        }
        public Eleitor()
        {

        }
        public Eleitor(string _nome, string _titulo)
        {
            nome = _nome;
            titulo = _titulo;
        }
        public int id
        {
            get { return id; }
            set { id = value; }
        }


    }
}


