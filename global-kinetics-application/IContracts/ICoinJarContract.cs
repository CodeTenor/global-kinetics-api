using global_kinetics_domain;

namespace global_kinetics_application.IContracts
{
    public interface ICoinJarContract
    {
        void AddCoin(ICoin coin);
        decimal GetTotalAmount();
        void Reset();
    }
}
