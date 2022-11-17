using BLL;
using Models;
using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {

            Eleitor eleitor = new Eleitor("Felisberto", "565656");

            EleitorBLL eleitorBLL = new EleitorBLL();
            eleitorBLL.Inserir(eleitor);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        try
        {

            Candidato candidato = new Candidato("Juvenal", 12);

            CandidatoBLL candidatoBLL = new CandidatoBLL();
            candidatoBLL.Inserir(candidato);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

