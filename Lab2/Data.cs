using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Data
    {
        private DateTime data;

        public void PokazDate()
        {
            Console.WriteLine($"Ustawiona data to: {data}");
        }

        public void PrzestawOTydzienWPrzod()
        {
            data = data.AddDays(7);
        }

        public void PrzestawOTydzienWTyl()
        {
            data = data.AddDays(-7);
        }

        public void PokazDziejszaDate()
        {
            Console.WriteLine($"Dzisiejsza data to: {data = DateTime.Now}");
        }

        public Data(int days, int months, int years, int hours, int minutes, int seconds) 
        {
            if (days > 0 && ((days <= 31 && months == 1 && months == 3 && months == 5 && months == 7 && months == 8 && months == 10 && months == 12) || (days <= 30 && months == 4 && months == 6 && months == 9 && months == 11) || (days < 29 && CzyPrzestepny(years)) || (days < 28 && !CzyPrzestepny(years))))
            {
                data = data.AddDays(days - 1);
            }
            else
            {
                Console.WriteLine("Podano zły dzień, dzień ustawiony na 1");         
            }
            if (months > 0 && months < 12)
            {
                data = data.AddMonths(months - 1);
            }
            else
            {
                Console.WriteLine("Podano zły miesiac, miesiąc ustawiony na 1");
            }
            if (years >= 1)
            {
                data = data.AddYears(years - 1);
            }
            else
            {
                Console.WriteLine("Podano zły rok, rok ustawiony na 1");
            }
            if (hours >= 0 && hours<24)
            {
                data = data.AddHours(hours);
            }
            else
            {
                Console.WriteLine("Podano złą godzinę, godzina ustawiona na 0");
            }
            if(minutes >= 0 && minutes<60)
            {
                data = data.AddMinutes(minutes);
            }
            else
            {
                Console.WriteLine("Podano złe minuty, minuty ustawione na 0");
            }
            if (seconds >= 0 && seconds < 60)
            {
                data = data.AddSeconds(seconds);
            }
            else
            {
                Console.WriteLine("Podano złe sekundy, sekundy ustawiona na 0");
            }
        }

        bool CzyPrzestepny(int rok)
        {     
            if ((rok % 4 == 0) && (rok % 100 != 0) || (rok % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Data()
        {

        }
    }

}
