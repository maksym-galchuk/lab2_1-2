namespace line;

public class Line {
    protected double x1, y1, x2, y2;
    
    public Line(double x1, double y1, double x2, double y2) {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }
    
    public double Length() {
        return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 2);
    }
    
    public string BeginToString() {
        return $"({x1}, {y1})";
    }
    
    public string EndToString() {
        return $"({x2}, {y2})";
    }
}

public class Segment : Line {
    public Segment(double x1, double y1, double x2, double y2) : base(x1, y1, x2, y2) {
    }
    
    public double Angle() {
        return Math.Round(Math.Atan2(y2 - y1, x2 - x1) * 180 / Math.PI, 2);
    }
    
    public override string ToString() {
        return $"Segment: {BeginToString()} - {EndToString()}, length: {Length()}, angle: {Angle()}";
    }
}