using System.ComponentModel;
using System.Diagnostics.Contracts;

namespace Students_Management
{
    internal class CourseManager
    {
        private Dictionary<int, Course> courses = new Dictionary<int, Course>();

        public void AddCourse(int courseId, string courseName)
        {

            if(courses.ContainsKey(courseId))
            {
                Console.WriteLine("Course Id already exists");
                return;
            }


            Course course = new Course();

            course.CourseId = courseId;
            course.CourseName = courseName;
            courses.Add(courseId, course);

            Console.WriteLine("Course added successFully");

        }


        public void ListCourses()
        {

            if(courses.Count == 0)
            {
                Console.WriteLine("No courses found.");
                return;
            }
            foreach (var item in courses)
            {
                Console.WriteLine($"Course ID: {item.Key}");
                Console.WriteLine($"Course Name : { item.Value.CourseName}");

            }
        }

        public void GetCourseById(int courseId)
        {
            if(courses.TryGetValue(courseId , out Course course))
            {
                Console.WriteLine($"Course ID: {course.CourseId}");
                Console.WriteLine($"Course name: {course.CourseName}");
            }
            else
            {
                Console.WriteLine("Course not found.");
            }
        }
    }

}
