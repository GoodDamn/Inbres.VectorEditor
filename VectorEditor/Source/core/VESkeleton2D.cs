using System.Drawing;
using Avalonia.Media;
using core.interfaces;

namespace core;

public class VESkeleton2D {

    private readonly LinkedList<Point> _points = new();
    
    public void addSkeletonPoint(
        Point point
    ) {
        _points.AddLast(
            point
        );
    }
    
    public void resetSkeleton() {
        _points.Clear();
    }
    
}