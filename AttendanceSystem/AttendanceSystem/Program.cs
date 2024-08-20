using AttendanceSystem;

using (var context = new AttendanceContext())
{
    Console.WriteLine("Welcome to the Attendance System");
    Console.WriteLine("Enter your Username:");
    string username = Console.ReadLine();

    Console.WriteLine("Enter your Password:");
    string password = Console.ReadLine();

    var admin = context.Admins.SingleOrDefault(a => a.Username == username && a.Password == password);
    var student = context.Students.SingleOrDefault(s => s.Username == username && s.Password == password);
    var teacher = context.Teachers.SingleOrDefault(t => t.Username == username && t.Password == password);

    if (admin != null)
    {
        Console.WriteLine("Welcome Admin!");
        var adminService = new AdminService(context);
        adminService.AdminMenu();
    }
    else if (student != null)
    {
        Console.WriteLine("Welcome Student!");
        var studentService = new StudentService(context);
        studentService.StudentMenu(student.Id);
    }
    else if (teacher != null)
    {
        Console.WriteLine("Welcome Teacher!");
        var teacherService = new TeacherService(context);
        teacherService.TeacherMenu();
    }
    else
    {
        Console.WriteLine("Invalid username or password.");
    }
}