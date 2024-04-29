using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ConsoleApp.ModuloPaciente
{
    public class Paciente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }

        public Paciente(string nome, string cpf)
        {
            Nome = nome;
            CPF = cpf;
        }
        public Paciente()
        {

        }
        public override bool Equals(object? obj)
        {
            Paciente paciente = obj as Paciente;
            return paciente.CPF.Equals(CPF);
        }
    }
}
