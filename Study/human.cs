namespace Study;

class Human
{
    public int age;
    public string name;
    public int height;
    public string Birthday;
    private string spouse = "";
    private string friend = "";

    public Human(int a, string b, string c, int d)
    {
        this.age = a;
        this.name = b;
        this.height = d;
        this.Birthday = c;
    }
    public double weight()
    {
        double a = this.age * 2;
        double b = this.height * a;
        return b / 100;
    }
    public void relate(Human a, bool friend)
    {
        if (!friend)

            this.spouse = a.name;

        else

            this.friend = a.name;
    }
}