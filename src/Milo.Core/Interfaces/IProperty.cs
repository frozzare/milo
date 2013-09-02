namespace Milo.Core.Interfaces
{
    public interface IProperty
    {
        string Key { get; set; }
        string Value { get; set; }
        string ToString();
    }
}
