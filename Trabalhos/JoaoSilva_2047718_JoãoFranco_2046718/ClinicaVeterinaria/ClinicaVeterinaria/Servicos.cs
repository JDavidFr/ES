using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaVeterinaria.Services
{
    public class Servicos
    {

        public string servico1;
        public string servico2;
        public string servico3;
        public string servico4;


        public int num;

        Random rand = new Random();
        public string medicamentos;


        public void Registo_Servico()
        {
            servico1 = "Check-up geral";
            servico2 = "Esterilização";
            servico3 = "Cirurgia";
            servico4 = "Tosquia";

            string[] arrayMedicamentos = new string[10];
            arrayMedicamentos = new string[10] { "Tiamina", "Salbutamol", "Amitraz", "Polimixina B", "Metronidazol", "Anticolinergénico", "Lidocaína", "Adrenalina", "Benzodiapezina", "Amoxicilina" };
            switch (num)
            {
                case (1):
                    Console.WriteLine("Escolheu o serviço:" + servico1 + "\n");
                    int preco1 = rand.Next(30, 59);
                    Console.WriteLine("Irá ter um custo de " + preco1 + " euros. \n");
                    int tempo1 = rand.Next(20, 59);
                    Console.WriteLine("Irá demorar cerca de " + tempo1 + " minutos. \n");
                    int medrand1 = rand.Next(0, 9);
                    medicamentos = arrayMedicamentos[medrand1];
                    Console.WriteLine("Medicamentos que necessita comprar: " + medicamentos + "\n");
                    break;
                case (2):
                    Console.WriteLine("Escolheu o serviço:" + servico2 + "\n");
                    int preco2 = rand.Next(15, 34);
                    Console.WriteLine("Irá ter um custo de " + preco2 + " euros. \n");
                    int tempo2 = rand.Next(10, 29);
                    Console.WriteLine("Irá demorar cerca de " + tempo2 + " minutos. \n");
                    int medrand2 = rand.Next(0, 9);
                    medicamentos = arrayMedicamentos[medrand2];
                    Console.WriteLine("Medicamentos: " + medicamentos);
                    break;
                case (3):
                    Console.WriteLine("Escolheu o serviço:" + servico3 + "\n");
                    int preco3 = rand.Next(40, 79);
                    Console.WriteLine("Irá ter um custo de " + preco3 + " euros. \n");
                    int tempo3 = rand.Next(25, 49);
                    Console.WriteLine("Irá demorar cerca de " + tempo3 + " minutos. \n");
                    int medrand3 = rand.Next(0, 9);
                    medicamentos = arrayMedicamentos[medrand3];
                    Console.WriteLine("Medicamentos: " + medicamentos);
                    break;
                case (4):
                    Console.WriteLine("Escolheu o serviço:" + servico4 + "\n");
                    int preco4 = rand.Next(10, 19);
                    Console.WriteLine("Irá ter um custo de " + preco4 + " euros. \n");
                    int tempo4 = rand.Next(20, 39);
                    Console.WriteLine("Irá demorar cerca de " + tempo4 + " minutos. \n");
                    break;
                default:
                    Console.WriteLine("A opção que colocou é inválida escolha outra alternativa.");
                    break;
            }
        }
    }
}
