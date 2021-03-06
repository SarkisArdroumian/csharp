using csharp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Items
{
    public class BrieItem : Item, IProcessItem
    {
        public void ProcessItem(Item item)
        {
            item.SellIn = item.SellIn - 1;

            if(item.Quality < 50)
            {
                item.Quality = item.SellIn < 0 ? item.Quality + 2 : item.Quality + 1;
            }
        }
    }
}
