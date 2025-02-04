using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_Grp_06
{
    public class Product
    {
        public int ProdId;
        public string ProdName;
        public int ItemPrice;
        public int StockAmount;

        public Product(int prodId, string prodName, int itemPrice, int stockAmount)
        {
            if(prodId < 8 || ProdId >80000)
            {
                throw new ArgumentException(" Product ID must be between 8 and 80000");
            }
            if(itemPrice < 8 || itemPrice > 8000)
            {
                throw new ArgumentException("Item price must be between 8 and 8000");
            }
            if (stockAmount < 8 || stockAmount > 800000)
            {
                throw new ArgumentException("Stock amount must be between 8 and 800000");
            }

            ProdId = prodId;
            ProdName = prodName;
            ItemPrice = itemPrice;
            StockAmount = stockAmount;
        }

        public int IncreaseInStock(int amount)
        {
            if(amount > 0)
            {
                StockAmount += amount;
                return StockAmount;
            }
            return StockAmount;
        }
        public int DecreaseInStock(int amount)
        {
            if ( amount != null && StockAmount > amount)
            {
                StockAmount -= amount;
                return StockAmount;
            }
            return StockAmount;

        }
    }
}
