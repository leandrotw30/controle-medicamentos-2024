using ControleMedicamentos.ConsoleApp.ModuloMedicamento;
using ControleMedicamentos.ConsoleApp.ModuloPaciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ConsoleApp.ModuloRequisicao
{
    internal class TelaRequisicao
    {
        public RepositorioRequisicao repositorioRequisicao;

        public void CadastrarRequisicao()
        {
            Console.Clear();

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("|        Gerenciamento do Controle de Requisições            |");
            Console.WriteLine("--------------------------------------------------------------");

            Console.WriteLine();

            Console.Write("Qual o cpf do paciente? ");
            Paciente paciente = new Paciente();
            paciente.CPF = Console.ReadLine();
            Console.Write("Qual o medicamento utilizado pelo paciente? ");
            Medicamento medicamento = new Medicamento();
            medicamento.NomeMedicamento = Console.ReadLine().ToUpper();
            Console.Write("Qual a quantidade de medicamento? ");
            int quantidade = Convert.ToInt32(Console.ReadLine().ToUpper());

            Requisicao requisicao = new Requisicao(paciente, medicamento, quantidade);

            repositorioRequisicao.CadastrarRequisicao(requisicao);

            Console.WriteLine();
            Console.WriteLine("Tecle 'enter' para retornar ao menu principal!");
            Console.ReadLine();
        }
    }
}
