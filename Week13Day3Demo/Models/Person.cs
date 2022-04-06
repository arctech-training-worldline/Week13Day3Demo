using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13Day3Demo.Models
{
    public class Person
    {
        private const string Path = @"C:\wgs\PersonData.txt";

        public string Name { get; set; }
        public int Age { get; set; }
        public string Comment { get; set; }

        internal void LoadFromFile()
        {
            var personData = File.ReadAllText(Path);

            var fields = personData.Split(", ");

            Name = fields[0].Split(':')[1];
            Age = int.Parse(fields[1].Split(':')[1]);
            Comment = fields[2].Split(':')[1];
        }

        internal void SaveToFile()
        {
            var personData = $"Name:{Name}, Age: {Age}, Comment: {Comment}";
            File.WriteAllText(Path, personData);
        }   
    }
}
