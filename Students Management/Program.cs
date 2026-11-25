
using Students_Management;

StudentManager studentManager = new StudentManager();
CourseManager courseManager = new CourseManager();

while (true)
{
    Console.WriteLine("\n===== STUDENT COURSE MANAGEMENT =====");
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. List Students");
    Console.WriteLine("3. Update Student");
    Console.WriteLine("4. Delete Student");
    Console.WriteLine("5. Add Course");
    Console.WriteLine("6. List Courses");
    Console.WriteLine("7. Find Course");
    Console.WriteLine("8. Filter Students By Age");
    Console.WriteLine("9. Filter Students By Course");
    Console.WriteLine("10. Exit");

    Console.Write("Enter your choice: ");

    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            {
                Console.Write("Enter Student ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Student Name: ");
                string name = Console.ReadLine() ?? "";

                Console.Write("Enter Student Age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Course ID: ");
                int courseId = Convert.ToInt32(Console.ReadLine());

                studentManager.AddStudent(id, name, age, courseId);
                break;
            }

        case 2:
            {
                studentManager.ListStudents();
                break;
            }

        case 3:
            {
                Console.Write("Enter Student ID to update: ");
                int updateId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter new Name: ");
                string newName = Console.ReadLine() ?? "";

                Console.Write("Enter new Age: ");
                int newAge = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter new Course ID: ");
                int newCourseId = Convert.ToInt32(Console.ReadLine());

                studentManager.UpdateStudent(
                    updateId, newName, newAge, newCourseId);

                break;
            }

        case 4:
            {
                Console.Write("Enter Student ID to delete: ");
                int deleteId = Convert.ToInt32(Console.ReadLine());

                studentManager.DeleteStudent(deleteId);
                break;
            }

        case 5:
            {
                Console.Write("Enter Course ID: ");
                int addCourseId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Course Name: ");
                string courseName = Console.ReadLine() ?? "";

                courseManager.AddCourse(addCourseId, courseName);
                break;
            }

        case 6:
            {
                courseManager.ListCourses();
                break;
            }

        case 7:
            {
                Console.Write("Enter Course ID to find: ");
                int searchCourseId = Convert.ToInt32(Console.ReadLine());

                courseManager.GetCourseById(searchCourseId);
                break;
            }

        case 8:
            {
                Console.Write("Enter minimum age: ");
                int searchAge = Convert.ToInt32(Console.ReadLine());

                studentManager.FilterStudentsByAge(searchAge);
                break;
            }

        case 9:
            {
                Console.Write("Enter Course ID: ");
                int filterCourseId = Convert.ToInt32(Console.ReadLine());

                studentManager.FilterStudentsByCourse(filterCourseId);
                break;
            }

        case 10:
            {
                Console.WriteLine("Exiting application. Goodbye!");
                return;
            }

        default:
            {
                Console.WriteLine("Invalid choice. Please try again.");
                break;
            }
    }
}
