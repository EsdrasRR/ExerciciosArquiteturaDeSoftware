using System;
using System.Collections.Generic;
using System.Text;

namespace Padrao_Composite_e_Decoration
{
    public class Automovel :IAutomovel
    {
        private static int Numero = 0;
        public string Placa { get; set; } = "AAA" + Numero++;
        public bool FarolAceso { get; set; }
        public int Velocidade { get; set; }
        public void Acelerar()
        {
            Velocidade += 10;
            Console.WriteLine("Carro Acelerando, Velocidade " + this.Velocidade.ToString() + " Placa: " + this.Placa);
        }
        public void AcenderFarol()
        {
            if (!FarolAceso)
            {
                FarolAceso = true;
                Console.WriteLine("Carro Acendendo Farol ! Placa: " + this.Placa);
            }
        }
        public void DesligarFarol()
        {
            if (FarolAceso)
            {
                FarolAceso = false;
                Console.WriteLine("Carro Desligando Farol ! Placa: " + this.Placa);
            }
        }
        public void Frear()
        {
            Velocidade -= 10;
            Console.WriteLine("Carro Freando, Velocidade" + this.Velocidade.ToString() + " Placa: " + this.Placa);
        }
    }
}
