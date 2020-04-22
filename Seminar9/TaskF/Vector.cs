sealed class Vector
{
    public double x { get; private set; }
    public double y { get; private set; }
    public Vector(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public Vector(string input)
    {
        x = double.Parse(input.Split()[0]);
        y = double.Parse(input.Split()[1]);
    }

    public override string ToString()
    {
        return string.Format("x:{0:F3} y:{1:F3}",x,y);
    }
}