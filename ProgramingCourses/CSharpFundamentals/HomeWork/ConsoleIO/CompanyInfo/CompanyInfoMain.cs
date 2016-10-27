
namespace CompanyInfo
{
    using System;

    public class CompanyInfoMain
    {
        public static void Main()
        {
            var companyName = Console.ReadLine();
            var companyAddress = Console.ReadLine();
            var phoneNumber = Console.ReadLine();
            var faxNumber = Console.ReadLine();
            var webSite = Console.ReadLine();
            var managerName = Console.ReadLine();
            var managerFamaly = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var menagerPhone = Console.ReadLine();

            Console.WriteLine(companyName);
            Console.WriteLine("Address: {0}",companyAddress);
            Console.WriteLine("Tel. {0}",phoneNumber);
            if (string.IsNullOrEmpty(faxNumber))
            {
                Console.WriteLine("Fax: (no fax)");
            }
            else
            {
                Console.WriteLine("Fax: {0}",faxNumber);
            }
            Console.WriteLine("Web site: {0}",webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})",managerName,managerFamaly,age, menagerPhone);
            
        }
    }
}
