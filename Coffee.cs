namespace Coffee
{
    public abstract class Coffee
    {
        public virtual int Price()
        {
            return 20;
        }

        public abstract string CoffeName();

        public abstract string Strength();

        public override string ToString()
        {
            return $"{CoffeName()} koster:  {Price()} kr. - styrke: {Strength()}. ";
        }
    }
}