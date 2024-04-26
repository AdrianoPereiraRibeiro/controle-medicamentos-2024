namespace ControleMedicamentos.ConsoleApp.ModuloRequesicoes
{
    public class RepositorioRequisicoes
    {
        public void CadastrarRequsicao(int contador, Requisicoes requisicoes)
        {
            requisicoes.ListaRequisicoes[contador] = "Nome do médico: " + requisicoes.nomeMedico + "\nNumero do Medicamento Requerido: ";
            requisicoes.ListaRequisicoes[contador + 1] = requisicoes.medicamentoRequerido;
            requisicoes.ListaRequisicoes[contador +2]= requisicoes.pacienteDaRequesicao;
        }
    }
}
