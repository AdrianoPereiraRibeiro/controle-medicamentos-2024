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
            string[] ListaRequisicoes = new string[100];
            string[] Estoque = new string[100];
            string[] Pacientes = new string[100];
            int Opcao = 0;
            Console.WriteLine("Aperte ENTER para Inciar:");
            while (Opcao != 9)//Implementar validações, refatorar e Refazer saida.
            {
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Gestão de Medicamentos-2024 \n " +
                    "----------------------------------------------");
                Console.WriteLine("Digite a opção desejada : \n1-Cadastrar Medicamento\n2-Entradas e Saídas Medicamentos\n3-Visualizar Medicamentos\n4-Cadastrar Paciente\n5-Visualizar Pacientes\n6-Cadastrar Requisições\n7-Visualizar Requesições");
                Opcao = Convert.ToInt32(Console.ReadLine());
                switch (Opcao) {
         case 1:            
                Estoque = medicamentos.CadastrarMedicamento(contadorMedicamentos, Estoque);
                contadorMedicamentos += 2; 
                break;
         case 2:
                Estoque = medicamentos.EntradaESaidaMedicamentos(Estoque,contadorMedicamentos);
                break;
         case 3: 
                medicamentos.MostrarMedicamentos(Estoque,contadorMedicamentos);     
                break;
         case 4: 
                Pacientes = paciente.RegistrarPaciente(pacienteContador,Pacientes);
                pacienteContador++;
                break;
         case 5:
                paciente.VisualizarPaciente(Pacientes,pacienteContador);
                break;
         case 6:
                ListaRequisicoes = requisicoes.CadastrarRequisicao(ListaRequisicoes,contadorRequisicao,Estoque,contadorMedicamentos);
                contadorRequisicao+=2;
                break;
         case 7: 
                requisicoes.VisualizarRequisicoes(ListaRequisicoes, contadorRequisicao,Estoque);
                break;
                }
            
            }
        }
    }
}
