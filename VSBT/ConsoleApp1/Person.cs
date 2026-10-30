using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program

    {
        public string Name;
        public int height;
        public int age;
        public bool genderismale;

        public class Person
        {
            public string Name;
            public int height;
            public int weight;
            public bool genderismale;
            public Person(string name, int height, int weight, bool genderismale)
            {
                Name = name;
                this.height = height;
                this.weight = weight;
                this.genderismale = genderismale;
            }
            Person[] people = new Person[5];
            people[0] = new Person("Alice", 160, 50, false);
            people[1] = new Person("Bob", 170, 60, true);
            people[2] = new Person("Charlie", 180, 70, true);
            people[3] = new Person("David", 190, 80, true);
            people[4] = new Person("Eve", 165, 55, false);

            Console.writeline("Hoten/tChieucao/tCannang/tGioitinh");
                for (int i-=0; i<=4; i++)
                Console.Writeline(people[i].name + '\t' + people[i].height + '\t' + people[i].weight + '\t' + people[i].genderismale);
                Console.readline();



        }
}
