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
            while (Opcao != 9)
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
    public class Medicamentos
    {
        public string[] MedicamentosCadastrados = new string[100];
        public string nome {  get; set; }
        public string Quantidade { get; set; }     
        public string Descricao { get; set; }
        public string Fornecedor { get; set; }
        
    }
    public class TelaMedicamentos {
    public string[] CadastrarMedicamento(int contadorMedicamentos, string[] estoque)
        {
            Medicamentos medicamentos = new Medicamentos();
            medicamentos.MedicamentosCadastrados = estoque;
            Console.WriteLine("Digite o nome do medicamento:");
            medicamentos.nome = Console.ReadLine();
            Console.WriteLine("Digite a descrição do medicamento:");
            medicamentos.Descricao = Console.ReadLine();
            Console.WriteLine("Digite a quantidade Inicial dos medicamentos");
            medicamentos.Quantidade = Console.ReadLine();
            Console.WriteLine("Digite o nome do Fornecedor:");
            medicamentos.Fornecedor=Console.ReadLine();
            medicamentos.MedicamentosCadastrados[contadorMedicamentos] = "Medicamento Número: "+contadorMedicamentos/2+"\nNome: "+medicamentos.nome+"\nDescrição: "+medicamentos.Descricao+"\nFornecedor: "+medicamentos.Fornecedor+"\nQuantidade: ";
            medicamentos.MedicamentosCadastrados[contadorMedicamentos+1] = medicamentos.Quantidade; //Contador/2 pois estou salvando a nome e descrição separado da quantidade.
            Console.WriteLine("Medicamento cadastrado com Sucesso!");
            
            return medicamentos.MedicamentosCadastrados; 
        }
        public void MostrarMedicamentos(string[] estoque,int contadorMedicamentos)
        {
            Medicamentos medicamentos = new Medicamentos();
            medicamentos.MedicamentosCadastrados = estoque;
            for (int i = 0; i < contadorMedicamentos; i+=2) {
                Console.Write(medicamentos.MedicamentosCadastrados[i]);
                Console.WriteLine(medicamentos.MedicamentosCadastrados[i+1]);
                Console.WriteLine("-------------------------------------------------------------------------------");                             
            }
            
        }
        public string[] EntradaESaidaMedicamentos(string[] estoque,int contadorMedicamentos)
        {
            int quantidadeDaTransacao;
            Medicamentos medicamentos = new Medicamentos(); 
            medicamentos.MedicamentosCadastrados=estoque;
           
            for (int i = 0; i < contadorMedicamentos; i += 2)
            {
                Console.Write(medicamentos.MedicamentosCadastrados[i]);
                Console.WriteLine(medicamentos.MedicamentosCadastrados[i + 1]);
                Console.WriteLine("-------------------------------------------------------------------------------");
            }
            Console.WriteLine("Escolha o Medicamento digitando seu número:");
            int numeroMedicamento = Convert.ToInt32(Console.ReadLine());    
            int numeromedicamento = numeroMedicamento*2;
            Console.Clear();
                Console.Write(medicamentos.MedicamentosCadastrados[numeromedicamento]);
                Console.WriteLine(medicamentos.MedicamentosCadastrados[numeromedicamento+ 1]);
                Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("Digite o estilo de Transação\n1-Entrada\n2-Saída");
            int transacao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a Quantidade da Transação:");
             quantidadeDaTransacao = Convert.ToInt32(Console.ReadLine());
            string quantidadeDeEstoque = medicamentos.MedicamentosCadastrados[numeromedicamento + 1];
            int QuantidadeDeEstoque = Convert.ToInt32(quantidadeDeEstoque);

            if (transacao == 1) {
                medicamentos.MedicamentosCadastrados[numeromedicamento + 1] = Convert.ToString(QuantidadeDeEstoque + quantidadeDaTransacao);
                Console.WriteLine("Tansação Realizada!");
            }
            else if (transacao == 2)
            {
                if (QuantidadeDeEstoque < quantidadeDaTransacao) { Console.WriteLine("Impossível Realizar essa operação!");  }
                else { medicamentos.MedicamentosCadastrados[numeromedicamento + 1] = Convert.ToString(QuantidadeDeEstoque - quantidadeDaTransacao); Console.WriteLine("Transação Realizada!"); }
            }
            else if (transacao != 1|| transacao !=2) { Console.WriteLine("Transação Indisponivel!");  }
            
            
            return medicamentos.MedicamentosCadastrados;
        }
    
    
    }
    public class Paciente
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Endereco { get;set; }
        public string[] Pacientes = new string[100];
    }
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
            paciente.Pacientes[pacienteContador]= "Paciente Número: " + contadorPaciente + "\nNome: " + paciente.Nome + "\nCPF: " + paciente.CPF + "\nEndereço: " + paciente.Endereco ;
            Console.WriteLine("Paciente Cadastrado!");
           
            return paciente.Pacientes;
        }
        public void VisualizarPaciente(string[] Pacientes,int contador)
        {
            string[] pacientes = Pacientes;
            int PacientesContador = contador;
            for (int i = 0; i < PacientesContador; i++) {
                Console.WriteLine(pacientes[i]);
                Console.WriteLine("-------------------------------------------------------------------------------");
            }
           
        }

    }
    public class Requisicoes 
    {   public string medicamentoRequerido { get; set;}
        public string nomeMedico { get; set;}
        public string[] ListaRequisicoes = new string[100];
    }
    public class TelaRequisicoes {
        public string[] CadastrarRequisicao(string[] listaDeRequisicao, int contador, string[] Medicamentos,int ContadorMedicamentos)
        {
            Requisicoes requisicoes = new Requisicoes();  
            requisicoes.ListaRequisicoes=listaDeRequisicao;
            TelaMedicamentos medicamentos = new TelaMedicamentos();
            medicamentos.MostrarMedicamentos(Medicamentos,ContadorMedicamentos);
            Console.WriteLine("Digite o número do medicamento Requerido:");
             requisicoes.medicamentoRequerido = Console.ReadLine();
            Console.WriteLine("Digite o nome do Médico Resposável:");
            requisicoes.nomeMedico = Console.ReadLine();
            requisicoes.ListaRequisicoes[contador] = "Nome do médico: "+requisicoes.nomeMedico+"\nNumero do Medicamento Requerido: ";
            requisicoes.ListaRequisicoes[contador + 1] = requisicoes.medicamentoRequerido;
            Console.WriteLine("Requisição Cadastrada!");           
            return requisicoes.ListaRequisicoes;

        }
        public void VisualizarRequisicoes(string[] Requesicoes,int contador, string[] medicamentosLista)
        {
            Medicamentos medicamentos = new Medicamentos();
            Requisicoes requisicoes=new Requisicoes();  
            medicamentos.MedicamentosCadastrados = medicamentosLista;
            requisicoes.ListaRequisicoes=Requesicoes;
            
            for (int i = 0; i < contador; i += 2)
            {
                Console.Write(requisicoes.ListaRequisicoes[i]);
                int MedicamentoNumero = Convert.ToInt32(requisicoes.ListaRequisicoes[i + 1]);
                Console.Write(medicamentos.MedicamentosCadastrados[MedicamentoNumero]);
                Console.WriteLine(medicamentos.MedicamentosCadastrados[MedicamentoNumero+1]);
                Console.WriteLine("-------------------------------------------------------------------------------");
            }

        }
    }
}
