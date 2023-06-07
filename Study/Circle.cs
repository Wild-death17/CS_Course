namespace Study;

class Circle
{
    private int x;
    private int y;
    private int R;

    public Circle(int x, int y, int r)
    {
        this.x = x;
        this.y = y;
        R = r;
    }
    public int getR() { return R; }

    public bool InCircle(int x, int y)
    {
        int dx = x - this.x;
        int dy = y - this.y;
        if (Math.Sqrt(dx * dx + dy * dy) > this.R) { return false; }
        return true;
    }
}
