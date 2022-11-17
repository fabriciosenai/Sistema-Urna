using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    public class EleitorBLL
    {
        public void Inserir(Eleitor _eleitor)
        {
         /*   if (_eleitor.Nome.Length <= 2)
            {
                throw new Exception("O nome do eleitor deve ter mais de 2 caracter");
            }*/
            EleitorDAL eleitorDAL = new EleitorDAL();
            eleitorDAL.Inserir(_eleitor);
        }
        public void Excluir(Eleitor _eleitor)
        {
            EleitorDAL eleitorDAL = new EleitorDAL();
            eleitorDAL.Excluir(_eleitor);
        }
        public void Alterar(Eleitor _eleitor)
        {
            if (_eleitor.Nome.Length <= 2)
            {
                throw new Exception("O nome do eleitor deve ter mais de 2 caracter");
            }

            EleitorDAL eleitorDAL = new EleitorDAL();
            eleitorDAL.Alterar(_eleitor);
        }
        public DataTable BuscarPorTitulo(string _titulo)
        {
            EleitorDAL eleitorDAL = new EleitorDAL();
            return eleitorDAL.BuscarPorTitulo(_titulo);
        }
    }
}