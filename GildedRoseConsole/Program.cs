using GildedRose;
using System.Text.Json;

namespace GildedRoseConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");
            
            var app = new GildedRoseApp();

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < app.Items.Count; j++)
                {
                    System.Console.WriteLine(app.Items[j]);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}