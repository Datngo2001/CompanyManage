using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManage
{
    abstract class Product
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string MadeIn { get; set; }
        private decimal capital = 0;
        public decimal Capital
        {
            get { return capital; }
            set
            {
                if(value > 0)
                {
                    capital = value;
                    Price = Capital + Profit;
                }
            }
        }
        private decimal profit = 0;
        public decimal Profit
        {
            get { return profit; }
            set
            {
                if (value > 0)
                {
                    profit = value;
                    Price = Capital + Profit;
                }
            }
        }

        public decimal Price { get; protected set; }
        protected uint maxWarranty = 10;
        protected uint warranty = 0;
        public uint Warranty
        {
            get { return warranty; }
            set
            {
                if(0 <= value && value <= 10)
                {
                    warranty = value;
                }
            }
        }
        protected uint amount = 0;
        public uint Amount
        {
            get { return amount; }
            set
            {
                if (0 <= value)
                {
                    amount = value;
                }
            }
        }
        public Product(string id = "", string name = "", string brand = "", 
            string madeIn = "", uint warranty = 0, uint amount = 0, decimal capital = 0, decimal profit = 0)
        {
            try
            {
                ID = id;
                Name = name;
                Brand = brand;
                MadeIn = madeIn;
                Warranty = warranty;
                Amount = amount;
                Capital = capital;
                Profit = profit;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public virtual void Input()
        {

        }
        public virtual void Output()
        {

        }
        //public static decimal operator +=(Product.Capital a,  )
    }
}
