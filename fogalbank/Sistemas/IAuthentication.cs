using System;
using System.Collections.Generic;
using System.Text;

namespace fogalbank.Sistemas
{
    interface IAuthentication
    {
        bool Authentication(string password);
    }
}
