using DAL;
using Models;

namespace BLL
{
    public class EleicaoBLL
    {
        public void Inserir(Eleicao _eleicao)
        {
            EleicaoDAL eleitorDAL = new EleicaoDAL();
            eleitorDAL.Inserir(_eleicao);
        }
        public void Excluir(Eleicao _eleicao)
        {
            EleicaoDAL eleicaoDAL = new EleicaoDAL();
            eleicaoDAL.Excluir(_eleicao);
        }
        public void Alterar(Eleicao _eleicao)
        {
            EleicaoDAL eleicaoDAL = new EleicaoDAL();
            eleicaoDAL.Alterar(_eleicao);
        }
        public List<Eleicao> Buscar()
        {
            EleicaoDAL eleicaoDAL = new EleicaoDAL();
            return eleicaoDAL.Buscar();
        }
    }
}