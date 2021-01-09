using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManage
{
    class Microwave : Product
    {
        protected int capacity = 0;
        public int Capacity
        {
            get { return capacity; }
            set { if (0 < capacity) capacity = value; }
        }
        protected int wattage = 0;
        public int Wattage
        {
            get { return wattage; }
            set { if (wattage > 0) wattage = value; }
        }
        
        private string idPreFix = "CP";
        public Microwave(string id = "", string name = "", string brand = "", string madeIn = "", uint warranty = 0, uint amount = 0,
            int capacity = 0, int wattage = 0) : base(id, name, brand, madeIn, warranty, amount)
        {
            try
            {
                Capacity = capacity;
                Wattage = wattage;
                ID = idPreFix + ID;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
