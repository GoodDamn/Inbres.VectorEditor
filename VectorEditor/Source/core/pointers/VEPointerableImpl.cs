using Avalonia;
using Avalonia.Input;
using Avalonia.Skia;
using core.interfaces;
using core.models;
using core.shapes;

namespace core.pointers;

public class VEPointerableImpl(
    VESkeleton2D skeleton,
    VEShapes shapes
): VEIPointerable {

    private VEPoint? _currentPoint;
    private VEPoint? _pointFrom;

    public VEIShape shape { get; set; }
    
    public double radius { get; set; }
    
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
            if (Math.Sqrt(x * x + y * y) < radius) {
                _currentPoint = point;
                return;
            }
        }

        if (_pointFrom == null) {
            _pointFrom = new VEPoint {
                x = position.X,
                y = position.Y
            };
            
            skeleton.points.AddLast(
                _pointFrom
            );
        } else {
            _pointFrom = _currentPoint;
        }
        
        _currentPoint = new VEPoint {
            x = position.X,
            y = position.Y,
        };
        
        skeleton.points.AddLast(
            _currentPoint
        );

        shapes.shapes.AddLast(
            shape.create(
               _pointFrom,
               _currentPoint
            )
        );

    }

    public void onPointerUp(
        Point position
    ) {
        _currentPoint = null;
    }
}