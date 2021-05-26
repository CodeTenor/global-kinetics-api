using global_kinetics_domain;
using System.Collections.Generic;

namespace global_kinetic_persistence
{
    public class CoinRepository : IRepository<Coin>
    {
        private List<Coin> _coins;

        public CoinRepository(List<Coin> coins)
        {
            _coins = new List<Coin>();
        }

        public void Add(Coin entity)
        {
            _coins.Add(entity);
        }

        public void DeleteAll()
        {
            _coins = new List<Coin>();
        }

        public IList<Coin> GetAll()
        {
            return _coins;
        }
    }
}
