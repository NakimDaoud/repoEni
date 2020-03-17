namespace ConsoleApp
{
    internal class Triangle : Forme
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public override double aire()
        {
            return 0;
        }

        public override double perimetre()
        {
            return A+B+C;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

}