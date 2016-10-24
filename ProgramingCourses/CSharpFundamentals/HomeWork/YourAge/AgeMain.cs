namespace YourAge
{
    using System;
    public class AgeMain
    {
        public static void Main()
        {
            var dayOfBirth = DateTime.Parse(Console.ReadLine());
            var today = DateTime.Today;
            var yourAgeNow = today.Year - dayOfBirth.Year;
            if (today < dayOfBirth.AddYears(yourAgeNow)) yourAgeNow--;
            {
                Console.WriteLine(yourAgeNow);
            }
            var afterTenYears = yourAgeNow + 10;
            Console.WriteLine(afterTenYears);
            
          


        }
    }
}
