namespace Milo.Core.Interfaces
{
    public interface IPageSource
    {
        PageData GetPage(int pageLink);
        PageDataCollection GetChildren(int pageLink);
    }
}
