namespace Program2; 

public class Teacher : Person {
    private string position;
    private double salary;
    private int yearsOfExperience;
    
    public Teacher(int age, string firstName, string lastName, string position, double salary, int yearsOfExperience) : base(age, firstName, lastName) {
        this.position = position;
        this.salary = salary;
        this.yearsOfExperience = yearsOfExperience;
    }
    
    public string Position {
        get {return position;}
        set {position = value;}
    }
    
    public double Salary {
        get {return salary;}
        set {salary = value;}
    }
    
    public int YearsOfExperience {
        get {return yearsOfExperience;}
        set {yearsOfExperience = value;}
    }
    
    public double CalculateSalary() {
        double bonus = salary * yearsOfExperience * 0.05;
        
        if (position.ToLower() == "professor") 
            bonus += salary * 0.5;
        else if (position.ToLower() == "lecturer") 
            bonus += salary * 0.1;
        else 
            bonus += salary * 0.05;
        
        return salary + bonus;
    }
    
    public override string ToString() {
        return $"Teacher: {firstName} {lastName}, age: {age}, position: {position}, salary: {salary}, years of experience: {yearsOfExperience}";
    }
    
}