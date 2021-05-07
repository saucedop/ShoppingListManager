using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListManager
{
    class Items
    {
        public Items(string name, DateTime dateAdded, string priority, string category, DateTime datePurchased)
        {
            Name = name;
            DateAdded = dateAdded;
            Priority = priority;
            Category = category;
            DatePurchased = datePurchased;
        }
        public string Name { get; set; }
        public string DateAdded { get; set; }
        public string Priority { get; set; }
        public string Category { get; set; }
        public string DatePurchased { get; set; }
    }
}
