using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVeterinaria.Animal
{
    public class AnimalEstimacao
    {
        public string Nome_Animal;
        public int Idade_Animal;
        public string Genero_Animal;
        public string Especie_Animal;
        public int Identificacao_Animal;

        public void Registo_Animal_Estimacao()
        {
            Console.WriteLine("Dados do animal: \n");
            Console.WriteLine(" Nome: " + Nome_Animal + "\n Idade: " + Idade_Animal + "\n Género: " + Genero_Animal + "\n Espécie: " + Especie_Animal + "\n Nº de Identificação: " + Identificacao_Animal + "\n");


        }
    }
}
