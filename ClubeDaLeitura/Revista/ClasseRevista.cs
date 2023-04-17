using ClubeDaLeitura.Caixa;

namespace ClubeDaLeitura.Revista
{
    public class ClasseRevista
    {
        public int IdRevista { get; set; }
        public string Colecao { get; set; }
        public string Ano { get; set; }
        public string Edicao { get; set; }

        public ClasseCaixa CaixaQueGuarda;


        public ClasseRevista(int id, string colecao, string ano, string edicao, ClasseCaixa caixaQueGuarda)
        {
            IdRevista = id;
            Colecao = colecao;
            Ano = ano;
            Edicao = edicao;
            CaixaQueGuarda = caixaQueGuarda;
        }
    }
}