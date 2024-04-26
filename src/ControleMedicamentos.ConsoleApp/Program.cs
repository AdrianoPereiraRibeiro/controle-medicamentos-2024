using ControleMedicamentos.ConsoleApp.ModuloMedicamentos;
using ControleMedicamentos.ConsoleApp.ModuloPacientes;
using ControleMedicamentos.ConsoleApp.ModuloRequesicoes;

namespace ControleMedicamentos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadorMedicamentos = 0;        
            int pacienteContador = 0;
            int contadorRequisicao = 0;
            TelaMedicamentos medicamentos = new TelaMedicamentos();
            TelaPaciente paciente = new TelaPaciente();
            TelaRequisicoes requisicoes = new TelaRequisicoes();
            Utilitarios utilitarios = new Utilitarios();    
            string[] ListaRequisicoes = new string[100];
            string[] Estoque = new string[100];
            string[] Pacientes = new string[100];
            int Opcao = 0;
            Console.WriteLine("Aperte ENTER para Inciar:");
            while (Opcao != 8)//Refazer saida.
            {
                utilitarios.LimpaTela();
                utilitarios.ExibeOpcoes();
                Opcao = Convert.ToInt32(Console.ReadLine());
                utilitarios.SwitchPrincipal(ref contadorMedicamentos, ref pacienteContador, ref contadorRequisicao, medicamentos, paciente, requisicoes, ref ListaRequisicoes, ref Estoque, ref Pacientes, Opcao);

            }
        }    
    }
}
