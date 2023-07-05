using System;

namespace ExtensionMethodHomework
{
    public static class ExtensionSamples
    {
        public static void PrintInfo(this PersonModel person)
        {
            Console.WriteLine(person);
        }

        public static PersonModel SetDefaultAge(this PersonModel person)
        {
            person.Age = 20;
            return person;
        }
    }
}
