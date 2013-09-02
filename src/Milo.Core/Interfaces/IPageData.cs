namespace Milo.Core.Interfaces
{
    interface IPageData
    {
        PageData ParentPage { get; }
        IProperty GetProperty(string key);

        PageDataCollection GetChildren();

        string PageName { get; set; }
        string PageTypeName { get; set; }
    }
}
