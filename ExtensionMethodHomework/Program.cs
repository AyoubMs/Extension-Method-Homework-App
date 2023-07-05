using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();
            person.FirstName = "Ayoub";
            person.LastName = "Chahir";

            person.SetDefaultAge().PrintInfo();

            Console.ReadLine();
        }
    }
}
