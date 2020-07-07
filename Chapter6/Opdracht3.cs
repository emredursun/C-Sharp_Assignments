﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
{
    class Opdracht3
    {
        public Opdracht3()
        {
            /*
             * Opdracht 6.3:
                Schrijf een methode Zodiac die als resultaat het sterrenbeeld geeft behorend bij een gegeven
                datum. De datum moet als parameter worden meegegeven en het resultaat is een string.

           */

            Console.WriteLine("\n\tThis script displays Astrological sign or Zodiac sign for given date of birth.");

            string mainInput;
            int day;
            string month;
            int year;

            Console.Write("\nEnter your date of birth in the format shown and seperate them by a dash sign(02-january-1988) => ");

            mainInput = Console.ReadLine();
            day = Convert.ToInt32(mainInput.Split('-')[0]);
            month = mainInput.Split('-')[1];
            year = Convert.ToInt32(mainInput.Split('-')[2]);

            Console.WriteLine($"\n\tThe given date of birth is {mainInput}.");
            Zodiac_Sign(day, month);

            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }

        static void Zodiac_Sign(int day, string month)
        {
            string astro_sign = "";

            // checks month and date within the  
            // valid range of a specified zodiac 
            if (month == "december")
            {

                if (day < 22)
                    astro_sign = "Sagittarius";
                else
                    astro_sign = "capricorn";
            }

            else if (month == "january")
            {
                if (day < 20)
                    astro_sign = "Capricorn";
                else
                    astro_sign = "aquarius";
            }

            else if (month == "february")
            {
                if (day < 19)
                    astro_sign = "Aquarius";
                else
                    astro_sign = "pisces";
            }

            else if (month == "march")
            {
                if (day < 21)
                    astro_sign = "Pisces";
                else
                    astro_sign = "aries";
            }
            else if (month == "april")
            {
                if (day < 20)
                    astro_sign = "Aries";
                else
                    astro_sign = "taurus";
            }

            else if (month == "may")
            {
                if (day < 21)
                    astro_sign = "Taurus";
                else
                    astro_sign = "gemini";
            }

            else if (month == "june")
            {
                if (day < 21)
                    astro_sign = "Gemini";
                else
                    astro_sign = "cancer";
            }

            else if (month == "july")
            {
                if (day < 23)
                    astro_sign = "Cancer";
                else
                    astro_sign = "leo";
            }

            else if (month == "august")
            {
                if (day < 23)
                    astro_sign = "Leo";
                else
                    astro_sign = "virgo";
            }

            else if (month == "september")
            {
                if (day < 23)
                    astro_sign = "Virgo";
                else
                    astro_sign = "libra";
            }

            else if (month == "october")
            {
                if (day < 23)
                    astro_sign = "Libra";
                else
                    astro_sign = "scorpio";
            }

            else if (month == "november")
            {
                if (day < 22)
                    astro_sign = "Scorpio";
                else
                    astro_sign = "sagittarius";
            }

            Console.WriteLine($"\n\tZodiac sign for given date of birth is {astro_sign}.");
        }
    }
}