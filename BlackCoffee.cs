namespace Coffee
{
    public class BlackCoffee : Coffee
    {
        public override int Price()
        {
            return 20;
        }

        public override string Strength()
        {
            return "Strong";
        }

        public override string CoffeName()
        {
            return "Sort Kaffe";
        }
    }
}