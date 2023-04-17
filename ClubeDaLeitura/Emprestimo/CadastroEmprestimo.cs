using ClubeDaLeitura.Revista;

namespace ClubeDaLeitura.Emprestimo
{
    internal class CadastroEmprestimo
    {
        public static List<ClasseEmprestimo> Emprestimos = new List<ClasseEmprestimo>();
        public static int ContadorIdEmprestimo = 4;

        public static void CadastrarEmprestimo(ClasseEmprestimo emprestimo)
        {
            Emprestimos.Add(emprestimo);
        }
        public static void CriarEmprestimo(ClasseEmprestimo emprestimo)
        {
            CadastrarEmprestimo(emprestimo);
            ContadorIdEmprestimo++;
        }
        public static void Editar(int idEditar, ClasseEmprestimo emprestimoAtualizado)
        {
            ClasseEmprestimo emprestimo = SelecionarEmprestimoPorId(idEditar);

            emprestimo.AmigoEmprestimo = emprestimoAtualizado.AmigoEmprestimo;
            emprestimo.RevistaEmprestada = emprestimoAtualizado.RevistaEmprestada;
            emprestimo.DataSaida = emprestimoAtualizado.DataSaida;
            emprestimo.DataDevolucao = emprestimoAtualizado.DataDevolucao;
            
        }
        public static void Deletar(int id)
        {
            ClasseEmprestimo emprestimo = SelecionarEmprestimoPorId(id);
            Emprestimos.Remove(emprestimo);
        }
        public static List<ClasseEmprestimo> SelecionarTodos()
        {
            return Emprestimos;
        }
        public static ClasseEmprestimo SelecionarEmprestimoPorId(int id)
        {
            ClasseEmprestimo emprestimo = null;

            foreach (ClasseEmprestimo a in Emprestimos)
            {
                if (a.TdEmprestimo == id)
                {
                    emprestimo = a;
                    break;
                }
            }

            return emprestimo;
        }

    }
}