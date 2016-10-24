
namespace StringsAndObjects
{
    using System;
    public class StringAndObjectsMain
    {
        public static void Main()
        {
            string hello = "Hello";
            string world = "World";
            object objHelloWorld = hello + " " + world;
            string stringHelloWorld = objHelloWorld.ToString();
            Console.WriteLine(objHelloWorld);
            Console.WriteLine(stringHelloWorld);
        }
    }
}
