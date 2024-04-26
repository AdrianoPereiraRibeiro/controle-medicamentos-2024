using ControleMedicamentos.ConsoleApp.ModuloMedicamentos;
using ControleMedicamentos.ConsoleApp.ModuloPacientes;

namespace ControleMedicamentos.ConsoleApp.ModuloRequesicoes
{
    public class TelaRequisicoes
    {
        public string[] CadastrarRequisicao(string[] listaDeRequisicao, int contador, string[] Medicamentos, int ContadorMedicamentos, int ContadorPacientes, string[] Pacientes)
        {
            
            RepositorioRequisicoes repositorio = new RepositorioRequisicoes();
            Requisicoes requisicoes = new Requisicoes();
            requisicoes.ListaRequisicoes = listaDeRequisicao;
            TelaMedicamentos medicamentos = new TelaMedicamentos();
            TelaPaciente telaPaciente = new TelaPaciente();
            if (ContadorMedicamentos == 0 || ContadorPacientes == 0) { Console.WriteLine(" Impossivel fazer essa operação! "); return requisicoes.ListaRequisicoes; }
            medicamentos.MostrarMedicamentos(Medicamentos, ContadorMedicamentos);
            Console.WriteLine("Digite o número do medicamento Requerido:");
            requisicoes.medicamentoRequerido = Console.ReadLine();
            Console.WriteLine("Digite o nome do Médico Resposável:");
            requisicoes.nomeMedico = Console.ReadLine();
            Console.Clear();
            telaPaciente.VisualizarPaciente(Pacientes,ContadorPacientes);
            Console.WriteLine("Digite o numero do Paciente responsável pela requisição:");
            requisicoes.pacienteDaRequesicao = Console.ReadLine();
            repositorio.CadastrarRequsicao(contador, requisicoes);
            Console.WriteLine("Requisição Cadastrada!");
            return requisicoes.ListaRequisicoes;

        }

      

        public void VisualizarRequisicoes(string[] Requesicoes, int contador, string[] medicamentosLista, string[] Pacientes)
        {
            Medicamentos medicamentos = new Medicamentos();
            Requisicoes requisicoes = new Requisicoes();
            medicamentos.MedicamentosCadastrados = medicamentosLista;
            requisicoes.ListaRequisicoes = Requesicoes;

            for (int i = 0; i < contador; i += 3)
            {
                Console.Write(requisicoes.ListaRequisicoes[i]);
                int MedicamentoNumero = Convert.ToInt32(requisicoes.ListaRequisicoes[i + 1]);
                int PacienteNumero = Convert.ToInt32(requisicoes.ListaRequisicoes[i+2]);    
                Console.Write(medicamentos.MedicamentosCadastrados[MedicamentoNumero]);
                Console.WriteLine(medicamentos.MedicamentosCadastrados[MedicamentoNumero + 1]);
                Console.WriteLine(Pacientes[PacienteNumero]);
                Console.WriteLine("-------------------------------------------------------------------------------");
            }

        }
    }
}
