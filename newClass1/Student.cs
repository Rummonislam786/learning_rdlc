using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newClass1
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Roll { get; set; }
        public string Department { get; set; }

        public List<Student> studentList = new List<Student>();

        public List<Student> GetStudents() {

            studentList.Add(new Student {ID = 1001,Name = "Rummon", Roll = 01, Department = "CSE"});
            studentList.Add(new Student {ID = 1002,Name = "Atika", Roll = 02, Department = "CSE"});
            studentList.Add(new Student {ID = 1003,Name = "Rissal", Roll = 03, Department = "EEE"});
            studentList.Add(new Student {ID = 1004,Name = "Rakin", Roll = 04, Department = "Business"});

            return studentList;

        }
    }
}
