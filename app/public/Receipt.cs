using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_One
{
    public class Receipt
    {
        public int Id { get; set; }

        public String ProductName { get; set; }

         public double price { get; set; }

        public int Quantity { get; set; }

        public String total { get { return String.Format("{0}$", price * Quantity); } }


    }
}
