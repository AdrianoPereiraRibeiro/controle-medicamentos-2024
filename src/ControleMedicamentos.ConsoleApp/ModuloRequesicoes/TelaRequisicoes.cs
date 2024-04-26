using ControleMedicamentos.ConsoleApp.ModuloMedicamentos;

namespace ControleMedicamentos.ConsoleApp.ModuloRequesicoes
{
    public class TelaRequisicoes
    {
        public string[] CadastrarRequisicao(string[] listaDeRequisicao, int contador, string[] Medicamentos, int ContadorMedicamentos)
        {
            Requisicoes requisicoes = new Requisicoes();
            requisicoes.ListaRequisicoes = listaDeRequisicao;
            TelaMedicamentos medicamentos = new TelaMedicamentos();
            medicamentos.MostrarMedicamentos(Medicamentos, ContadorMedicamentos);
            Console.WriteLine("Digite o número do medicamento Requerido:");
            requisicoes.medicamentoRequerido = Console.ReadLine();
            Console.WriteLine("Digite o nome do Médico Resposável:");
            requisicoes.nomeMedico = Console.ReadLine();
            requisicoes.ListaRequisicoes[contador] = "Nome do médico: " + requisicoes.nomeMedico + "\nNumero do Medicamento Requerido: ";
            requisicoes.ListaRequisicoes[contador + 1] = requisicoes.medicamentoRequerido;
            Console.WriteLine("Requisição Cadastrada!");
            return requisicoes.ListaRequisicoes;

        }
        public void VisualizarRequisicoes(string[] Requesicoes, int contador, string[] medicamentosLista)
        {
            Medicamentos medicamentos = new Medicamentos();
            Requisicoes requisicoes = new Requisicoes();
            medicamentos.MedicamentosCadastrados = medicamentosLista;
            requisicoes.ListaRequisicoes = Requesicoes;

            for (int i = 0; i < contador; i += 2)
            {
                Console.Write(requisicoes.ListaRequisicoes[i]);
                int MedicamentoNumero = Convert.ToInt32(requisicoes.ListaRequisicoes[i + 1]);
                Console.Write(medicamentos.MedicamentosCadastrados[MedicamentoNumero]);
                Console.WriteLine(medicamentos.MedicamentosCadastrados[MedicamentoNumero + 1]);
                Console.WriteLine("-------------------------------------------------------------------------------");
            }

        }
    }
}
