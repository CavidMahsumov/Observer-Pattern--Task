using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
   public  interface ICustomer
    {
         string ProductName { get; set; }
         
        void getMessage();
    }
    class CustomerwithMail : ICustomer
    {
        public string ProductName { get ;set ; }
        public string email { get ; set; }

        public void getMessage()
        {
           
        }
    }
    class CustomerWithPhone : ICustomer
    {
        public string ProductName { get ; set; }
        public string PhoneNumber { get; set; }

        public void getMessage()
        {
            throw new NotImplementedException();
        }
    }
}
