using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaVeterinaria.Professionals
{
    public class Profissionais
    {
        public string disponibilidade1;
        public string disponibilidade2;
        public string disponibilidade3;
        public string disponibilidade4;
        public string profissional1;
        public string profissional2;
        public string profissional3;
        public string profissional4;

        public int opt;

        public void Registo_Profissionais()
        {
            profissional1 = "Dr. João Silva";
            profissional2 = "Dr. David Franco";
            profissional3 = "Dra. Bruna Rodrigues";
            profissional4 = "Dra. Paula Ornelas";
            disponibilidade1 = "Das 8h ás 11h";
            disponibilidade2 = "Das 12h ás 15h";
            disponibilidade3 = "Das 15h ás 18h";
            disponibilidade4 = "Das 18h ás 21h";
            switch (opt)
            {
                case (1):
                    Console.WriteLine("Profissional: " + profissional1 + "\nDisponibilidade: " + disponibilidade1 + "\n");
                    break;
                case (2):
                    Console.WriteLine("Profissional: " + profissional2 + "\nDisponibilidade: " + disponibilidade2 + "\n");
                    break;
                case (3):
                    Console.WriteLine("Profissional: " + profissional3 + "\nDisponibilidade: " + disponibilidade3 + "\n");
                    break;
                case (4):
                    Console.WriteLine("Profissional: " + profissional4 + "\n Disponibilidade: " + disponibilidade4 + "\n");
                    break;
            }
        }
    }
}
