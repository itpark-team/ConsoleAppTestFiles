using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleAppTestFiles
{
    internal class Program
    {
        [Serializable]
        struct Person
        {
            public string Name;
            public int Age;

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public override string ToString()
            {
                return $"Name: {Name} Age: {Age}";
            }
        }
        static void Main(string[] args)
        {
            /*Person[] people = { 
                new Person("Pit", 19), 
                new Person("Tom", 20) 
            };

            FileStream outputStream = new FileStream("people.txt", FileMode.OpenOrCreate);

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(outputStream, people);

            outputStream.Close();*/

            /*FileStream inputStream = new FileStream("people.txt", FileMode.Open);

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Person[] people = (Person[])binaryFormatter.Deserialize(inputStream);

            inputStream.Close();

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
            Console.ReadKey();*/




            /*StreamReader streamReader = new StreamReader("input.txt");
            int count = int.Parse(streamReader.ReadLine());
            
            int totalSum = 0;
            for (int i = 0; i < count; i++)
            {
                totalSum += int.Parse(streamReader.ReadLine());
            }
            streamReader.Close();

            StreamWriter streamWriter = new StreamWriter("output.txt");
            streamWriter.WriteLine(totalSum);
            streamWriter.Close();*/

            /*StreamReader streamReader = new StreamReader("input.txt");
            StreamWriter streamWriter = new StreamWriter("output.txt");
            while (streamReader.EndOfStream == false)
            {
                streamWriter.WriteLine(streamReader.ReadLine());
            }
            streamReader.Close();
            streamWriter.Close();*/


            /*string allText = File.ReadAllText("input.txt");
            allText = allText.Replace("а", "о");
            File.WriteAllText("output.txt",allText);*/
        }
    }
}
