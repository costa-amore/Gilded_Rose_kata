using System.Collections;

namespace GildedRose.Items
{
    internal class Stock : IEnumerable<TypedItem>
    {
        #region construction
        public IList<TypedItem> _items = new List<TypedItem>();

        public Stock(IList<Item> items)
        {
            foreach (var item in items)
            {
                _items.Add(TypedItem.Of(item));
            }
        }
        #endregion

        #region IEnumerable
        public IEnumerator<TypedItem> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion
        
        internal void Update()
        {
            foreach (var item in _items)
            {
                item.Update();
            }
        }
    }
}