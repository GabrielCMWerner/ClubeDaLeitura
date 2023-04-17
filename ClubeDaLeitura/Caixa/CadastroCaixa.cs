using ClubeDaLeitura.Caixa;

namespace ClubeDaLeitura.Caixa
{
    internal class CadastroCaixa
    {
        public static List<ClasseCaixa> Caixas = new List<ClasseCaixa>();
        public static int ContadorIdCaixa = 4;

        public static void CadastrarCaixa(ClasseCaixa caixa)
        {
            Caixas.Add(caixa);
        }

        public static void CriarCaixa(ClasseCaixa caixa)
        {
            CadastrarCaixa(caixa);
            ContadorIdCaixa++;
        }
        public static void Editar(int idEditar, ClasseCaixa caixaAtualizada)
        {
            ClasseCaixa caixa = SelecionarCaixaPorId(idEditar);

            caixa.Cor = caixaAtualizada.Cor;
            caixa.Etiqueta = caixaAtualizada.Etiqueta;
            
        }

        public static void Deletar(int id)
        {
            ClasseCaixa caixa = SelecionarCaixaPorId(id);
            Caixas.Remove(caixa);
        }
        public static List<ClasseCaixa> SelecionarTodos()
        {
            return Caixas;
        }
        public static ClasseCaixa SelecionarCaixaPorId(int id)
        {
            ClasseCaixa caixa = null;

            foreach (ClasseCaixa a in Caixas)
            {
                if (a.IdCaixa == id)
                {
                    caixa = a;
                    break;
                }
            }

            return caixa;
        }
    }
}