namespace BridgePattern.Formatters
{
    public interface IFormatter
    {
        string Format(string key, string value);
    }
}