using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem
{
    public class StudentService
    {
        private readonly AttendanceContext _context;

        public StudentService(AttendanceContext context)
        {
            _context = context;
        }

        public void StudentMenu(int studentId)
        {
            while (true)
            {
                Console.WriteLine("Student Menu:");
                Console.WriteLine("1. Mark Attendance");
                Console.WriteLine("2. Exit");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                if (choice == 1)
                {
                    MarkAttendance(studentId);
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

        private void MarkAttendance(int studentId)
        {
            Console.WriteLine("Enter Course ID:");
            int courseId;
            if (!int.TryParse(Console.ReadLine(), out courseId))
            {
                Console.WriteLine("Invalid input for Course ID.");
                return;
            }

            var course = _context.Courses.Find(courseId);
            var student = _context.Students.Find(studentId);

            if (course == null || student == null)
            {
                Console.WriteLine("Course or Student not found.");
                return;
            }

            if (!student.Courses.Contains(course))
            {
                Console.WriteLine("Student is not enrolled in this course.");
                return;
            }

            var attendance = new Attendance
            {
                CourseId = courseId,
                StudentId = studentId,
                Date = DateTime.Now,
                IsPresent = true 
            };

            _context.Attendances.Add(attendance);
            _context.SaveChanges();

            Console.WriteLine("Attendance marked successfully.");
        }
    }
}
