using ClubeDaLeitura.Amigo;
using ClubeDaLeitura.Caixa;
using ClubeDaLeitura.Revista;

namespace ClubeDaLeitura.Emprestimo
{
    internal class TelaEmprestimo
    {
        public static string ApresentarMenuTelaCadastro()
        {
            Console.Clear();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("(1) Criar Emprestimo");
                Console.WriteLine("(2) Listar Emprestimo");
                Console.WriteLine("(3) Editar Emprestimo");
                Console.WriteLine("(4) Deletar Emprestimo");
                Console.WriteLine("(S) Voltar ao Menu Principal");

                string opcao = Console.ReadLine().ToUpper();

                return opcao;
            }
        }
        public static void InserirNovoEmprestimo()
        {
            ClasseEmprestimo novaEmprestimo = ObterEmprestimo();

            CadastroEmprestimo.CriarEmprestimo(novaEmprestimo);

            Mensagem.ApresentarMensagem("Emprestimo criado com sucesso!", ConsoleColor.Green);
        }
        public static void EditarCadastroEmprestimo()
        {
            int idSelecionado = ReceberIdEmprestimo();
            ClasseEmprestimo emprestimoAtualizado = ObterEmprestimo();


            CadastroEmprestimo.Editar(idSelecionado, emprestimoAtualizado);
        }
        public static void ListarEmprestimo()
        {
            List<ClasseEmprestimo> listaEmprestimo = CadastroEmprestimo.SelecionarTodos();

            Console.Clear();

            Console.WriteLine("ID   |    AMIGO    | REVISTA | DATA SAIDA |  DATA DEVOLUÇÃO  |");

            if (listaEmprestimo.Count == 0)
            {
                Mensagem.ApresentarMensagem("Nenhuma revista cadastrado!", ConsoleColor.DarkYellow);
                return;
            }

            foreach (var emprestimo in Emprestimos)
            {
                Console.WriteLine("{0,-5}|{1,-12}|{2,-13}|{3,-10}|{4,-12}|", emprestimo.TdEmprestimo, emprestimo.AmigoEmprestimo, emprestimo.RevistaEmprestada, emprestimo.DataSaida, emprestimo.DataDevolucao);
            }

            Console.ReadKey();
        }
        public static void DeletarCadastroEmprestimo()
        {
            int idSelecionado = ReceberIdEmprestimo();
            CadastroEmprestimo.Deletar(idSelecionado);
            Mensagem.ApresentarMensagem("emprestimo excluído com sucesso!", ConsoleColor.Green);
        }
        public static int ReceberIdEmprestimo()
        {
            bool idInvalido;
            int id;
            do
            {
                Console.WriteLine("Digite o id do emprestimo: ");
                id = int.Parse(Console.ReadLine());

                idInvalido = CadastroEmprestimo.SelecionarEmprestimoPorId(id) == null;

                if (idInvalido)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("id Inválido, tente novamente");
                    Console.ResetColor();
                }
            } while (idInvalido);

            return id;
        }
        public static ClasseEmprestimo ObterEmprestimo()
        {
            Console.WriteLine("Digite o id amigo que pegou a revista: ");
            int idAmigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ID da revista emprestada: ");
            int idRevistaEmprestada = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite data de emprestimo: ");
            string idEmprestimo = Console.ReadLine();

            Console.WriteLine("Digite a data de saída: ");
            string dataSaida = Console.ReadLine();

            Console.WriteLine("Digite a data de devolução: ");
            string dataDevolucao = Console.ReadLine();


            ClasseAmigo amigo = null;
            ClasseRevista revista = null;

            foreach (ClasseAmigo a in CadastroAmigo.Amigos)
            {
                if (idAmigo == a.IdAmigo)
                {
                    amigo = a;
                }
            }
            foreach (ClasseRevista r in CadastroRevista.Revistas)
            {
                if (idRevistaEmprestada == r.IdRevista)
                {
                    revista = r;
                }
            }

            ClasseEmprestimo emprestimo = new ClasseEmprestimo(CadastroEmprestimo.ContadorIdEmprestimo, dataSaida, dataDevolucao, amigo, revista);

            return emprestimo;
        }
    }
}