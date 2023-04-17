using ClubeDaLeitura.Amigo;
using ClubeDaLeitura.Caixa;
using ClubeDaLeitura.Revista;

namespace ClubeDaLeitura.Emprestimo
{
    public class ClasseEmprestimo
    {
        public string DataSaida { get; set; }
        public string DataDevolucao { get; set; }
        public int TdEmprestimo { get; set; }

        public ClasseAmigo AmigoEmprestimo;

        public ClasseRevista RevistaEmprestada;


        public ClasseEmprestimo(int id, string dataSaida, string dataDevolucao, ClasseAmigo amigoEmprestimo, ClasseRevista revistaEmprestada)
        {
            TdEmprestimo = id;
            AmigoEmprestimo = amigoEmprestimo;
            RevistaEmprestada = revistaEmprestada;
            DataSaida = dataSaida;
            DataDevolucao = dataDevolucao;

        }
    }
}