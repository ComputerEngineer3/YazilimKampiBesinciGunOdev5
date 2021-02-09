using System;
using System.Collections.Generic;
using System.Text;

namespace YazilimKampiBesinciGunOdev5
{
    class CustomerManager:ICustomerService
    {
        //Bir manager sınıfının içinde başka bir manager sınıf kullanılacaksa asla onu new leme.
        IUserValidationService _userValidationService;

        public CustomerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void AddMember(Customer customer)
        {
            if (_userValidationService.UserValidate(customer))
            {
                Console.WriteLine("Üye kaydı eklendi: " + customer.FirstName + " " + customer.LastName);
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız.");
            }

            
        }

        public void DeleteMember(Customer customer)
        {
            Console.WriteLine("Üye kaydı silindi: " + customer.FirstName + " " + customer.LastName); ;
        }

        public void UpdateMember(Customer customer)
        {
            Console.WriteLine("Üye kaydı  güncellendi: " + customer.FirstName + " " + customer.LastName);
        }
    }
}
