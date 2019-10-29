using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsole
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public DateTime? CreateTime { get; set; }
        public double Double { get; set; }
        public float Float { get; set; }

    }


    public class Department
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }

    public class Course
    {
        public int CourseID { get; set; }

        public string Title { get; set; }

        public int Credits { get; set; }

        public int DeparmentID { get; set; }

        public virtual Department Department { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Address Address { get; set; }


    }

    public class Address
    {
        public string Street { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
    }

    public class Student
    {
        public long Id { get; set; }

        public string Namew { get; set; }

        public virtual StudentContact Contact { get; set; }
    }

    public class StudentContact
    {
        public long Id { get; set; }

        public string ContactNumber { get; set; }

        public virtual Student Student { get; set; }


    }
}
