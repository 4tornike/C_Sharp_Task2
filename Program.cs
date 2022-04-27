using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midTerm_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.print();
        }
    }





    public class Student
    {
        public string name;
        public string surname;
        public string course;
        private Subject _Subject = null;
        public  Subject Subject {
            get {
                if(_Subject == null)
                    Subject = new Subject();
                    return _Subject; 
            }
            set {
                if (value == null)
                    _Subject = null;
                else
                {
                    _Subject = value;
                }
            }
        }
        public string university;
        private string email;
        public string Email { get { return email; } set { email = value; } }
        private int phone;
        public int Phone { get { return phone; } set { phone = value; } }
        

        public Student() { }
        public Student(string name,string surname,string course,string university,string email,int phone)
        {
            this.name = name;   this.surname = surname;
            this.course = course;
            this.university = university;
            this.email = email;
            this.phone = phone;
        }

        public void print()
        {
            Console.WriteLine($"student name is {name} {surname},his on {course} course at {university} university." +
                $"students emai: {email}" +
                $"students phone: {phone}");
        }

        public override string ToString()
        {
            return $"student {name} {surname} is on {course} course at {university} university.his/her email: {email}" +
                $"his/her phone: {phone}" +
                $"subject name is {_Subject.name}";
        }


    }

    public class Subject
    {
        public string name = "c#";
        public int semester = 1;
        public int credits = 12;
        public string[] preRequesites = { "math", "linear algebra", "javascript" };
        public int maxStudents = 30;

        public Subject() { }
        public Subject(string name, int semester, int credits, string[] preRequesites, int maxStudents)
        {
            this.name = name;
            this.semester = semester;
            this.credits = credits;
            this.preRequesites = preRequesites;
            this.maxStudents = maxStudents;
        }

    }


}
