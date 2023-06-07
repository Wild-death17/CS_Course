

namespace Study;
class Parabula
{
    private int a;
    private int b;
    private int c;

    public Parabula(int a, int b, int c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public bool onLine(int x, int y)
    {
        int z = this.a * x * x;
        z += this.b * x;
        z += c;
        if (z == y)
        {
            return true;
        }
        return false;
    }
}