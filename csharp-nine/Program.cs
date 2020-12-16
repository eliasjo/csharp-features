using System;

namespace csharp_nine
{
    public record Person(string FirstName, string LastName) : Extender(false);

    public record Extender(bool FromCache);

    public class Program
    {
        public static void Main(string[] args)
        {
            var type = new Person("Max", "Mustermann");
            var cachedType = type.LoadFromCache();
            
            Console.WriteLine($"FirstName: {cachedType.FirstName}\nLastname: {cachedType.LastName}");
            Console.ReadLine();
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
