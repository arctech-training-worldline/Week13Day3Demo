using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week13Day3Demo.Models;

namespace Week13Day3Demo.Services
{
    internal static class PersonsFileService
    {
        private const string Path = @"C:\wgs\PersonData.txt";

        internal static Person LoadFromFile()
        {
            var personData = File.ReadAllText(Path);

            var fields = personData.Split(", ");

            var person = new Person
            {
                Name = fields[0].Split(':')[1],
                Age = int.Parse(fields[1].Split(':')[1]),
                Comment = fields[2].Split(':')[1]
            };

            return person;
        }

        internal static void SaveToFile(Person person)
        {
            var personData = $"Name:{person.Name}, Age: {person.Age}, Comment: {person.Comment}";
            File.WriteAllText(Path, personData);
        }
    }
}
