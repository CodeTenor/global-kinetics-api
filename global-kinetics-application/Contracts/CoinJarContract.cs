using global_kinetic_persistence;
using global_kinetics_application.IContracts;
using global_kinetics_domain;

namespace global_kinetics_application.Contracts
{
    public class CoinJarContract : ICoinJarContract
    {
        private readonly IRepository<Coin> _coinRepository;
        public void AddCoin(ICoin coin)
        {
            throw new System.NotImplementedException();
        }

        public decimal GetTotalAmount()
        {
            throw new System.NotImplementedException();
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }
    }
}
