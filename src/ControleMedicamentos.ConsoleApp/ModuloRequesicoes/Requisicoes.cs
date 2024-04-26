namespace ControleMedicamentos.ConsoleApp.ModuloRequesicoes
{
    public class Requisicoes
    {
        public string medicamentoRequerido { get; set; }
        public string nomeMedico { get; set; }
        public string[] ListaRequisicoes = new string[100];
        public string pacienteDaRequesicao { get; set; }
    }
}
