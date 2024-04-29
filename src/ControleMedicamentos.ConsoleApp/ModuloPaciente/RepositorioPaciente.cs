using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ConsoleApp.ModuloPaciente
{
    public class RepositorioPaciente
    {
        public List<Paciente> pacientes = new List<Paciente>();

        public void CadastrarPaciente(Paciente paciente)
        {
            Paciente pacienteBuscado = BuscarPaciente(paciente.CPF);
            if (pacienteBuscado == default(Paciente))
            {
                pacientes.Add(paciente);
            }
        }
        public Paciente BuscarPaciente(string cpf)
        {
            Paciente p = new Paciente();
            p.CPF = cpf;
            int i = pacientes.IndexOf(p);
            if (i > -1)
            {
                return pacientes[i];
            }
            return default(Paciente);
        }
    }
}
