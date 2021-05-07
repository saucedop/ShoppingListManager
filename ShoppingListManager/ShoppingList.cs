using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListManager
{
    class ShoppingList
    {
        private List<Items> _items { get; set; }
        public void AddItem(Items items)
        {
            _items.Add(items);
        }
    }
}
