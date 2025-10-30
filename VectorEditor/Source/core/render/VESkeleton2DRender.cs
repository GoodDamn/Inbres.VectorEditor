using Avalonia;
using Avalonia.Media;
using core.interfaces;
using core.models;

namespace core.render;

public class VESkeleton2DRender(
    VESkeleton2D skeleton
): VEIRenderable {
    private readonly Pen _pen = new Pen(
        0xffff0000
    );
    
    public void render(
        DrawingContext context
    ) {
        foreach (
            Point point in skeleton.points
        ) {
            context.DrawEllipse(
                null,
                _pen,
                point,
                50,
                50
            );
        }
    }
}