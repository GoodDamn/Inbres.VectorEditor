using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using core.render;
using SkiaSharp;

namespace core.controls;

public class VEControlVectorEditor
: Control {

    public VESkeleton2DRender? skeletonRender { get; set; }
    
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