using Program2;

char choice;

while (true) {
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1. Create a teacher object");
    Console.WriteLine("2. Create a student object");
    Console.WriteLine("3. Exit");
    
    choice = Console.ReadKey().KeyChar;
    Console.WriteLine();
    
    switch (choice) {
        case '1':
            Console.WriteLine("Enter teacher's first name:");
            string firstName = Console.ReadLine();
            
            Console.WriteLine("Enter teacher's last name:");
            string lastName = Console.ReadLine();
            
            Console.WriteLine("Enter teacher's age:");
            int age = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter teacher's position:");
            string position = Console.ReadLine();
            
            Console.WriteLine("Enter teacher's salary:");
            double salary = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter teacher's years of experience:");
            int yearsOfExperience = int.Parse(Console.ReadLine());
            
            Teacher teacher = new Teacher(age, firstName, lastName, position, salary, yearsOfExperience);
            
            Console.WriteLine();
            Console.WriteLine(teacher.ToString());
            Console.WriteLine($"Salary: {teacher.CalculateSalary()} \n");
            
            break;
        case '2':
            Console.WriteLine("Enter student's first name:");
            firstName = Console.ReadLine();
            
            Console.WriteLine("Enter student's last name:");
            lastName = Console.ReadLine();
            
            Console.WriteLine("Enter student's age:");
            age = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter student's course:");
            int course = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter student's group:");
            string group = Console.ReadLine();
            
            Console.WriteLine("Enter student's average mark:");
            double averageMark = double.Parse(Console.ReadLine());
            
            Student student = new Student(age, firstName, lastName, course, group, averageMark);
            
            Console.WriteLine();
            Console.WriteLine(student.ToString());
            Console.WriteLine($"Scholarship: {student.CalculateScholarship()} \n");
            
            break;
        case '3':
            return;
        default:
            Console.WriteLine("Invalid option");
            break;
    }
    
}