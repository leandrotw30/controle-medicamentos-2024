using ControleMedicamentos.ConsoleApp.ModuloMedicamento;
using ControleMedicamentos.ConsoleApp.ModuloPaciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ConsoleApp.ModuloRequisicao
{
    public class Requisicao
    {
        public Paciente Paciente { get; set; }
        public Medicamento Medicamento { get; set; }
        public int Quantidade { get; set; }

        public Requisicao(Paciente paciente, Medicamento medicamento, int quantidade)
        {
            Paciente = paciente;
            Medicamento = medicamento;
            Quantidade = quantidade;
        }
    }
}
