using ClubeDaLeitura.Amigo;
using ClubeDaLeitura.Caixa;

namespace ClubeDaLeitura.Revista
{
    internal class TelaRevista
    {
        public static string ApresentarMenuTelaCadastro()
        {
            Console.Clear();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("(1) Criar Revista");
                Console.WriteLine("(2) Listar Revista");
                Console.WriteLine("(3) Editar Revista");
                Console.WriteLine("(4) Deletar Revista");
                Console.WriteLine("(S) Voltar ao Menu Principal");

                string opcao = Console.ReadLine().ToUpper();

                return opcao;
            }
        }
        public static void InserirNovaRevista()
        {
            ClasseRevista novaRevista = ObterRevista();

            CadastroRevista.CriarRevista(novaRevista);

            Mensagem.ApresentarMensagem("Revista criado com sucesso!", ConsoleColor.Green);
        }
        public static void EditarCadastroRevista()
        {
            int idSelecionado = ReceberIdRevista();
            ClasseRevista revistaAtualizado = ObterRevista();


            CadastroRevista.Editar(idSelecionado, revistaAtualizado);
        }
        public static void ListarRevista()
        {
            List<ClasseRevista> listaRevista = CadastroRevista.SelecionarTodos();

            Console.Clear();

            Console.WriteLine("ID   |    COLEÇÃO    |    ANO    |  EDICAO  |  CAIXA  |");

            if (listaRevista.Count == 0)
            {
                Mensagem.ApresentarMensagem("Nenhuma revista cadastrado!", ConsoleColor.DarkYellow);
                return;
            }

            foreach (var revista in listaRevista)
            {
                Console.WriteLine("{0,-5}|{1,-12}|{2,-13}|{3,-10}|{4,-12}|", revista.IdRevista, revista.Colecao, revista.Ano, revista.CaixaQueGuarda);
            }

            Console.ReadKey();
        }
        public static void DeletarCadastroRevista()
        {
            int idSelecionado = ReceberIdRevista();
            CadastroRevista.Deletar(idSelecionado);
            Mensagem.ApresentarMensagem("revista excluída com sucesso!", ConsoleColor.Green);
        }
        public static int ReceberIdRevista()
        {
            bool idInvalido;
            int id;
            do
            {
                Console.WriteLine("Digite o id da revista: ");
                id = int.Parse(Console.ReadLine());

                idInvalido = CadastroRevista.SelecionarRevistaPorId(id) == null;

                if (idInvalido)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("id Inválido, tente novamente");
                    Console.ResetColor();
                }
            } while (idInvalido);

            return id;
        }
        public static ClasseRevista ObterRevista()
        {
            Console.WriteLine("Digite o nome da coleção: ");
            string Colecao = Console.ReadLine();

            Console.WriteLine("Digite o ano de publicação: ");
            string Ano = Console.ReadLine();

            Console.WriteLine("Digite o número da edição: ");
            string Edicao = Console.ReadLine();

            Console.WriteLine("Digite o id da caixa que a revista pertence: ");
            int idDaCaixa = int.Parse(Console.ReadLine());

            ClasseCaixa caixa = null;

            foreach (ClasseCaixa c in CadastroCaixa.Caixas)
            {
                if (idDaCaixa == c.IdCaixa)
                {
                    caixa = c;
                }
            }
            while (caixa == null)
            {
                Mensagem.ApresentarMensagem("Caixa inexistente!", ConsoleColor.Red);
                Console.WriteLine("Digite o id da caixa que a revista pertence: ");
                idDaCaixa = int.Parse(Console.ReadLine());

                foreach (ClasseCaixa c in CadastroCaixa.Caixas)
                {
                    if (idDaCaixa == c.IdCaixa)
                    {
                        caixa = c;
                    }
                }
            }



            ClasseRevista revista = new ClasseRevista(CadastroRevista.ContadorIdRevista, Colecao, Ano, Edicao, caixa);

            return revista;
        }
    }
}