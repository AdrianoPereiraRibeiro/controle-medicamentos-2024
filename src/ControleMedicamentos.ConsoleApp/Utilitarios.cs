using ControleMedicamentos.ConsoleApp.ModuloMedicamentos;
using ControleMedicamentos.ConsoleApp.ModuloPacientes;
using ControleMedicamentos.ConsoleApp.ModuloRequesicoes;

namespace ControleMedicamentos.ConsoleApp
{
    public class Utilitarios
    {
        public void ExibeOpcoes()
        {
            Console.WriteLine("Gestão de Medicamentos-2024 \n " +
                                "----------------------------------------------");
            Console.WriteLine("Digite a opção desejada : \n1-Cadastrar Medicamento\n2-Entradas e Saídas Medicamentos\n3-Visualizar Medicamentos\n4-Cadastrar Paciente\n5-Visualizar Pacientes\n6-Cadastrar Requisições\n7-Visualizar Requesições\n8-Sair");
        }
        public void LimpaTela()
        {
            Console.ReadLine();
            Console.Clear();
        }

        public void SwitchPrincipal(ref int contadorMedicamentos, ref int pacienteContador, ref int contadorRequisicao, TelaMedicamentos medicamentos, TelaPaciente paciente, TelaRequisicoes requisicoes, ref string[] ListaRequisicoes, ref string[] Estoque, ref string[] Pacientes, int Opcao)
        {
            switch (Opcao)
            {
                case 1:
                    Estoque = medicamentos.CadastrarMedicamento(contadorMedicamentos, Estoque);
                    contadorMedicamentos += 2;
                    break;
                case 2:
                    Estoque = medicamentos.EntradaESaidaMedicamentos(Estoque, contadorMedicamentos);
                    break;
                case 3:
                    medicamentos.MostrarMedicamentos(Estoque, contadorMedicamentos);
                    break;
                case 4:
                    Pacientes = paciente.RegistrarPaciente(pacienteContador, Pacientes);
                    pacienteContador++;
                    break;
                case 5:
                    paciente.VisualizarPaciente(Pacientes, pacienteContador);
                    break;
                case 6:
                    ListaRequisicoes = requisicoes.CadastrarRequisicao(ListaRequisicoes, contadorRequisicao, Estoque, contadorMedicamentos,pacienteContador,Pacientes);
                    contadorRequisicao += 3;
                    break;
                case 7:
                    requisicoes.VisualizarRequisicoes(ListaRequisicoes, contadorRequisicao, Estoque,Pacientes);
                    break;
                case 8:
                    break;
                default:
                    Console.WriteLine("Opção Indisponível!!!");
                    break;
            }
        }

    }
}
