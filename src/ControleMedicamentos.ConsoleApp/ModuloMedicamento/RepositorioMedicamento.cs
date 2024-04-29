using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ConsoleApp.ModuloMedicamento
{
    public class RepositorioMedicamento
    {
        public List<Medicamento> estoqueMedicamentos = new List<Medicamento>();

        public void CadastrarMedicamento(Medicamento medicamento)
        {
            Medicamento medicamentoBuscado = BuscarMedicamento(medicamento.NomeMedicamento);
            if (medicamentoBuscado == default(Medicamento))
            {
                estoqueMedicamentos.Add(medicamento);
            }
            else
            {
                AtualizarQuantidade(medicamento.NomeMedicamento, medicamento.Quantidade);
            }

            Console.WriteLine();
            Console.WriteLine("Cadastro realizado com sucesso!");
        }

        public Medicamento BuscarMedicamento(string nomeMedicamento)
        {
            Medicamento medicamentoBuscado = new Medicamento();
            medicamentoBuscado.NomeMedicamento = nomeMedicamento;
            int i = estoqueMedicamentos.IndexOf(medicamentoBuscado);
            if (i > -1)
            {
                return estoqueMedicamentos[i];
            }
            return default(Medicamento);
        }

        public void VerificarDisponibilidade(Medicamento medicamento)
        {
            if (estoqueMedicamentos.Contains(medicamento))
            {
                medicamento = BuscarMedicamento(medicamento.NomeMedicamento);
                Console.WriteLine();
                Console.WriteLine(
                "{0, -15} | {1, -20}",
                    "Medicamento", "Quantidade"
            );
                Console.WriteLine(
                "{0, -15} | {1, -20}",
                    medicamento.NomeMedicamento, medicamento.Quantidade
            );
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"O {medicamento.NomeMedicamento} não está disponível");
            }
        }

        public void AtualizarQuantidade(string buscaMedicamento, int quantidadeParaAlterar)
        {
            Medicamento medicamentoBuscado = BuscarMedicamento(buscaMedicamento);
            medicamentoBuscado.Quantidade += quantidadeParaAlterar;

            Console.WriteLine();
            Console.WriteLine(
            "{0, -15} | {1, -20}",
                "Medicamento", "Quantidade"
        );
            Console.WriteLine(
            "{0, -15} | {1, -20}",
                medicamentoBuscado.NomeMedicamento, medicamentoBuscado.Quantidade
        );

            Console.WriteLine();
            Console.WriteLine("Atualização realizada com sucesso!");
        }

        public void VisualizarBaixaQuantidade()
        {
            Console.WriteLine("Os seguintes medicamentos estão com as suas quantidades baixas no estoque:");
            Console.WriteLine();

            Console.WriteLine(
            "{0, -15} | {1, -20}",
                "Medicamento", "Quantidade"
        );
            foreach (var medicamento in estoqueMedicamentos)
            {
                if (medicamento.Quantidade < 5)
                {
                    Console.WriteLine(
                    "{0, -15} | {1, -20}",
                        medicamento.NomeMedicamento, medicamento.Quantidade
                );
                }
            }
        }

        public void RegistrarRetirada(string nomeMedicamento, int quantidade)
        {
            //achar medicamento pelo nome
            Medicamento medicamento = BuscarMedicamento(nomeMedicamento);
            //atualizar o contador deste medicamento
            medicamento.RegistrarRetirada(quantidade);
        }

        public void VerificarMedicamentosMaisRetirados()
        {
            List<Medicamento> medicamentos = new List<Medicamento>(estoqueMedicamentos);
            // pegar lista de medicamentos
            medicamentos.Sort((x, y) => x.Contador - y.Contador);
            // ordenar a lista com base no contador

            Console.WriteLine(
            "{0, -15} | {1, -20}",
                "Medicamento", "Quantidade Retirada"
            );

            foreach (var medicamento in medicamentos)
            {
                Console.WriteLine(
                    "{0, -15} | {1, -20}",
                        medicamento.NomeMedicamento, medicamento.Contador
                );
            }
        }

        public void MedicamentosEmFalta()
        {
            Console.WriteLine("Os seguintes medicamentos estão em falta no estoque:");
            Console.WriteLine();

            Console.WriteLine(
                    "{0, -15}",
                        "Medicamento"
                );

            foreach (var medicamento in estoqueMedicamentos)
            {
                if (medicamento.Quantidade == 0)
                {
                    Console.WriteLine(
                    "{0, -15}",
                        "Medicamento"
                );
                    Console.WriteLine(
                    "{0, -15}",
                        medicamento.NomeMedicamento
                );
                }
            }
        }
    }
}
