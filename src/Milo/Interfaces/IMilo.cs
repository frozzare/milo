using Milo.Core;

namespace Milo.Interfaces
{
    public interface IMilo
    {
        PageData RootPage { get; }
        PageData StartPage { get; }
    }
}
