using System.Runtime.ConstrainedExecution;

namespace ClubeDaLeitura.Amigo
{
    public class ClasseAmigo
    {
        public int IdAmigo { get; set; }
        public string NomeAmigo { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string NomeResponsavel { get; set; }

        public ClasseAmigo(string nomeAmigo, string telefone, string endereço, string nomeResponsavel, int idAmigo)
        {
            NomeAmigo = nomeAmigo;
            Telefone = telefone;
            Endereco = endereço;
            NomeResponsavel = nomeResponsavel;
            IdAmigo = idAmigo;
        }
    }
}