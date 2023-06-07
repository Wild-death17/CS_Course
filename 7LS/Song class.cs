
namespace _7LS;

class Song
{
    private string name;
    private int Length;

    public Song(string name, int length)
    {
        this.name = name;
        this.Length = length;
    }
    public string GetName() { return name; }
    public int GetLength() { return Length; }
    public void SetName(string name) { this.name = name; }
}