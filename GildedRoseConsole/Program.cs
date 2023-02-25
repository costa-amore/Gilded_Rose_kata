using GildedRose;
using System.Text.Json;

namespace GildedRoseConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            List<Item> Items = new List<Item>();

            using (StreamReader r = new StreamReader("Stock.json"))
            { 
                string json = r.ReadToEnd();
                Items = JsonSerializer.Deserialize<List<Item>>(json)!;
            }
            
            var app = new GildedRoseApp(Items);

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    System.Console.WriteLine(Items[j]);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}