namespace ClubeDaLeitura.Amigo
{
    internal class CadastroAmigo
    {
        public static List<ClasseAmigo> Amigos = new List<ClasseAmigo>();
        public static int ContadorIdAmigo = 4;

        public static void CadastrarAmigo(ClasseAmigo amigo)
        {
            Amigos.Add(amigo);
        }
        public static void CriarAmigo(ClasseAmigo amigo)
        {
            CadastrarAmigo(amigo);
            ContadorIdAmigo++;
        }
        public static void Editar(int idEditar, ClasseAmigo amigoAtualizado)
        {
            ClasseAmigo amigo = SelecionarAmigoPorId(idEditar);

            amigo.NomeAmigo = amigoAtualizado.NomeAmigo;
            amigo.NomeResponsavel = amigoAtualizado.NomeResponsavel;
            amigo.Telefone = amigoAtualizado.Telefone;
            amigo.Endereco = amigoAtualizado.Endereco;
        }
        public static void Deletar(int id)
        {
            ClasseAmigo amigo = SelecionarAmigoPorId(id);
            Amigos.Remove(amigo);
        }
        public static List<ClasseAmigo> SelecionarTodos()
        {
            return Amigos;
        }
        public static ClasseAmigo SelecionarAmigoPorId(int id)
        {
            ClasseAmigo amigo = null;

            foreach (ClasseAmigo a in Amigos)
            {
                if (a.IdAmigo == id)
                {
                    amigo = a;
                    break;
                }
            }

            return amigo;
        }
    }
}