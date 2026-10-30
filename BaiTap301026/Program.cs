using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        string[] name = { "Alice", "Bob", "Charlie", "David", "Eve" };
        int[] height = { 160, 170, 180, 190, 200 };
        int[] age = { 20, 25, 30, 35, 40 };
        bool[] genderismale = { false, true, true, true, false };

        Person person1 = new Person(Ngoc, 175, 60, true);

        