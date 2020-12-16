namespace csharp_nine
{
    public record Type(string Name, int Value) : Extender(false);

    public record Extender(bool FromCache);

    public class Program
    {
        public static void Main(string[] args)
        {
            var type = new Type("Hugo", 123);
            var item = type.LoadFromCache();
        }
    }

    public static class GenericExtenderExtension
    {
        public static T LoadFromCache<T>(this T item) where T : Extender
        {
            return item with { FromCache = true};
        }
    }
}
