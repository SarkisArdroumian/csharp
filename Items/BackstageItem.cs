using csharp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Items
{
    public class BackstageItem : Item, IProcessItem
    {
        public void ProcessItem(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;

                if (item.SellIn < 11 && item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;
                }

                if (item.SellIn < 6 && item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;
                }
            }

            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
                item.Quality = item.Quality - item.Quality;
            }

        }
    }
}
