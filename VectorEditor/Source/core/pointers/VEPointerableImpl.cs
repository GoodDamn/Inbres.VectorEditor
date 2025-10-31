using Avalonia;
using Avalonia.Input;
using Avalonia.Skia;
using core.interfaces;
using core.models;

namespace core.pointers;

public class VEPointerableImpl(
    VESkeleton2D skeleton
): VEIPointerable {

    private VEPoint? _currentPoint;
    
    public void onPointerMove(
        Point position
    ) {
        if (_currentPoint == null) {
            return;
        }

        _currentPoint.x = position.X;
        _currentPoint.y = position.Y;
    }

    public void onPointerDown(
        Point position
    ) {
        // Find existing point to edit it
        // Yea, there is no BSP algo and Z-fight check
        foreach (
            VEPoint point in skeleton.points
        ) {
            double x = point.x - position.X;
            double y = point.y - position.Y;
            if (Math.Sqrt(x * x + y * y) < 15) {
                _currentPoint = point;
                return;
            }
        }
        
        _currentPoint = new VEPoint {
            x = position.X,
            y = position.Y,
        };
        
        skeleton.points.AddLast(
            _currentPoint
        );
    }

    public void onPointerUp(
        Point position
    ) {
        _currentPoint = null;
    }
}