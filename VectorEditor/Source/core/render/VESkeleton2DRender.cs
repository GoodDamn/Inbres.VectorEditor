using Avalonia;
using Avalonia.Media;
using core.interfaces;
using core.models;

namespace core.render;

public class VESkeleton2DRender(
    Pen pen,
    VESkeleton2D skeleton
): VEIRenderable {
    public double radiusX { private get; set; }
    public double radiusY { private get; set; }

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
                radiusX,
                radiusY
            );
        }
    }
}