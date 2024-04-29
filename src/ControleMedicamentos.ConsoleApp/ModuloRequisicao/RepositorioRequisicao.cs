using ControleMedicamentos.ConsoleApp.ModuloMedicamento;
using ControleMedicamentos.ConsoleApp.ModuloPaciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ConsoleApp.ModuloRequisicao
{
    public class RepositorioRequisicao
    {
        public RepositorioMedicamento repositorioMedicamento;
        public RepositorioPaciente repositorioPaciente;

        public List<Requisicao> requisicoes = new List<Requisicao>();

        public void CadastrarRequisicao(Requisicao requisicao)
        {
            Paciente pacienteBuscado = repositorioPaciente.BuscarPaciente(requisicao.Paciente.CPF);

            if (pacienteBuscado == default(Paciente))
            {
                Console.WriteLine();
                Console.WriteLine("Paciente não existe. Favor cadastrá-lo!");
                return;
            }
            requisicao.Paciente = pacienteBuscado;

            Medicamento medicamentoBuscado = repositorioMedicamento.BuscarMedicamento(requisicao.Medicamento.NomeMedicamento);
            if (medicamentoBuscado == default(Medicamento))
            {
                Console.WriteLine();
                Console.WriteLine("Medicamento não existe. Favor cadastrá-lo!");
                return;
            }
            requisicao.Medicamento = medicamentoBuscado;

            if (medicamentoBuscado.Quantidade == 0 || medicamentoBuscado.Quantidade < requisicao.Quantidade)
            {
                Console.WriteLine();
                Console.WriteLine("Medicamento indisponível. Favor repor no estoque!");
                return;
            }
            repositorioMedicamento.AtualizarQuantidade(medicamentoBuscado.NomeMedicamento, requisicao.Quantidade * -1);
            repositorioMedicamento.RegistrarRetirada(medicamentoBuscado.NomeMedicamento, requisicao.Quantidade);
            requisicoes.Add(requisicao);

            Console.WriteLine();
            Console.WriteLine("Requisição realizada com sucesso!");
        }
    }
}
