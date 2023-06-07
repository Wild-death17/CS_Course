
namespace _10LS
{

    class Point
    {
        private int X;
        private int Y;

        public Point(int x = 0, int y = 0)
        {
            setX(x);
            setY(y);
        }
        public void setX(int x)
        {
            if (x < 30) this.X = x;
        }
        public void setY(int y)
        {
            if (y < 30) this.Y = y;
        }
        public string StringMe()
        {
            return $"({this.X},{this.Y})";
        }
        public int getX() { return this.X; } 
        public int getY() { return this.Y; }
        public void GetLine(Point b){}
        public double GetDistance(Point b)
        {
            int dy = this.Y - b.getY(); 
            dy*=dy;    
            int dx= this.X- b.getX(); 
            dx*=dx;
            double d = Math.Sqrt(dx*dx+dy*dy);  
            return d;
        }
    }

}