using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using core.interfaces;
using core.render;
using SkiaSharp;

namespace core.controls;

public class VEControlVectorEditor
: Control {

    public VEIRenderable? skeletonRender { get; set; }
    
    public override void Render(
        DrawingContext context
    ) {
        base.Render(
            context
        );
        
        skeletonRender?.render(
            context
        );
    }
}