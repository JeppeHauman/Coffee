namespace Coffee
{
    public class Cortado : Coffee, IMilk
    {
        public override int Price()
        {
            return 25;
        }

        public override string Strength()
        {
            return "Medium";
        }

        public override string CoffeName()
        {
            return "Cortado";
        }
        public int mlMilk()
        {
            return 40;
        }
        public override string ToString()
        {
            return base.ToString() + $"Mængde mælk: {mlMilk()} ml.";
        }
    }
}