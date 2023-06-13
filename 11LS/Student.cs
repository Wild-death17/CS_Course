namespace _11LS;
class Student
{
    private string FirstName;
    private string LastName;
    private int Js;
    private int Csharp;
    private Student[] Relative = new Student[1];
    public Student(string firstName, string lastName, int js = 55, int csharp = 55)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Csharp = csharp;
        this.Js = js;
    }
    public int GetCS() { return this.Csharp; }
    public int GetJS() { return this.Js; }
    public string GetName() { return this.FirstName + " " + this.LastName; }
}
