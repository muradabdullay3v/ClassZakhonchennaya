using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class User: IAccount
    {
        public string Fullname { get; set; }
        public string email { get; set; }
        public string Password { get; set; }
        public bool isUpper;
        public bool isLower;
        public bool isNumber;
        public User(string Fullname , string email)
        {
            this.Fullname = Fullname;
            this.email = email;
        }

        public bool PasswordChecker(string password)
        {
            if (password.Length >= 8)
            {
                foreach (var item in password)
                {
                    if (char.IsUpper((item)))
                    {
                        isUpper = true;
                    }
                    if (char.IsLower((item)))
                    {
                        isLower = true;
                    }
                    if (char.IsNumber((item)))
                    {
                        isNumber = true;
                    }
                }
                if(isUpper && isLower && isNumber)
                {
                    Console.WriteLine("Parol duzgun formatdadir!");
                    return true;
                }
                else
                {
                    Console.WriteLine("En azi bir simvol boyukle biri kicikle biri ise reqem olmalidi");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Shifrenin uzunlugu azdir!");
                return false;
            }
        }

        public void Info()
        {
            Console.WriteLine($"Fullname : {Fullname} Email : {email}");
        }

    }
}
