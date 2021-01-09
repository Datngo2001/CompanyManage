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
        public decimal Capital { get; set; }
        public decimal Profit { get; set; }
        public decimal Price { get; set; }
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
        public Product(string id = "", string name = "", string brand = "", string madeIn = "", uint warranty = 0, uint amount = 0)
        {
            try
            {
                ID = id;
                Name = name;
                Brand = brand;
                MadeIn = madeIn;
                Warranty = warranty;
                Amount = amount;
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
