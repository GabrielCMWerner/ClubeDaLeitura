using ClubeDaLeitura.Amigo;

namespace ClubeDaLeitura.Revista
{
    internal class CadastroRevista
    {
        public static List<ClasseRevista> Revistas = new List<ClasseRevista>();
        public static int ContadorIdRevista = 4;

        public static void CadastrarRevista(ClasseRevista revista)
        {
            Revistas.Add(revista);
        }
        public static void CriarRevista(ClasseRevista revista)
        {
            CadastrarRevista(revista);
            ContadorIdRevista++;
        }
        public static void Editar(int idEditar, ClasseRevista revistaAtualizado)
        {
            ClasseRevista revista = SelecionarRevistaPorId(idEditar);

            revista.Colecao = revistaAtualizado.Colecao;
            revista.Ano = revistaAtualizado.Ano;
            revista.Edicao = revistaAtualizado.Edicao;
            revista.CaixaQueGuarda = revistaAtualizado.CaixaQueGuarda;
        }
        public static void Deletar(int id)
        {
            ClasseRevista revista = SelecionarRevistaPorId(id);
            Revistas.Remove(revista);
        }
        public static List<ClasseRevista> SelecionarTodos()
        {
            return Revistas;
        }
        public static ClasseRevista SelecionarRevistaPorId(int id)
        {
            ClasseRevista revista = null;

            foreach (ClasseRevista a in Revistas)
            {
                if (a.IdRevista == id)
                {
                    revista = a;
                    break;
                }
            }

            return revista;
        }
    }
}
