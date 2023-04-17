using ClubeDaLeitura.Amigo;
using ClubeDaLeitura.Caixa;
using ClubeDaLeitura.Emprestimo;
using ClubeDaLeitura.Revista;

namespace ClubeDaLeitura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string opcao = ApresentarMenuPrincipal();

                if (opcao == "s")
                    break;

                else if (opcao == "1")
                {
                    string opcaoCadastroCaixa = TelaCaixa.ApresentarMenuTelaCadastro();

                    if (opcaoCadastroCaixa == "s")
                        continue;

                    if (opcaoCadastroCaixa == "1")
                    {
                        TelaCaixa.InserirNovaCaixa();
                    }
                    else if (opcaoCadastroCaixa == "2")
                    {
                        TelaCaixa.ListarCaixa();
                    }
                    else if (opcaoCadastroCaixa == "3")
                    {
                        TelaCaixa.EditarCadastroCaixa();
                    }
                    else if (opcaoCadastroCaixa == "4")
                    {
                        TelaCaixa.DeletarCadastroCaixa();
                    }

                }
                else if (opcao == "2")
                {
                    string opcaoCadastroAmigo = TelaAmigo.ApresentarMenuTelaCadastro();

                    if (opcaoCadastroAmigo == "s")
                        continue;

                    if (opcaoCadastroAmigo == "1")
                    {
                        TelaAmigo.InserirNovoAmigo();
                    }
                    else if (opcaoCadastroAmigo == "2")
                    {
                        TelaAmigo.ListarAmigo();
                    }
                    else if (opcaoCadastroAmigo == "3")
                    {
                        TelaAmigo.EditarCadastroAmigo();
                    }
                    else if (opcaoCadastroAmigo == "4")
                    {
                        TelaAmigo.DeletarCadastroAmigo();
                    }

                    else if (opcao == "3")
                    {
                        string opcaoCadastroRevista = TelaRevista.ApresentarMenuTelaCadastro();

                        if (opcaoCadastroRevista == "s")
                            continue;

                        if (opcaoCadastroRevista == "1")
                        {
                            TelaRevista.InserirNovaRevista();
                        }
                        else if (opcaoCadastroRevista == "2")
                        {
                            TelaRevista.ListarRevista();
                        }
                        else if (opcaoCadastroRevista == "3")
                        {
                            TelaRevista.EditarCadastroRevista();
                        }
                        else if (opcaoCadastroRevista == "4")
                        {
                            TelaRevista.DeletarCadastroRevista();
                        }

                        else if (opcao == "3")
                        {
                            string opcaoCadastroEmprestimo = TelaEmprestimo.ApresentarMenuTelaCadastro();

                            if (opcaoCadastroEmprestimo == "s")
                                continue;

                            if (opcaoCadastroEmprestimo == "1")
                            {
                                TelaEmprestimo.InserirNovoEmprestimo();
                            }
                            else if (opcaoCadastroEmprestimo == "2")
                            {
                                TelaEmprestimo.ListarEmprestimo();
                            }
                            else if (opcaoCadastroEmprestimo == "3")
                            {
                                TelaEmprestimo.EditarCadastroEmprestimo();
                            }
                            else if (opcaoCadastroEmprestimo == "4")
                            {
                                TelaEmprestimo.DeletarCadastroEmprestimo();
                            }
                        }
                    }
                }
            }

            static string ApresentarMenuPrincipal()
            {
                Console.Clear();

                Console.WriteLine();

                Console.WriteLine("Clube da Leitura");

                Console.WriteLine();

                Console.WriteLine("Digite 1 para controlar o cadastro de Caixas");

                Console.WriteLine("Digite 2 para Controlar o cadastro de Amigos");

                Console.WriteLine("Digite 3 para controlar o cadastro de Revistas");

                Console.WriteLine("Digite 4 para controlar o cadastro de Emprestimos");

                Console.WriteLine();

                Console.WriteLine("Digite s para Sair");

                string opcao = Console.ReadLine();

                return opcao;
            }
        }
    }
}