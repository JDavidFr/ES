using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaVeterinaria.Animal;
using ClinicaVeterinaria.Client;
using ClinicaVeterinaria.Services;
using ClinicaVeterinaria.Professionals;

namespace ClinicaVeterinaria
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string optn;
            int id;
            Console.WriteLine("Seja bem-vindo á nossa Clínica Veterinária! ");
            Console.WriteLine("Para dar entrada insira entrar.");
            optn = Console.ReadLine();

            while (optn.ToLower() == "entrar") {

                List<Cliente> clientes = new List<Cliente>();
                List<int> contactos = new List<int>();
                
                bool criarCliente = true;
                while (criarCliente) {

                    criarCliente = false;

                    string Contacto_Cliente;
                    Cliente cliente = new Cliente();

                    Console.WriteLine("Insira o seu nome completo: ");
                    cliente.Nome_Cliente = Console.ReadLine();
                    Console.WriteLine("Insira o seu contacto telefónico: ");
                    Contacto_Cliente = Console.ReadLine();
                    cliente.Contacto_Cliente = Convert.ToInt32(Contacto_Cliente);
                    contactos.Add(cliente.Contacto_Cliente);
                    contactos.ForEach(delegate (int Contacto_Cliente)
                    {

                        if (Contacto_Cliente==cliente.Contacto_Cliente)
                        {
                            cliente.frequencia++;
                        }
                    }); 
                    Console.WriteLine("Insira o seu endereço eletrónico: ");
                    cliente.Endereco_Cliente = Console.ReadLine();

                    string Idade_Animal;
                    string Identificacao_Animal;

                    //List<AnimalEstimacao> animais = new List<AnimalEstimacao>();
                    bool criarAnimal = true;
                    while (criarAnimal) {

                        criarAnimal = false;
                        AnimalEstimacao animal = new AnimalEstimacao();

                        Console.WriteLine("Insira o nome do seu animal de estimação: ");
                        animal.Nome_Animal = Console.ReadLine();
                        Console.WriteLine("Insira a idade do seu animal de estimação: ");
                        Idade_Animal = Console.ReadLine();
                        animal.Idade_Animal = Convert.ToInt32(Idade_Animal);
                        Console.WriteLine("Insira o género do seu animal de estimação: ");
                        animal.Genero_Animal = Console.ReadLine();
                        Console.WriteLine("Insira a espécie do seu animal de estimação: ");
                        animal.Especie_Animal = Console.ReadLine();
                        Console.WriteLine("Insira o número de identificação do seu animal de estimação: ");
                        Identificacao_Animal = Console.ReadLine();
                        animal.Identificacao_Animal = Convert.ToInt32(Identificacao_Animal);


                        Console.Clear();
                        cliente.Registo_Cliente();
                        animal.Registo_Animal_Estimacao();
                        
                        string num;
                        Servicos servicos = new Servicos();
                        servicos.Registo_Servico();
                        Console.WriteLine("Qual o serviço que deseja usufruir? \n (Coloque o número correspondente à opção desejada) \n");
                        Console.WriteLine("1:" + servicos.servico1 + "\n");
                        Console.WriteLine("2:" + servicos.servico2 + "\n");
                        Console.WriteLine("3:" + servicos.servico3 + "\n");
                        Console.WriteLine("4:" + servicos.servico4 + "\n");
                        num = Console.ReadLine();
                        servicos.num = Convert.ToInt32(num);
                        cliente.Escolha_servico = servicos.num;

                        Console.Clear();
                        servicos.Registo_Servico();

                        string opt;
                        Profissionais profissional = new Profissionais();
                        profissional.Registo_Profissionais();
                        Console.WriteLine("Escolha qual o horário em que tem disponibilidade: \n");
                        Console.WriteLine("1: " + profissional.disponibilidade1 + "\n");
                        Console.WriteLine("2: " + profissional.disponibilidade2 + "\n");
                        Console.WriteLine("3: " + profissional.disponibilidade3 + "\n");
                        Console.WriteLine("4: " + profissional.disponibilidade4 + "\n");
                        opt = Console.ReadLine();
                        profissional.opt = Convert.ToInt32(opt);
                        cliente.Escolha_medico = profissional.opt;
                        Console.WriteLine("\n");
                        profissional.Registo_Profissionais();

                        clientes.Add(cliente);
                        cliente.animais.Add(animal);
                        

                        Console.WriteLine("Se desejar sair e gerar um relatório insira sair, caso contrário insira continuar.");
                        string opcao = Console.ReadLine();
                        if (opcao.ToLower() == "continuar")
                        {
                            criarCliente = true;
                        }

                        else
                        {

                            for (int i = 0; i < clientes.Count; i++)
                            {

                                Console.WriteLine("Dados do Cliente: \n");
                                Console.WriteLine("Nome completo do cliente: " + clientes[i].Nome_Cliente);
                                Console.WriteLine("Contacto do cliente: " + clientes[i].Contacto_Cliente);
                                Console.WriteLine("Endereço eletrónico do cliente: " + clientes[i].Endereco_Cliente);
                                Console.WriteLine("Frequência: " + clientes[i].frequencia);
                                Console.WriteLine("\n");
                                Console.WriteLine("Dados do Animal de Estimação: ");
                                Console.WriteLine("\n");
                                for (int k = 0; k < cliente.animais.Count; k++)
                                {
                                    Console.WriteLine("Nome do animal de estimação: " + clientes[i].animais[k].Nome_Animal);
                                    Console.WriteLine("Idade do Animal de Estimação: " + clientes[i].animais[k].Idade_Animal);
                                    Console.WriteLine("Género do Animal de Estimação: " + clientes[i].animais[k].Genero_Animal);
                                    Console.WriteLine("Espécie do Animal de Estimação: " + clientes[i].animais[k].Especie_Animal);
                                    Console.WriteLine("Número de Identificação do Animal de Estimação: " + clientes[i].animais[k].Identificacao_Animal);
                                    Console.WriteLine("\n");
                                }

                                //funções auxiliares
                                void escolhaServico(int i)
                                {
                                    if (i == 1)
                                    {
                                        Console.WriteLine("Usufruiu do serviço: Check-up Geral \n");
                                    }
                                    else if (i == 2)
                                    {
                                        Console.WriteLine("Usufruiu do serviço: Esterilização \n");
                                    }
                                    else if (i == 3)
                                    {
                                        Console.WriteLine("Usufruiu do serviço: Cirurgia \n");
                                    }
                                    else if (i == 4)
                                    {
                                        Console.WriteLine("Usufruiu do serviço: Tosquia \n");
                                    }
                                }

                                void escolhaMedico(int i)
                                {
                                    if (i == 1)
                                    {
                                        Console.WriteLine("Foi atendido pelo Dr. João Silva entre as 8h e as 11h \n");
                                    }
                                    else if (i == 2)
                                    {
                                        Console.WriteLine("Foi atendido pelo Dr. David Franco entre as 12h e as 15h \n");
                                    }
                                    else if (i == 3)
                                    {
                                        Console.WriteLine("Foi atendido pelo Dra. Bruna Rodrigues entre as 15h e as 18h \n");
                                    }
                                    else if (i == 4)
                                    {
                                        Console.WriteLine("Foi atendido pelo Dra. Paula Ornelas entre as 18h e as 21h \n");
                                    }
                                }
                                Console.WriteLine("Serviços:");
                                Console.WriteLine("\n");
                                escolhaServico(clientes[i].Escolha_servico);
                                Console.WriteLine("Consulta:");
                                Console.WriteLine("\n");
                                escolhaMedico(clientes[i].Escolha_medico);

                            }

                            Environment.Exit(0);

                        }

                    }




                }

            }

            Console.WriteLine("Seja bem-vindo á nossa Clínica Veterinária! ");
            Console.WriteLine("Para dar entrada insira entrar");
            optn = Console.ReadLine();









        }

    }
}
