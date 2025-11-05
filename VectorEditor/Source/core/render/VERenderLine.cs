using Avalonia;
using Avalonia.Media;
using core.interfaces;
using core.models;

namespace core.render;

public class VERenderLine(
    VEPoint from,
    VEPoint to
): VEIRenderable {

    private Pen _pen = new Pen(
        0xffff0000
    ) {
        Thickness = 5,
        LineCap = PenLineCap.Round,
        LineJoin =  PenLineJoin.Round
    };
    
    public void render(
        DrawingContext context
    ) {
        context.DrawLine(
            _pen,
            new Point(from.x, from.y),
            new Point(to.x, to.y)
        );
    }
}