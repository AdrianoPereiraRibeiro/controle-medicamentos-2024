namespace ControleMedicamentos.ConsoleApp.ModuloPacientes
{
    public class TelaPaciente
    {
        public string[] RegistrarPaciente(int pacienteContador, string[] Pacientes)
        {
            Paciente paciente = new Paciente();
            int contadorPaciente = pacienteContador;
            paciente.Pacientes = Pacientes;
            Console.WriteLine("Digite o nome do paciente:");
            paciente.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do paciente:");
            paciente.CPF = Console.ReadLine();
            Console.WriteLine("Digite o Endereço do paciente:");
            paciente.Endereco = Console.ReadLine();
            paciente.Pacientes[pacienteContador] = "Paciente Número: " + contadorPaciente + "\nNome: " + paciente.Nome + "\nCPF: " + paciente.CPF + "\nEndereço: " + paciente.Endereco;
            Console.WriteLine("Paciente Cadastrado!");

            return paciente.Pacientes;
        }
        public void VisualizarPaciente(string[] Pacientes, int contador)
        {
            string[] pacientes = Pacientes;
            int PacientesContador = contador;
            for (int i = 0; i < PacientesContador; i++)
            {
                Console.WriteLine(pacientes[i]);
                Console.WriteLine("-------------------------------------------------------------------------------");
            }

        }

    }
}
