namespace global_kinetics_domain
{
    public class Coin : Domain, ICoin
    {
        public decimal Amount { get ; set ; }
        public decimal Volume { get ; set ; }

        public Coin(decimal amount, decimal volume): base()
        {
            Amount = amount;
            Volume = volume;
        }
    }
}
