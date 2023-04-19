namespace Program2; 

public class Student : Person {
    private int course;
    private string group;
    private double averageMark;
    private double scholarship;
    
    
    public Student(int age, string firstName, string lastName, int course, string group, double averageMark) : base(age, firstName, lastName) {
        this.course = course;
        this.group = group;
        this.averageMark = averageMark;
    }
    
    public int Course {
        get {return course;}
        set {course = value;}
    }
    
    public string Group {
        get {return group;}
        set {group = value;}
    }
    
    public double AverageMark {
        get {return averageMark;}
        set {averageMark = value;}
    }
    
    public double Scholarship {
        get {return scholarship;}
        set {scholarship = value;}
    }
    
    public double CalculateScholarship() {
        if (averageMark >= 4.5 || course == 1) 
            scholarship = 2000;
        else
            scholarship = 0;
        
        return scholarship;
    }
    
    public override string ToString() {
        return $"Student: {firstName} {lastName}, age: {age}, course: {course}, group: {group}, average mark: {averageMark}";
    }

}