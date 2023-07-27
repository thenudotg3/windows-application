using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_One
{
    class calservice
    {
         double totservice;
       // public double reminder;
       
         double balance;

        public double tot(double service1, double service2, double service3)
        {
            totservice = service1 + service2 + service3;
            return (totservice);
        }

        public double remainder( double recived_ammount)
        {
            balance = recived_ammount - totservice;
            return balance;

        }
    }
    
}
