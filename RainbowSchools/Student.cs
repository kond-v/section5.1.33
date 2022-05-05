using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainbowSchools
{
    internal class Student
    {
        public string? name { get; set; }
        public string? grade { get; set; }
        public Student(string csvStudent)
        {
            if(csvStudent == null) throw new ArgumentNullException(nameof(csvStudent));

            string [] studentData = csvStudent.Split(',');
            name = studentData[0];
            grade = studentData[1];
        }
        public Student() { }

        public void Showoff()
        {
            Console.WriteLine("Student Name: {0} studies in {1}", this.name, this.grade);
        }
    }
}
