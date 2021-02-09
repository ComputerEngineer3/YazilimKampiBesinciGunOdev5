using System;
using System.Collections.Generic;
using System.Text;

namespace YazilimKampiBesinciGunOdev5
{
    class UserValidationManager : IUserValidationService
    {
        public bool UserValidate(Customer customer)
        {
            if (customer.Id == 1 && customer.IdentityNumber == 12345 && customer.FirstName == "FirstName1" && customer.LastName == "LastName1" && customer.BirthYear == 1990)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
