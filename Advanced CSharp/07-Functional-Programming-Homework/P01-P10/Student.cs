using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_P10
{
    // Problem 1: Class Student
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public int FacultyNumber { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public IList<int> Marks { get; set; }

        public int GroupNumber { get; set; }

        public Student(string firstName, string lastName, int age, int facultyNumber, string phone, string email, IList<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;

        }
        public static void Main()
        {
            var students = new List<Student>
		    {
			    new Student("Misho", "Mishov",17,1,"021234","",new List<int> {5, 3, 5, 6},1),
			    new Student("Gyosh", "Gyoshev",17,2,"3592321638","gyosh@abv.bg",new List<int> {5, 2, 5, 6},1),
			    new Student("Felix", "Kjelberg",20,3,"07113","pewdiepie@abv.bg",new List<int> {5, 2, 5, 6},2),
			    new Student("Borat", "Boratov",20,4,"083545","borat@gmail.com",new List<int> {5, 2, 5, 5},2),
			    new Student("Hristo", "Domatov",19,5,"+359 2","domat@ght.gh",new List<int> {6, 2, 6, 4},1),
			    new Student("Freddy", "Mercury",21,6,"112345","freddy@abv.bg",new List<int> {4, 2, 6, 3},2),
			    new Student("Trevor", "Philips",46,7,"524354","trevor@hotmail.com",new List<int> {6, 2, 6, 6},3),
		    };
        }
    }
}