using System;
using System.Collections.Generic;
using System.Text;

namespace YazilimKampiBesinciGunOdev5
{
    interface ICustomerService
    {
        void AddMember(Customer customer);
        void UpdateMember(Customer customer);
        void DeleteMember(Customer customer);
    }
}
