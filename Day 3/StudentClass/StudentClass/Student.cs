using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    
        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Course { get; set; }

            public Student(string name, int age, string course)
            {
                Name = name;
                Age = age;
                Course = course;
            }

            public override string ToString()
            {
                return $"Name: {Name},Age: {Age} years, Course: {Course}";
            }
        }

    }

