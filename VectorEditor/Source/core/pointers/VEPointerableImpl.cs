using Avalonia;
using Avalonia.Input;
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
        _currentPoint = new VEPoint {
            x = position.X,
            y = position.Y,
        };
    }

    public void onPointerUp(
        Point position
    ) {
        if (_currentPoint == null) {
            return;
        }
        
        skeleton.points.AddLast(
            new Point(
                _currentPoint.x,
                _currentPoint.y
            )
        );
        
        _currentPoint = null;
    }
}