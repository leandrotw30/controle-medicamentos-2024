using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ConsoleApp.ModuloMedicamento
{
    public class TelaMedicamento
    {
        public RepositorioMedicamento repositorioMedicamento;

        public char ApresentarMenuMedicamento()
        {
            Console.Clear();

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("|        Gerenciamento do Controle de Medicamentos           |");
            Console.WriteLine("--------------------------------------------------------------");

            Console.WriteLine();

            Console.WriteLine("Digite 1 para cadastrar um novo medicamento");
            Console.WriteLine("Digite 2 para verificar a disponibilidade do medicamento");
            Console.WriteLine("Digite 3 para atualizar o estoque de medicamentos");
            Console.WriteLine("Digite 4 para visualizar os medicamentos com baixas quantidades");
            Console.WriteLine("Digite 5 para os medicamentos mais retirados");
            Console.WriteLine("Digite 6 para o medicamentos que estão em falta");
            Console.WriteLine("Digite S para voltar ao menu principal");
            char opcaoMenuMedicamento = Convert.ToChar(Console.ReadLine());

            return opcaoMenuMedicamento;
        }

        public void CadastrarMedicamento()
        {
            Console.Clear();

            Console.WriteLine("Cadastrando um Novo Medicamento");
            Console.WriteLine();

            Console.Write("Digite o nome do medicamento: ");
            string nomeMedicamento = Console.ReadLine().ToUpper();
            Console.Write("Digite a descrição do medicamento: ");
            string descricao = Console.ReadLine().ToUpper();
            Console.Write("Digite a quantidade: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Medicamento medicamento = new Medicamento(nomeMedicamento, descricao, quantidade);

            repositorioMedicamento.CadastrarMedicamento(medicamento);

            Console.WriteLine();
            Console.WriteLine("Tecle 'enter' para retornar ao menu principal!");
            Console.ReadLine();
            
            ApresentarMenuMedicamento();
        }

        public void VerificarDisponibilidade()
        {
            Console.Clear();

            Console.WriteLine("Verificar a disponibilidade do medicamento");
            Console.WriteLine();

            Console.Write("Qual medicamento gostaria de verificar? ");
            string medicamentoVerificado = Console.ReadLine().ToUpper();

            Medicamento medicamento = new Medicamento();
            medicamento.NomeMedicamento = medicamentoVerificado;

            repositorioMedicamento.VerificarDisponibilidade(medicamento);

            Console.WriteLine();
            Console.WriteLine("Tecle 'enter' para retornar ao menu principal!");
            Console.ReadLine();

            ApresentarMenuMedicamento();
        }

        public void AtualizarQuantidade()
        {
            Console.Clear();

            Console.Write("Digite o nome do medicamento que deseja alterar a quantidade: ");
            string buscaMedicamento = Console.ReadLine().ToUpper();

            Console.Write("Digite a quantidade do medicamento que deseja alterar: ");
            int quantidadeParaAlterar = Convert.ToInt32(Console.ReadLine());

            repositorioMedicamento.AtualizarQuantidade(buscaMedicamento, quantidadeParaAlterar);

            Console.WriteLine();
            Console.WriteLine("Tecle 'enter' para retornar ao menu principal!");
            Console.ReadLine();

            ApresentarMenuMedicamento();
        }

        public void VisualizarBaixaQuantidade()
        {
            Console.Clear();

            repositorioMedicamento.VisualizarBaixaQuantidade();

            Console.WriteLine();
            Console.WriteLine("Tecle 'enter' para retornar ao menu principal!");
            Console.ReadLine();

            ApresentarMenuMedicamento();
        }

        public void MedicamentosMaisRetirados()
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("Os seguintes medicamentos são os mais retirados do estoque:");
            Console.WriteLine();

            repositorioMedicamento.VerificarMedicamentosMaisRetirados();

            Console.WriteLine();
            Console.WriteLine("Tecle 'enter' para retornar ao menu principal!");
            Console.ReadLine();

            ApresentarMenuMedicamento();
        }

        public void MedicamentosEmFalta()
        {
            Console.Clear();

            repositorioMedicamento.MedicamentosEmFalta();

            Console.WriteLine();
            Console.WriteLine("Tecle 'enter' para retornar ao menu principal!");
            Console.ReadLine();

            ApresentarMenuMedicamento();
        }

        public void SairMenuMedicamento()
        {
            Program.ApresentarMenuPrincipal();
        }
    }
}
