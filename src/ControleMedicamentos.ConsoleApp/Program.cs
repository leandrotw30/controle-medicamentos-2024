using ControleMedicamentos.ConsoleApp.ModuloMedicamento;
using ControleMedicamentos.ConsoleApp.ModuloPaciente;
using ControleMedicamentos.ConsoleApp.ModuloRequisicao;

namespace ControleMedicamentos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositorioMedicamento repositorioM = new RepositorioMedicamento();
            RepositorioPaciente repositorioP = new RepositorioPaciente();
            RepositorioRequisicao repositorioR = new RepositorioRequisicao();

            repositorioR.repositorioMedicamento = repositorioM;
            repositorioR.repositorioPaciente = repositorioP;

            TelaRequisicao telaRequisicao = new TelaRequisicao();
            telaRequisicao.repositorioRequisicao = repositorioR;

            TelaPaciente telaPaciente = new TelaPaciente();
            telaPaciente.repositorioPaciente = repositorioP;

            TelaMedicamento telaMedicamento = new TelaMedicamento();
            telaMedicamento.repositorioMedicamento = repositorioM;

            bool opcaoSairSelecionada = false;

            while (!opcaoSairSelecionada)
            {
                char opcaoMenuPrincipal = ApresentarMenuPrincipal();

                if (opcaoMenuPrincipal == '1')
                {
                    while (true)
                    {
                        char opcaoMenuMedicamento = telaMedicamento.ApresentarMenuMedicamento();

                        if (opcaoMenuMedicamento == 'S' || opcaoMenuMedicamento == 's')
                            break;

                        switch (opcaoMenuMedicamento)
                        {
                            case '1':
                                telaMedicamento.CadastrarMedicamento(); break;

                            case '2':
                                telaMedicamento.VerificarDisponibilidade(); break;

                            case '3':
                                telaMedicamento.AtualizarQuantidade(); break;

                            case '4':
                                telaMedicamento.VisualizarBaixaQuantidade(); break;

                            case '5':
                                telaMedicamento.MedicamentosMaisRetirados(); break;

                            case '6':
                                telaMedicamento.MedicamentosEmFalta(); break;

                            default:
                                Console.WriteLine("Opção inválida. Tente novamente!"); break;
                        }
                    }
                }
                else if (opcaoMenuPrincipal == '2')
                    telaPaciente.CadastrarPaciente();

                else if (opcaoMenuPrincipal == '3')
                    telaRequisicao.CadastrarRequisicao();

                else if (opcaoMenuPrincipal.Equals('S') || opcaoMenuPrincipal.Equals('s'))
                    opcaoSairSelecionada = true;

                else
                    Console.WriteLine("Opção inválida. Tente novamente!");
            }
        }

        public static char ApresentarMenuPrincipal()
        {
            Console.Clear();

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("|        Controle de Medicamentos dos Postos de Saúde        |");
            Console.WriteLine("--------------------------------------------------------------");

            Console.WriteLine();


            Console.WriteLine("Digite 1 para gerenciar o controle de MEDICAMENTOS");
            Console.WriteLine("Digite 2 para gerenciar o controle de PACIENTES");
            Console.WriteLine("Digite 3 para gerenciar o controle de REQUISIÇÕES");
            Console.WriteLine("Digite S para sair");
            char opcaoMenuPrincipal = Convert.ToChar(Console.ReadLine());

            return opcaoMenuPrincipal;
        }
    }
}

