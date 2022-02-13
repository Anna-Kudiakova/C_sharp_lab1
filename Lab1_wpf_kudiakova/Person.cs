using System;

namespace Lab1_wpf_kudiakova
{
    public class Person
    {
        DateTime _birthDate;
        int _age;
        string _zodiac;
        string _chineseZodiac;


        public Person(DateTime birthDate)
        {
            _birthDate = birthDate;
        }

        public int DefineAge()
        {

            _age = DateTime.Now.Year - _birthDate.Year;
            if (DateTime.Now.DayOfYear < _birthDate.DayOfYear)
            {
                _age -= 1;
            }

            return _age;
        }

        public bool HaveBirthday()
        {
            if (DateTime.Now.DayOfYear == _birthDate.DayOfYear)
            {
                return true;
            }
            return false;
        }

        public string DefineAstrologicalSign()
        {
            int month = _birthDate.Month;
            int day = _birthDate.Day;
            if ((day >= 21 && month == 3) || (day <= 19 && month == 4))
                _zodiac = "Aries";
            if ((day >= 23 && month == 9) || (day <= 23 && month == 10))
                _zodiac = "Libra";
            if ((day >= 20 && month == 4) || (day <= 20 && month == 5))
                _zodiac = "Taurus";
            if ((day >= 24 && month == 10) || (day <= 21 && month == 11))
                _zodiac = "Scorpio";
            if ((day >= 21 && month == 5) || (day <= 21 && month == 6))
                _zodiac = "Gemini";
            if ((day >= 22 && month == 11) || (day <= 21 && month == 12))
                _zodiac = "Sagittarius";
            if ((day >= 22 && month == 6) || (day <= 22 && month == 7))
                _zodiac = "Cancer";
            if ((day >= 22 && month == 12) || (day <= 19 && month == 1))
                _zodiac = "Capricorn";
            if ((day >= 23 && month == 7) || (day <= 22 && month == 8))
                _zodiac = "Leo";
            if ((day >= 20 && month == 1) || (day <= 18 && month == 2))
                _zodiac = "Aquarius";
            if ((day >= 24 && month == 8) || (day <= 23 && month == 9))
                _zodiac = "Virgo";
            if ((day >= 19 && month == 2) || (day <= 20 && month == 3))
                _zodiac = "Pisces";
            return _zodiac;
        }

        public string DefineChineseZodiac()
        {
            int zodiac = (_birthDate.Year - 4) % 12;
            string[] animals = { "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat", "Monkey", "Rooster", "Dog", "Pig" };
            _chineseZodiac = animals[zodiac];
            return _chineseZodiac;
        }
    }
}
