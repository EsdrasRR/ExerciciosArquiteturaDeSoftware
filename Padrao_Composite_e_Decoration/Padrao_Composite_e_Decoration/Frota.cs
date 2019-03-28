using System;
using System.Collections.Generic;
using System.Text;

namespace Padrao_Composite_e_Decoration
{
    public class Frota :IAutomovel
    {
        public List<IAutomovel> Automoveis { get; set; } =
        new List<IAutomovel>();
        public void Acelerar()
        {
            foreach (var carro in this.Automoveis)
            {
                carro.Acelerar();
            }
        }
        public void AcenderFarol()
        {
            foreach (var carro in this.Automoveis)
            {
                carro.AcenderFarol();
            }
        }
        public void DesligarFarol()
        {
            foreach (var carro in this.Automoveis)
            {
                carro.DesligarFarol();
            }
        }
        public void Frear()
        {
            foreach (var carro in this.Automoveis)
            {
                carro.Frear();
            }
        }
    }
}
