using GildedRose.Items;
using System.Text.Json;

namespace GildedRoseConsole
{
    internal class Stock
    {
        internal static IList<Item> Load(string filename)
        {
            using StreamReader reader = new(filename);
            return JsonSerializer.Deserialize<List<Item>>(reader.ReadToEnd())!;
        }
    }
}