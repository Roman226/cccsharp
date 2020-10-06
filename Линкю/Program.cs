using sabatex.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Student s1 = new Student("Max","5 group" ,16);
            Student s2 = new Student("Roma", "5 group", 16);
            Student s3 = new Student("Alex", "5 group", 16);
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            File.WriteAllText(@"C:\temp\demo.json", System.Text.Json.JsonSerializer.Serialize(students));
        }
    }
}
