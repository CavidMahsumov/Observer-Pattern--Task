﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class SendMail
    {
        
        public static void SendMail1(string name)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("zormail44@gmail.com", "CavidMahsumov"),
                EnableSsl = true,
            };

            smtpClient.Send("zormail44@gmail.com", name, "CV", "Your Cv is Accapted");
        }
    }
}
