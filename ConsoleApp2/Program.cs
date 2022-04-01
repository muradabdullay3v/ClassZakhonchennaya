using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            User Murad = new User("Murad Abdullazade" , "murad.abdullazade.53@mail.ru");
            Murad.PasswordChecker("Paroludemirem51355");
            Murad.Info();
        }
    }
}
