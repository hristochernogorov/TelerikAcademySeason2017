namespace YourAge
{
    using System;
    using System.Threading;
    using System.Globalization;

    public class AgeMain
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            var input = Console.ReadLine();
            var birthday = Convert.ToDateTime(input);
            var today = DateTime.Today;
            int currentAge = today.Year - birthday.Year;
            if (today < birthday.AddYears(currentAge))
            {
                currentAge--;
            }
            var ageAfterTenYears = currentAge + 10;
            if (birthday.Year < today.Year)
            {
                Console.WriteLine(currentAge);
                Console.WriteLine(ageAfterTenYears);
            }

        }
    }
}
