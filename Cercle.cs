using System;
namespace ConsoleApp
{
    internal class Cercle : Forme
    {
        public int Rayon { get; set; }

        public override double aire()
        {
            
            return Math.PI * (Rayon * Rayon);
        }
         

        public override double perimetre()
        {
            return 2 * ( Rayon * Rayon);
        }

        public override string ToString()
        {
            return "Cercle de rayon " + Rayon + "\n Aire = "+aire()+ "\n Perimetre = " + perimetre();
        }
    }
}