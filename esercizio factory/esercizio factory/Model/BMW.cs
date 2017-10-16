using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_factory.Model
{
    public class BMW : ICar
    {
        public string Model()
        {
            return "BMW";
        }
    }
}
