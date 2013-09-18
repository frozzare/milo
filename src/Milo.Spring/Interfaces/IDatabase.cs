namespace Milo.Spring.Interfaces
{
    public interface IDatabase : ILinq
    {
        dynamic Insert (dynamic model);
        bool Disconnect();
    }
}
