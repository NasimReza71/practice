using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem
{
    public class AdminService
    {
        private readonly AttendanceContext _context;

        public AdminService(AttendanceContext context)
        {
            _context = context;
        }

        public void AdminMenu()
        {
            while (true)
            {
                Console.WriteLine("Admin Menu:");
                Console.WriteLine("1. Create Teacher");
                Console.WriteLine("2. Create Course");
                Console.WriteLine("3. Create Student");
                Console.WriteLine("4. Assign Teacher to Course");
                Console.WriteLine("5. Assign Student to Course");
                Console.WriteLine("6. Exit");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                if (choice == 1)
                {
                    CreateTeacher();
                }
                else if (choice == 2)
                {
                    CreateCourse();
                }
                else if (choice == 3)
                {
                    CreateStudent();
                }
                else if (choice == 4)
                {
                    AssignTeacherToCourse();
                }
                else if (choice == 5)
                {
                    AssignStudentToCourse();
                }
                else if (choice == 6)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Wrong Input");
                }
            }
        }

        private void CreateTeacher()
        {
            Console.WriteLine("Enter Teacher Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Username:");
            string username = Console.ReadLine();

            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();

            _context.Teachers.Add(new Teacher { Name = name, Username = username, Password = password });
            _context.SaveChanges();

            Console.WriteLine("Teacher created successfully.");
        }

        private void CreateCourse()
        {
            Console.WriteLine("Enter Course Name:");
            string courseName = Console.ReadLine();

            Console.WriteLine("Enter Course Fees:");
            decimal fees;
            if (!decimal.TryParse(Console.ReadLine(), out fees))
            {
                Console.WriteLine("Invalid input for fees. Please enter a valid number.");
                return;
            }

            _context.Courses.Add(new Course { CourseName = courseName, Fees = fees });
            _context.SaveChanges();

            Console.WriteLine("Course created successfully.");
        }

        private void CreateStudent()
        {
            Console.WriteLine("Enter Student Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Username:");
            string username = Console.ReadLine();

            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();

            _context.Students.Add(new Student { Name = name, Username = username, Password = password });
            _context.SaveChanges();

            Console.WriteLine("Student created successfully.");
        }

        private void AssignTeacherToCourse()
        {
            Console.WriteLine("Enter Course ID:");
            int courseId;
            if (!int.TryParse(Console.ReadLine(), out courseId))
            {
                Console.WriteLine("Invalid input for Course ID.");
                return;
            }

            Console.WriteLine("Enter Teacher ID:");
            int teacherId;
            if (!int.TryParse(Console.ReadLine(), out teacherId))
            {
                Console.WriteLine("Invalid input for Teacher ID.");
                return;
            }

            var course = _context.Courses.Find(courseId);
            var teacher = _context.Teachers.Find(teacherId);

            if (course == null || teacher == null)
            {
                Console.WriteLine("Course or Teacher not found.");
                return;
            }

            course.Teachers.Add(teacher);
            _context.SaveChanges();

            Console.WriteLine("Teacher assigned to course successfully.");
        }

        private void AssignStudentToCourse()
        {
            Console.WriteLine("Enter Course ID:");
            int courseId;
            if (!int.TryParse(Console.ReadLine(), out courseId))
            {
                Console.WriteLine("Invalid input for Course ID.");
                return;
            }

            Console.WriteLine("Enter Student ID:");
            int studentId;
            if (!int.TryParse(Console.ReadLine(), out studentId))
            {
                Console.WriteLine("Invalid input for Student ID.");
                return;
            }

            var course = _context.Courses.Find(courseId);
            var student = _context.Students.Find(studentId);

            if (course == null || student == null)
            {
                Console.WriteLine("Course or Student not found.");
                return;
            }

            course.Students.Add(student);
            _context.SaveChanges();

            Console.WriteLine("Student assigned to course successfully.");
        }
    }
}
