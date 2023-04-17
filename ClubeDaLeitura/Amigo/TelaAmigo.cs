
namespace ClubeDaLeitura.Amigo
{
    internal class TelaAmigo
    {
        public static string ApresentarMenuTelaCadastro()
        {
            Console.Clear();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("(1) Criar Amigo");
                Console.WriteLine("(2) Listar Amigo");
                Console.WriteLine("(3) Editar Amigo");
                Console.WriteLine("(4) Deletar Amigos");
                Console.WriteLine("(S) Voltar ao Menu Principal");

                string opcao = Console.ReadLine().ToUpper();

                return opcao;
            }
        }
        public static void InserirNovoAmigo()
        {
            ClasseAmigo novoAmigo = ObterAmigo();

            CadastroAmigo.CriarAmigo(novoAmigo);

            Mensagem.ApresentarMensagem("Amigo criado com sucesso!", ConsoleColor.Green);
        }
        public static void EditarCadastroAmigo()
        {
            int idSelecionado = ReceberIdAmigo();
            ClasseAmigo amigoAtualizado = ObterAmigo();


            CadastroAmigo.Editar(idSelecionado, amigoAtualizado);
        }
        public static void ListarAmigo()
        {
            List<ClasseAmigo> listaAmigos = CadastroAmigo.SelecionarTodos();

            Console.Clear();

            Console.WriteLine("ID   |    NOME    | RESPONSÁVEL | TELEFONE |  ENDEREÇO  |");

            if (listaAmigos.Count == 0)
            {
                Mensagem.ApresentarMensagem("Nenhum equipamento cadastrado!", ConsoleColor.DarkYellow);
                return;
            }

            foreach (var amigo in listaAmigos)
            {
                Console.WriteLine("{0,-5}|{1,-12}|{2,-13}|{3,-10}|{4,-12}|", amigo.IdAmigo, amigo.NomeAmigo, amigo.NomeResponsavel, amigo.Telefone, amigo.Endereco);
            }

            Console.ReadKey();
        }
        public static void DeletarCadastroAmigo()
        {
            int idSelecionado = ReceberIdAmigo();
            CadastroAmigo.Deletar(idSelecionado);
            Mensagem.ApresentarMensagem("Equipamento excluído com sucesso!", ConsoleColor.Green);
        }
        public static int ReceberIdAmigo()
        {
            bool idInvalido;
            int id;
            do
            {
                Console.WriteLine("Digite o id do amigo: ");
                id = int.Parse(Console.ReadLine());

                idInvalido = CadastroAmigo.SelecionarAmigoPorId(id) == null;

                if (idInvalido)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("id Inválido, tente novamente");
                    Console.ResetColor();
                }
            } while (idInvalido);

            return id;
        }
        public static ClasseAmigo ObterAmigo()
        {
            Console.WriteLine("Digite o nome do amigo: ");
            string nomeAmigo = Console.ReadLine();

            Console.WriteLine("Digite o nome do responsável: ");
            string nomeResponsavel = Console.ReadLine();

            Console.WriteLine("Digite o número do telefone do amigo: ");
            string telefone = Console.ReadLine();

            Console.WriteLine("Digite o endereço do amigo: ");
            string endereco = Console.ReadLine();


            ClasseAmigo amigo = new ClasseAmigo(nomeAmigo, nomeResponsavel, endereco, telefone, CadastroAmigo.ContadorIdAmigo);

            return amigo;
        }
    }
}