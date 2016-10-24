namespace CurrentDateTime
{
    using System;
    public class DateTimeMain
    {
        public static void Main()
        {
            var birthday = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(birthday.Year);
            var yourAge = DateTime.Now - birthday;
            Console.WriteLine(yourAge);
        }
    }
}
