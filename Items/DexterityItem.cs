using csharp.Interface;

namespace csharp.Items
{
    public class DexterityItem : Item, IProcessItem
    {
        public void ProcessItem(Item item)
        {
            item.SellIn = item.SellIn - 1;
          
            if(item.Quality > 0)
            {
                item.Quality = item.SellIn < 0 ? item.Quality - 2 : item.Quality - 1;
            }
        }
    }
}
