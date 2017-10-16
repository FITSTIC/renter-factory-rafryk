using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_factory.Model
{
    static class Renter 
    {
        public static ICar Rent(double budget)
        {
            if (budget<80)
            {
                return new Toyota();
            }
            else
            {
                if(budget>80 && budget<120)
                {
                    return new BMW();
                }
                else
                {
                    if(budget>120)
                    {
                        return new Mercedes();
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
        }
    }
}
