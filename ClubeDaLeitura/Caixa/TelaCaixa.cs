using ClubeDaLeitura.Amigo;

namespace ClubeDaLeitura.Caixa
{
    internal class TelaCaixa
    {
        public static string ApresentarMenuTelaCadastro()
        {
            Console.Clear();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("(1) Criar Caixa");
                Console.WriteLine("(2) Listar Caixa");
                Console.WriteLine("(3) Editar Caixa");
                Console.WriteLine("(4) Deletar Caixa");
                Console.WriteLine("(S) Voltar ao Menu Principal");

                string opcao = Console.ReadLine().ToUpper();

                return opcao;
            }
        }
        public static void InserirNovaCaixa()
        {
            ClasseCaixa novoCaixa = ObterCaixa();

            CadastroCaixa.CriarCaixa(novoCaixa);

            Mensagem.ApresentarMensagem("Caixa criado com sucesso!", ConsoleColor.Green);
        }

        public static void EditarCadastroCaixa()
        {
            int idSelecionado = ReceberIdCaixa();
            ClasseCaixa caixaAtualizada = ObterCaixa();


            CadastroCaixa.Editar(idSelecionado, caixaAtualizada);
        }
        public static void ListarCaixa()
        {
            List<ClasseCaixa> listaCaixa = CadastroCaixa.SelecionarTodos();

            Console.Clear();

            Console.WriteLine("ID   |    COR    | ETIQUETA");

            if (listaCaixa.Count == 0)
            {
                Mensagem.ApresentarMensagem("Nenhuma caixa cadastrado!", ConsoleColor.DarkYellow);
                return;
            }

            foreach (var caixa in listaCaixa)
            {
                Console.WriteLine("{0,-5}|{1,-12}|{2,-13}", caixa.IdCaixa, caixa.Cor, caixa.Etiqueta);
            }

            Console.ReadKey();
        }

        public static void DeletarCadastroCaixa()
        {
            int idSelecionado = ReceberIdCaixa();
            CadastroCaixa.Deletar(idSelecionado);
            Mensagem.ApresentarMensagem("Caixa excluídA com sucesso!", ConsoleColor.Green);
        }

        public static int ReceberIdCaixa()
        {
            bool idInvalido;
            int id;
            do
            {
                Console.WriteLine("Digite o id da Caixa: ");
                id = int.Parse(Console.ReadLine());

                idInvalido = CadastroCaixa.SelecionarCaixaPorId(id) == null;

                if (idInvalido)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("id Inválido, tente novamente");
                    Console.ResetColor();
                }
            } while (idInvalido);

            return id;
        }
        public static ClasseCaixa ObterCaixa()
        {
            Console.WriteLine("Digite a cor da caixa: ");
            string cor = Console.ReadLine();

            Console.WriteLine("Digite o nome da etiqueta: ");
            string etiqueta = Console.ReadLine();

            ClasseCaixa caixa = new ClasseCaixa(cor, etiqueta, CadastroCaixa.ContadorIdCaixa);

            return caixa;
        }
    }
}