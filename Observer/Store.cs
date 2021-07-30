using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Store
    {
        public List<ICustomer> Customers { get; set; }
        public void Notify()
        {
            foreach (var item in Customers)
            {
                item.getMessage();
            }
        }
    }
}
