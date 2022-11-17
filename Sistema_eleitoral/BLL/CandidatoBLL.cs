using System;
using Models;
using DAL;

namespace BLL
{
    public class CandidatoBLL
    {
        public void Inserir(Candidato _candidato)
        {
            if (_candidato.Nome.Length <= 2)
            {
                throw new Exception("Nome do eleitor deve ter mais de 2 caracteres.");
            }

            CandidatoDAL candidatoDAL = new CandidatoDAL();
            candidatoDAL.Inserir(_candidato);
        }

        public void Excuir(Candidato _candidato)
        {
            if (_candidato.Nome.Length <= 2)
            {
                throw new Exception("Nome do eleitor deve ter mais de 2 caracteres.");
            }
            CandidatoDAL candidatoDAL = new CandidatoDAL();
            candidatoDAL.Excluir(_candidato);
        }

        public void Alterar(Candidato Candidato)
        {
            CandidatoDAL candidatoDAL = new CandidatoDAL();
            candidatoDAL.Alterar(Candidato);
        }

        public List<Candidato> Buscar(string _titulo)
        {
            CandidatoDAL candidatoDAL = new CandidatoDAL();
            return candidatoDAL.Buscar(_titulo);
        }
    }
}