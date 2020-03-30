namespace Coffee
{
    public class Latte : Coffee, IMilk
    {
        public override int Price()
        {
            return 40;
        }

        public override string Strength()
        {
            return "Weak";
        }

        public override string CoffeName()
        {
            return "Latte";
        }
        public int mlMilk()
        {
            return 200;
        }

        public override string ToString()
        {
            return base.ToString() + $"Mængde mælk: {mlMilk()} ml.";
        }
    }
}