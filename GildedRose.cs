using csharp.Interface;
using csharp.Items;
using System.Collections.Generic;
using System.Linq;

namespace csharp
{
    public class GildedRose
    {
        #region Members
        public IList<Item> Items;
        #endregion

        #region Constructors
        public GildedRose() { }
        
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;      
        }
        #endregion

        #region Methods
        private IProcessItem GetItemProcess(Item item)
        {
            IProcessItem process = null;

            if (item.Name.Contains("Brie"))
            {
                return process = new BrieItem();
            }
            else if (item.Name.Contains("Dexterity"))
            {
                return process = new DexterityItem();
            }
            else if (item.Name.Contains("Elixir"))
            {
                return process = new ElixirItem();
            }
            else if (item.Name.Contains("Sulfuras"))
            {
                return process = new SulfurasItem();
            }
            else if (item.Name.Contains("Backstage"))
            {
                return process = new BackstageItem();
            }
            else if (item.Name.Contains("Conjured"))
            {
                return process = new ConjuredItem();
            }
            else
            {
                return process = new OtherItem();
            }
        }
      

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                UpdateItemQuality(Items[i]);
            }
        }

        public void UpdateItemQuality(Item item)
        {
            GetItemProcess(item)
                .ProcessItem(item);
        }
        #endregion
    }
}
