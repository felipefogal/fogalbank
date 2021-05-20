using fogalbank.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace fogalbank
{
    class CommercialPartner: IAuthentication
    {
        public string password { get; set; }

        public bool Authentication(string password)
        {
            return this.password == password;
        }
    }
}
