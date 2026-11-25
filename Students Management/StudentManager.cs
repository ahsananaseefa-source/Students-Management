
using System.Linq;
namespace Students_Management
{
    internal class StudentManager
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(int id , string name, int age, int courseId)
        {
            Student student = new Student();

            student.Id = id;
            student.Name = name;
            student.Age = age;
            student.CourseId = courseId;

            students.Add(student);

            Console.WriteLine("Student added successfully!");
        }

        public void ListStudents()
        {

            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }
            foreach(Student student in students)
            {
                Console.WriteLine($"ID:{student.Id}");
                Console.WriteLine($"Name:{student.Name}");
                Console.WriteLine($"Age:{student.Age}");
                Console.WriteLine($"Course ID:{student.CourseId}");
            }
        }

        public void UpdateStudent(int id , string name, int age,int courseId)
        {
            
            Student student = students.FirstOrDefault(s => s.Id == id);

            if(student == null)
            {
                Console.WriteLine("Student not found");
                return;
            }

            student.Name = name;
            student.Age = age;
            student.CourseId = courseId;

            Console.WriteLine("Student updated successfully");

        }

        public void DeleteStudent(int id)
        {
            Student student = students.FirstOrDefault(s => s.Id == id);

            if(student == null)
            {
                Console.WriteLine("Student not found");
                return;
            }

            students.Remove(student);

            Console.WriteLine("Student deletedd successfully!");
        }

        public void FilterStudentsByAge(int age)
        {
            var result = students.Where(ss => ss.Age > age);

            foreach (var student in result)
            {
                Console.WriteLine($"Name: {student.Name}");
                Console.WriteLine($"Age:{student.Age}");
            }
            if(!result.Any())
            {
                Console.WriteLine("no students found.");
                return;
            }
        }

        public void FilterStudentsByCourse(int courseId)
        {
            var result = students.Where(s => s.CourseId == courseId);

            if (!result.Any())
            {
                Console.WriteLine("No students found in this course.");
                return;
            }

            foreach (var student in result)
            {
                Console.WriteLine($"Student ID: {student.Id}");
                Console.WriteLine($"Name: {student.Name}");
                Console.WriteLine($"Age: {student.Age}");
                Console.WriteLine($"Course ID: {student.CourseId}");
            }
        }

    }
}
