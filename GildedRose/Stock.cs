using System.Collections;

namespace GildedRose
{
    internal class Stock:IEnumerable<TypedItem>
    {
        public IList<TypedItem> _typedItems = new List<TypedItem>();

        public Stock(IList<Item> items)
        {
            foreach (var item in items)
            {
                _typedItems.Add(new TypedItem(item));
            }
        }
        public int Count { get { return _typedItems.Count; } }

        public IEnumerator<TypedItem> GetEnumerator()
        {
            return _typedItems.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}