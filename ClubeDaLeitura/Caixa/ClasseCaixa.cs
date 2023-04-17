using System.Runtime.ConstrainedExecution;

namespace ClubeDaLeitura.Caixa
{
    public class ClasseCaixa
    {
        public int IdCaixa { get; set; }
        public string Cor { get; set; }
        public string Etiqueta { get; set; }

        public ClasseCaixa(string cor, string etiqueta, int idCaixa)
        {
            Cor = cor;
            Etiqueta = etiqueta;
            IdCaixa = idCaixa;
        }
    }
}