using System;
using System.Collections.Generic;
using System.Text;

namespace Linq
{
    public class Student
    {
        public String Name { get; set; }
        public String Group { get; set; }
        public UInt16 Age { get; set; }

        public Student(String nameP, String groupP, UInt16 ageP)
        {
            Name = nameP;
            Group = groupP;
            Age = ageP;
        }
        public Student()
        {
            Name = "";
            Group = "";
            Age = 0;
        }
        public static Student[] CreateArr() => new Student[]
        {
            new Student()
        };
    }
}
