namespace Program2; 

public abstract class Person {
    protected int age;
    protected string firstName;
    protected string lastName;
    
    public Person(int age, string firstName, string lastName) {
        this.age = age;
        this.firstName = firstName;
        this.lastName = lastName;
    }
    
    public int Age {
        get {return age;}
        set {age = value;}
    }
    
    public string FirstName {
        get {return firstName;}
        set {firstName = value;}
    }
    
    public string LastName {
        get {return lastName;}
        set {lastName = value;}
    }
    
    public abstract string ToString();
}