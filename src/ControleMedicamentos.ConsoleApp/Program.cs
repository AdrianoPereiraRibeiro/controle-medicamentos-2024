namespace ControleMedicamentos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadorMedicamentos = 0;        
            int pacienteContador = 0;
            TelaMedicamentos medicamentos = new TelaMedicamentos();
            TelaPaciente paciente = new TelaPaciente();
            string[] Estoque = new string[100];
            string[] Pacientes = new string[100];
            int Opcao = 0;
            while (Opcao != 9)
            {
                Console.WriteLine("Gestão de Medicamentos-2024 \n " +
                    "----------------------------------------------");
                Console.WriteLine("Digite a opção desejada : \n1-Cadastrar Medicamento\n2-Entradas e Saídas Medicamentos\n3-Visualizar Equipamentos\n4-Cadastrar Paciente\n5-Visualizar Pacientes");
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
            Console.ReadLine();
            Console.Clear();
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
            Console.ReadLine();
            Console.Clear();
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
                if (QuantidadeDeEstoque < quantidadeDaTransacao) { Console.WriteLine("Impossível Realizar essa operação!"); Console.ReadLine(); }
                else { medicamentos.MedicamentosCadastrados[numeromedicamento + 1] = Convert.ToString(QuantidadeDeEstoque - quantidadeDaTransacao); Console.WriteLine("Tansação Realizada!"); }
            }
            else if (transacao != 1|| transacao !=2) { Console.WriteLine("Transação Indisponivel!");  }
            
            Console.ReadLine();
            Console.Clear();
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
            paciente.Pacientes[pacienteContador]= "Paciente Número: " + contadorPaciente / 2 + "\nNome: " + paciente.Nome + "\nCPF: " + paciente.CPF + "\nEndereço: " + paciente.Endereco ;
            Console.WriteLine("Paciente Cadastrado!");
            Console.ReadLine();
            Console.Clear();
            return paciente.Pacientes;
        }
        public void VisualizarPaciente(string[] Pacientes,int contador)
        {
            string[] pacientes = Pacientes;
            int PacientesContador = contador;
            for (int i = 0; i < PacientesContador; i++) {
                Console.WriteLine(pacientes[i]);
            }
            Console.ReadLine() ;
            Console.Clear();
        }

    }
    public class Requisicoes 
    {   public string MedicamentoReferenciado { get; set;}
    }
}
