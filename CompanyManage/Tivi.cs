using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManage
{
    class Tivi : Product
    {
        protected double size = 0;
        public double Size
        {
            get { return size; }
            set { if (size > 0) size = value; }
        }
        public string ScreenTechnology { get; set; }
        private string idPreFix = "TV";
        public Tivi(string id = "", string name = "", string brand = "", string madeIn = "", uint warranty = 0, uint amount = 0,
            int size = 0, string screenTechnology = "") : base(id, name, brand, madeIn, warranty, amount)
        {
            try
            {
                Size = size;
                ScreenTechnology = screenTechnology;
                ID = idPreFix + ID;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
