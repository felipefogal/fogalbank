using System;
using System.Collections.Generic;
using System.Text;

namespace fogalbank.Sistemas
{
    class SystemInternal
    {
        public bool Login(IAuthentication employee, string password)
        {
            bool autheticateUser = employee.Authentication(password);
            if (autheticateUser)
            {
                Console.WriteLine("Realizado com sucesso!");
                return true;
            } else
            {
                Console.WriteLine("Falha na autenticação!");
                return false;
            }
        }
    }
}
