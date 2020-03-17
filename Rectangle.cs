namespace ConsoleApp
{
    internal class Rectangle : Forme
    {
        public int Largeur { get; set; }
        public int Longueur { get; set; }

        public override double aire()
        {
            return Longueur * Largeur;
        }

        public override double perimetre()
        {
            return (Longueur + Largeur) * 2;
        }

        public override string ToString()
        {
            return "Rectangle de longueur " + Longueur + " et de largeur "+ Largeur + "  Aire = " + aire() + " Perimetre = " + perimetre();
        }
    }
}