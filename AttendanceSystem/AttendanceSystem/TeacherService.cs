using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem
{
    public class TeacherService
    {
        private readonly AttendanceContext _context;

        public TeacherService(AttendanceContext context)
        {
            _context = context;
        }

        public void TeacherMenu()
        {
            while (true)
            {
                Console.WriteLine("Teacher Menu:");
                Console.WriteLine("1. View Attendance Report");
                Console.WriteLine("2. Exit");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                if (choice == 1)
                {
                    ViewAttendanceReport();
                }
                else if (choice == 2)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Wrong Input");
                }
            }
        }

        private void ViewAttendanceReport()
        {
            Console.WriteLine("Enter Course ID:");
            int courseId;
            if (!int.TryParse(Console.ReadLine(), out courseId))
            {
                Console.WriteLine("Invalid input for Course ID.");
                return;
            }

            var course = _context.Courses.Find(courseId);

            if (course == null)
            {
                Console.WriteLine("Course not found.");
                return;
            }

            var students = course.Students;
            var attendances = _context.Attendances
                .Where(a => a.CourseId == courseId)
                .ToList();

            Console.WriteLine($"Attendance Report for Course: {course.CourseName}");

            foreach (var student in students)
            {
                Console.Write($"{student.Name}: ");
                var studentAttendances = attendances.Where(a => a.StudentId == student.Id).ToList();

                foreach (var attendance in studentAttendances)
                {
                    Console.Write(attendance.IsPresent ? "✔ " : "✘ ");
                }

                Console.WriteLine();
            }
        }
    }
}
