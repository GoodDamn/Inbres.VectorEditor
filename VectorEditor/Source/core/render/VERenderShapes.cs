using Avalonia.Media;
using core.interfaces;
using core.models;

namespace core.render;

public class VERenderShapes(
    VEShapes shapes
): VEIRenderable {
    
    public void render(
        DrawingContext context
    ) {
        foreach (
            VEIRenderable shape in shapes.shapes
        ) {
            shape.render(context);
        }
    }
}