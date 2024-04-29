using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ConsoleApp.ModuloPaciente
{
    public class TelaPaciente
    {
        public RepositorioPaciente repositorioPaciente;

        public void CadastrarPaciente()
        {
            Console.Clear();

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("|        Gerenciamento do Controle de Pacientes              |");
            Console.WriteLine("--------------------------------------------------------------");

            Console.WriteLine();

            Console.Write("Qual o nome do paciente? ");
            string nomePaciente = Console.ReadLine().ToUpper();
            Console.Write("Qual o CPF do paciente? ");
            string cpf = Console.ReadLine();

            Paciente paciente = new Paciente(nomePaciente, cpf);

            repositorioPaciente.CadastrarPaciente(paciente);

            Console.WriteLine();
            Console.WriteLine("Cadastro realizado com sucesso!");
            Console.WriteLine();
            Console.WriteLine("Tecle 'enter' para retornar ao menu principal!");
            Console.ReadLine();
        }
    }
}
