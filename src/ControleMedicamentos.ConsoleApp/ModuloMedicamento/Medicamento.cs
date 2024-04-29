using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ConsoleApp.ModuloMedicamento
{
    public class Medicamento
    {
        public string NomeMedicamento { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public int Contador { get; set; } = 0;

        public Medicamento(string nomeMedicamento, string descricao, int quantidade)
        {
            NomeMedicamento = nomeMedicamento;
            Descricao = descricao;
            Quantidade = quantidade;
        }

        public Medicamento()
        {

        }

        public override bool Equals(object? obj)
        {
            Medicamento medicamento = obj as Medicamento;
            return medicamento.NomeMedicamento.Equals(NomeMedicamento);
        }

        public void RegistrarRetirada(int quantidade)
        {
            Contador += quantidade;
        }
    }
}
