namespace PaintShop;

// 3 - Crie uma classe estática  SquareMetersPerBucket
public static class PaintUtilities
{
    public static int SquareMetersPerBucket
    {
        get
        {
            return BucketSizeLiters * SquareMetersPerLiter;
        }
    }

    public static int BucketSizeLiters { get; } = 20;
    public static int SquareMetersPerLiter { get; } = 10;

    public static int GetNeededPaintBuckets(double area) {
         int balde = Convert.ToInt32(Math.Ceiling(area / SquareMetersPerBucket));
        return balde;
    }

    public static int GetNeededPaintBuckets(Wall wall) {
        int balde = Convert.ToInt32(Math.Ceiling(wall.PaintableArea / SquareMetersPerBucket));
        return balde;
    }

    public static int GetNeededPaintBuckets(Room room) {
        int balde = Convert.ToInt32(Math.Ceiling(room.TotalPaintableArea / SquareMetersPerBucket));
        return balde;
    }

    public static decimal CalculateCost(decimal price, double area) {
        return GetNeededPaintBuckets(area) * price;
    }

    public static decimal CalculateCost(decimal price, Wall wall) {
        return GetNeededPaintBuckets(wall.PaintableArea) * price;
    }

    public static decimal CalculateCost(decimal price, Room room) {
        return GetNeededPaintBuckets(room.TotalPaintableArea) * price; ;
    }
}