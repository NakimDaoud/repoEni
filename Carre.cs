namespace ConsoleApp
{
    internal class Carre : Forme
    {
        public int Longueur { get; set; }

        public override double aire()
        {
            return Longueur * 2;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override double perimetre()
        {
            return Longueur * 4;
        }

        public override string ToString()
        {
            return "Carré de coté " + Longueur + " Aire = " + aire() + " Perimetre = " + perimetre();
        }
    }
}