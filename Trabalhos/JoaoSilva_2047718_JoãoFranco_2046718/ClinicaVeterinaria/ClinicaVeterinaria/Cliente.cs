using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using ClinicaVeterinaria.Animal;

namespace ClinicaVeterinaria.Client
{
    public class Cliente
    {
        public string Nome_Cliente;
        public int Contacto_Cliente;
        public string Endereco_Cliente;
        public int frequencia = 0;
        public int Escolha_servico;
        public int Escolha_medico;
        public List<AnimalEstimacao> animais = new List<AnimalEstimacao>();

    
        public void Registo_Cliente()
        {
            Console.WriteLine("Dados do cliente: \n");
            Console.WriteLine(" Nome: " + Nome_Cliente + "\n Contacto: " + Contacto_Cliente + "\n Endereço: " + Endereco_Cliente + "\n");


        }
    }
}
