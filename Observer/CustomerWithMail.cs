using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class CustomerwithMail : ICustomer
    {
        public string ProductName { get; set; }
        public string email { get; set; }

        public void getMessage()
        {
            SendMail.SendMail1(email);
        }
    }
}
