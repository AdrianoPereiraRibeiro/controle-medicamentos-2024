namespace ControleMedicamentos.ConsoleApp.ModuloMedicamentos
{
    public class TelaMedicamentos
    {
        
        public string[] CadastrarMedicamento(int contadorMedicamentos, string[] estoque)
        {
            RepositorioMedicamentos repositorioMedicamentos = new RepositorioMedicamentos();
            Medicamentos medicamentos = new Medicamentos();
            medicamentos.MedicamentosCadastrados = estoque;
            Console.WriteLine("Digite o nome do medicamento:");
            medicamentos.nome = Console.ReadLine();
            Console.WriteLine("Digite a descrição do medicamento:");
            medicamentos.Descricao = Console.ReadLine();
            Console.WriteLine("Digite a quantidade Inicial dos medicamentos");
            medicamentos.Quantidade = Console.ReadLine();
            Console.WriteLine("Digite o nome do Fornecedor:");
            medicamentos.Fornecedor = Console.ReadLine();
            repositorioMedicamentos.CadastrarMedicamentos(contadorMedicamentos, medicamentos);
            Console.WriteLine("Medicamento cadastrado com Sucesso!");

            return medicamentos.MedicamentosCadastrados;
        }

      

        public void MostrarMedicamentos(string[] estoque, int contadorMedicamentos)
        {
            Medicamentos medicamentos = new Medicamentos();
            medicamentos.MedicamentosCadastrados = estoque;
            for (int i = 0; i < contadorMedicamentos; i += 2)
            {
                Console.Write(medicamentos.MedicamentosCadastrados[i]);
                Console.WriteLine(medicamentos.MedicamentosCadastrados[i + 1]);
                Console.WriteLine("-------------------------------------------------------------------------------");
            }

        }
        public string[] EntradaESaidaMedicamentos(string[] estoque, int contadorMedicamentos)
        {
            int quantidadeDaTransacao;
            Medicamentos medicamentos = new Medicamentos();
            medicamentos.MedicamentosCadastrados = estoque;

            for (int i = 0; i < contadorMedicamentos; i += 2)
            {
                Console.Write(medicamentos.MedicamentosCadastrados[i]);
                Console.WriteLine(medicamentos.MedicamentosCadastrados[i + 1]);
                Console.WriteLine("-------------------------------------------------------------------------------");
            }
            Console.WriteLine("Escolha o Medicamento digitando seu número:");
            int numeroMedicamento = Convert.ToInt32(Console.ReadLine());
            int numeromedicamento = numeroMedicamento * 2;
            Console.Clear();
            Console.Write(medicamentos.MedicamentosCadastrados[numeromedicamento]);
            Console.WriteLine(medicamentos.MedicamentosCadastrados[numeromedicamento + 1]);
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("Digite o estilo de Transação\n1-Entrada\n2-Saída");
            int transacao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a Quantidade da Transação:");
            quantidadeDaTransacao = Convert.ToInt32(Console.ReadLine());
            string quantidadeDeEstoque = medicamentos.MedicamentosCadastrados[numeromedicamento + 1];
            int QuantidadeDeEstoque = Convert.ToInt32(quantidadeDeEstoque);

            if (transacao == 1)
            {
                medicamentos.MedicamentosCadastrados[numeromedicamento + 1] = Convert.ToString(QuantidadeDeEstoque + quantidadeDaTransacao);
                Console.WriteLine("Tansação Realizada!");
            }
            else if (transacao == 2)
            {
                if (QuantidadeDeEstoque < quantidadeDaTransacao) { Console.WriteLine("Impossível Realizar essa operação!"); }
                else { medicamentos.MedicamentosCadastrados[numeromedicamento + 1] = Convert.ToString(QuantidadeDeEstoque - quantidadeDaTransacao); Console.WriteLine("Transação Realizada!"); }
            }
            else if (transacao != 1 || transacao != 2) { Console.WriteLine("Transação Indisponivel!"); }


            return medicamentos.MedicamentosCadastrados;
        }


    }
    public class RepositorioMedicamentos
    {
        public  void CadastrarMedicamentos(int contadorMedicamentos, Medicamentos medicamentos)
        {
            medicamentos.MedicamentosCadastrados[contadorMedicamentos] = "Medicamento Número: " + contadorMedicamentos / 2 + "\nNome: " + medicamentos.nome + "\nDescrição: " + medicamentos.Descricao + "\nFornecedor: " + medicamentos.Fornecedor + "\nQuantidade: ";
            medicamentos.MedicamentosCadastrados[contadorMedicamentos + 1] = medicamentos.Quantidade; //Contador/2 pois estou salvando a nome e descrição separado da quantidade.
        }



    }
}
