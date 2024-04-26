namespace ControleMedicamentos.ConsoleApp.ModuloPacientes
{
    public class RepositorioPacientes
    {
        public void CadastrarPaciente(int pacienteContador, Paciente paciente, int contadorPaciente)
        {
            paciente.Pacientes[pacienteContador] = "Paciente Número: " + contadorPaciente + "\nNome: " + paciente.Nome + "\nCPF: " + paciente.CPF + "\nEndereço: " + paciente.Endereco;
        }
    }
}
