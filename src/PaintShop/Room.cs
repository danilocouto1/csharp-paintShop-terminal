namespace PaintShop;

// 2 - Crie uma classe Room
public class Room
{
    public double TotalPaintableArea { get {
            double area = 0;
            foreach (var item in walls)
            {
                area += item.PaintableArea;
            }
            return area;    
        }
    }
    public Wall[] walls { get; }
    public Room(Wall[] walls)
    {
        this.walls = walls;
    }
}