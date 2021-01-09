using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManage
{
    class CellPhone : Product
    {
        protected int ram = 0;
        public int Ram
        {
            get { return ram; }
            set { if (0 < ram) ram = value; }
        }
        public string Chip { get; set; }
        protected int pin = 0;
        public int Pin
        {
            get { return pin; }
            set { if (pin > 0) pin = value; }
        }
        protected double screenSize = 0;
        public double ScreenSize
        {
            get { return screenSize; }
            set { if (screenSize > 0) screenSize = value; }
        }
        private string idPreFix = "CP";
        public CellPhone(string id = "", string name = "", string brand = "", string madeIn = "", uint warranty = 0, uint amount = 0, decimal capital = 0, decimal profit = 0,
            int ram = 0, string chip = "", int pin = 0, double screenSize = 0) : base(id, name, brand, madeIn, warranty, amount, capital, profit)
        {
            try
            {
                Ram = ram;
                Chip = chip;
                Pin = pin;
                ScreenSize = screenSize;
                ID = idPreFix + ID;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
