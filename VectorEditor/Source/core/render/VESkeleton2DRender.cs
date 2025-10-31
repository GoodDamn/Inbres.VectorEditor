using Avalonia;
using Avalonia.Media;
using core.interfaces;
using core.models;

namespace core.render;

public class VESkeleton2DRender(
    Pen pen,
    VESkeleton2D skeleton
): VEIRenderable {
    public void render(
        DrawingContext context
    ) {
        foreach (
            VEPoint point in skeleton.points
        ) {
            context.DrawEllipse(
                null,
                pen,
                new Point(point.x, point.y),
                50,
                50
            );
        }
    }
}