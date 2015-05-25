using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_P10
{
    class FromP01toP10
    {
        static void Main()
        {
            Console.WriteLine("Problem 2: Students by Group\n");
            StudentsByGroup();
            Console.WriteLine("Problem 3: Students by First and Last name\n");
            StudentsByFirstAndLastName();
            Console.WriteLine("Problem 4: Students by Age\n");
            StudentsByAge();
            Console.WriteLine("Problem 5: Sort Students\n");
            SortStudents();
            Console.WriteLine("Problem 6: Filter Students by Email Domain\n");
            FilterStudentsByEmailDomain();
            Console.WriteLine("Problem 7: Filter Students by Phone\n");
            FilterStudentsByPhone();
            Console.WriteLine("Problem 8: Excellent Students\n");
            ExcellentStudents();
            Console.WriteLine("Problem 9: Weak Students\n");
            WeakStudents();
            Console.WriteLine("Problem 10: Students Enrolled in 2014\n");
            StudentsEnrolledIn2014();
            Console.WriteLine();
        }

        public static void StudentsByGroup()
        {
            var student = new List<Student>
            {
                new Student("Misho", "Mishov",17,1,"021234","",new List<int> {5, 3, 5, 6},1),
			    new Student("Gyosh", "Gyoshev",17,2,"3592321638","gyosh@abv.bg",new List<int> {5, 2, 5, 6},1),
			    new Student("Felix", "Kjelberg",20,3,"07113","pewdiepie@abv.bg",new List<int> {5, 2, 5, 6},2),
			    new Student("Borat", "Boratov",20,4,"083545","borat@gmail.com",new List<int> {5, 2, 5, 5},2),
			    new Student("Hristo", "Domatov",19,5,"+359 2","domat@ght.gh",new List<int> {6, 2, 6, 4},1),
			    new Student("Freddy", "Mercury",21,6,"112345","freddy@abv.bg",new List<int> {4, 2, 6, 3},2),
			    new Student("Trevor", "Philips",46,7,"524354","trevor@hotmail.com",new List<int> {6, 2, 6, 6},3),
            };

            var groupTwoStudents =
                from st in student
                where st.GroupNumber == 2
                orderby st.FirstName
                select st;

            foreach (var st in groupTwoStudents)
            {
                Console.WriteLine("First Name = {0}, Last Name = {1}, Age = {2}, Faculty Number = {3}, Phone = {4}, Email = {5}, Marks = {6}, Group Number = {7}", st.FirstName,st.LastName,st.Age,st.FacultyNumber,st.Phone,st.Email, string.Join(" ",st.Marks),st.GroupNumber);
            }   
        }

        public static void StudentsByFirstAndLastName()
        {
            var student = new List<Student>
            {
                new Student("Misho", "Mishov",17,1,"021234","",new List<int> {5, 3, 5, 6},1),
			    new Student("Gyosh", "Gyoshev",17,2,"3592321638","gyosh@abv.bg",new List<int> {5, 2, 5, 6},1),
			    new Student("Felix", "Kjelberg",20,3,"07113","pewdiepie@abv.bg",new List<int> {5, 2, 5, 6},2),
			    new Student("Borat", "Boratov",20,4,"083545","borat@gmail.com",new List<int> {5, 2, 5, 5},2),
			    new Student("Hristo", "Domatov",19,5,"+359 2","domat@ght.gh",new List<int> {6, 2, 6, 4},1),
			    new Student("Freddy", "Mercury",21,6,"112345","freddy@abv.bg",new List<int> {4, 2, 6, 3},2),
			    new Student("Trevor", "Philips",46,7,"524354","trevor@hotmail.com",new List<int> {6, 2, 6, 6},3),
            };

            var studentsFirstAndLastName =
                from st in student
                where st.FirstName.CompareTo(st.LastName) < 0
                select st;

            foreach (var st in studentsFirstAndLastName)
            {
                Console.WriteLine("First Name = {0}, Last Name = {1}, Age = {2}, Faculty Number = {3}, Phone = {4}, Email = {5}, Marks = {6}, Group Number = {7}", st.FirstName, st.LastName, st.Age, st.FacultyNumber, st.Phone, st.Email, string.Join(" ", st.Marks), st.GroupNumber);
            }
        }

        public static void StudentsByAge()
        {
            var student = new List<Student>
            {
                new Student("Misho", "Mishov",17,1,"021234","",new List<int> {5, 3, 5, 6},1),
			    new Student("Gyosh", "Gyoshev",17,2,"3592321638","gyosh@abv.bg",new List<int> {5, 2, 5, 6},1),
			    new Student("Felix", "Kjelberg",20,3,"07113","pewdiepie@abv.bg",new List<int> {5, 2, 5, 6},2),
			    new Student("Borat", "Boratov",20,4,"083545","borat@gmail.com",new List<int> {5, 2, 5, 5},2),
			    new Student("Hristo", "Domatov",19,5,"+359 2","domat@ght.gh",new List<int> {6, 2, 6, 4},1),
			    new Student("Freddy", "Mercury",21,6,"112345","freddy@abv.bg",new List<int> {4, 2, 6, 3},2),
			    new Student("Trevor", "Philips",46,7,"524354","trevor@hotmail.com",new List<int> {6, 2, 6, 6},3),
            };

            var studentsByAge =
                from st in student
                where (st.Age >= 18 && st.Age <= 24)
                select new { st.FirstName, st.LastName, st.Age };

            foreach (var st in studentsByAge)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName + " " + st.Age);
            }
        }

        public static void SortStudents()
        {
            var student = new List<Student>
            {
                new Student("Misho", "Mishov",17,1,"021234","",new List<int> {5, 3, 5, 6},1),
			    new Student("Gyosh", "Gyoshev",17,2,"3592321638","gyosh@abv.bg",new List<int> {5, 2, 5, 6},1),
			    new Student("Felix", "Kjelberg",20,3,"07113","pewdiepie@abv.bg",new List<int> {5, 2, 5, 6},2),
			    new Student("Borat", "Boratov",20,4,"083545","borat@gmail.com",new List<int> {5, 2, 5, 5},2),
			    new Student("Hristo", "Domatov",19,5,"+359 2","domat@ght.gh",new List<int> {6, 2, 6, 4},1),
			    new Student("Freddy", "Mercury",21,6,"112345","freddy@abv.bg",new List<int> {4, 2, 6, 3},2),
			    new Student("Trevor", "Philips",46,7,"524354","trevor@hotmail.com",new List<int> {6, 2, 6, 6},3),
            };

            Console.WriteLine("Using Lambda:");
            Console.WriteLine();

            var sortStudentsLambda = student.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName).Select(st => (string.Format("{0} {1}", st.FirstName, st.LastName)));
            foreach (var st in sortStudentsLambda)
            {
                Console.WriteLine(st);
            }

            Console.WriteLine();
            Console.WriteLine("LINQ query:");
            Console.WriteLine();

            var sortStudentsLINQ =
                from st in student
                orderby st.FirstName descending, st.LastName descending
                select st;

            foreach (var st in sortStudentsLINQ)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName);
            }
        }

        public static void FilterStudentsByEmailDomain()
        {
            var student = new List<Student>
            {
                new Student("Misho", "Mishov",17,1,"021234","",new List<int> {5, 3, 5, 6},1),
			    new Student("Gyosh", "Gyoshev",17,2,"3592321638","gyosh@abv.bg",new List<int> {5, 2, 5, 6},1),
			    new Student("Felix", "Kjelberg",20,3,"07113","pewdiepie@abv.bg",new List<int> {5, 2, 5, 6},2),
			    new Student("Borat", "Boratov",20,4,"083545","borat@gmail.com",new List<int> {5, 2, 5, 5},2),
			    new Student("Hristo", "Domatov",19,5,"+359 2","domat@ght.gh",new List<int> {6, 2, 6, 4},1),
			    new Student("Freddy", "Mercury",21,6,"112345","freddy@abv.bg",new List<int> {4, 2, 6, 3},2),
			    new Student("Trevor", "Philips",46,7,"524354","trevor@hotmail.com",new List<int> {6, 2, 6, 6},3),
            };

            var studentsByEmails =
                from st in student
                where st.Email.Contains("@abv.bg")
                select st;

            foreach (var st in studentsByEmails)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName + "-->" + st.Email);
            }
        }

        public static void FilterStudentsByPhone()
        {
            var student = new List<Student>
            {
                new Student("Misho", "Mishov",17,1,"021234","",new List<int> {5, 3, 5, 6},1),
			    new Student("Gyosh", "Gyoshev",17,2,"3592321638","gyosh@abv.bg",new List<int> {5, 2, 5, 6},1),
			    new Student("Felix", "Kjelberg",20,3,"07113","pewdiepie@abv.bg",new List<int> {5, 2, 5, 6},2),
			    new Student("Borat", "Boratov",20,4,"083545","borat@gmail.com",new List<int> {5, 2, 5, 5},2),
			    new Student("Hristo", "Domatov",19,5,"+359 2","domat@ght.gh",new List<int> {6, 2, 6, 4},1),
			    new Student("Freddy", "Mercury",21,6,"112345","freddy@abv.bg",new List<int> {4, 2, 6, 3},2),
			    new Student("Trevor", "Philips",46,7,"524354","trevor@hotmail.com",new List<int> {6, 2, 6, 6},3),
            };

            var studentsPhoneSofia =
                from st in student
                where (st.Phone.StartsWith("02") || st.Phone.StartsWith("+3592") || st.Phone.StartsWith("+359 2"))
                select st;

            foreach (var st in studentsPhoneSofia)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName + " --> " + st.Phone);
            }
        }

        public static void ExcellentStudents()
        {
            var student = new List<Student>
            {
                new Student("Misho", "Mishov",17,1,"021234","",new List<int> {5, 3, 5, 6},1),
			    new Student("Gyosh", "Gyoshev",17,2,"3592321638","gyosh@abv.bg",new List<int> {5, 2, 5, 6},1),
			    new Student("Felix", "Kjelberg",20,3,"07113","pewdiepie@abv.bg",new List<int> {5, 2, 5, 6},2),
			    new Student("Borat", "Boratov",20,4,"083545","borat@gmail.com",new List<int> {5, 2, 5, 5},2),
			    new Student("Hristo", "Domatov",19,5,"+359 2","domat@ght.gh",new List<int> {6, 2, 6, 4},1),
			    new Student("Freddy", "Mercury",21,6,"112345","freddy@abv.bg",new List<int> {4, 2, 6, 3},2),
			    new Student("Trevor", "Philips",46,7,"524354","trevor@hotmail.com",new List<int> {6, 2, 6, 6},3),
            };

            var excellentStudents =
                from st in student
                where (st.Marks.Max() == 6)
                select new { Fullname = string.Join(" ", st.FirstName, st.LastName), Marks = string.Join(" ", st.Marks) };

            foreach (var st in excellentStudents)
            {
                Console.WriteLine(st.Fullname + " " + st.Marks);
            }
        }

        public static void WeakStudents()
        {
            var student = new List<Student>
            {
                new Student("Misho", "Mishov",17,1,"021234","",new List<int> {5, 3, 5, 6},1),
			    new Student("Gyosh", "Gyoshev",17,2,"3592321638","gyosh@abv.bg",new List<int> {5, 2, 5, 6},1),
			    new Student("Felix", "Kjelberg",20,3,"07113","pewdiepie@abv.bg",new List<int> {5, 2, 5, 6},2),
			    new Student("Borat", "Boratov",20,4,"083545","borat@gmail.com",new List<int> {5, 2, 5, 5},2),
			    new Student("Hristo", "Domatov",19,5,"+359 2","domat@ght.gh",new List<int> {6, 2, 6, 4},1),
			    new Student("Freddy", "Mercury",21,6,"112345","freddy@abv.bg",new List<int> {4, 2, 6, 3},2),
			    new Student("Trevor", "Philips",46,7,"524354","trevor@hotmail.com",new List<int> {6, 2, 6, 6},3),
            };
            var countThem = student.ExtentionCount();

            foreach (var st in countThem)
            {
                Console.WriteLine("{0} {1} {2}", st.FirstName, st.LastName, string.Join(" ", st.Marks));
            }
        }

        public static void StudentsEnrolledIn2014()
        {
            var student = new List<Student>
            {
                new Student("Misho", "Mishov",17,1,"021234","",new List<int> {5, 3, 5, 6},1),
			    new Student("Gyosh", "Gyoshev",17,2,"3592321638","gyosh@abv.bg",new List<int> {5, 2, 5, 6},1),
			    new Student("Felix", "Kjelberg",20,3,"07113","pewdiepie@abv.bg",new List<int> {5, 2, 5, 6},2),
			    new Student("Borat", "Boratov",20,4,"083545","borat@gmail.com",new List<int> {5, 2, 5, 5},2),
			    new Student("Hristo", "Domatov",19,5,"+359 2","domat@ght.gh",new List<int> {6, 2, 6, 4},1),
			    new Student("Freddy", "Mercury",21,6,"112345","freddy@abv.bg",new List<int> {4, 2, 6, 3},2),
			    new Student("Trevor", "Philips",46,7,"524354","trevor@hotmail.com",new List<int> {6, 2, 6, 6},3),
            };


            var enroledIn2014 =
                from st in student
                where (st.FacultyNumber.Equals(14))
                select st;

            foreach (var st in enroledIn2014)
            {
                Console.WriteLine("{0} {1} {2}", st.FirstName, st.LastName, string.Join(" ", st.Marks));
            }
        }
    }
}