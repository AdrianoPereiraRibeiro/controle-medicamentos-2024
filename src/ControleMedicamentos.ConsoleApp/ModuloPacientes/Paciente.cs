namespace ControleMedicamentos.ConsoleApp.ModuloPacientes
{
    public class Paciente
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string[] Pacientes = new string[100];
    }
}
