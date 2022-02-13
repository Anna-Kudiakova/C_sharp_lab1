using System;


namespace Lab1_wpf_kudiakova
{
    public static class Validator
    {
        public static int DefineAge(DateTime birthDate)
        {

            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
            {
                age -= 1;
            }

            return age;
        }

        public static bool ValidateAge(DateTime birthDate)
        {
            if ((birthDate > DateTime.Now) || (DefineAge(birthDate) > 135))
            {
                return false;
            }
            return true;
        }
    }
}
