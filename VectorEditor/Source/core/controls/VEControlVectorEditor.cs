using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Media;
using core.interfaces;
using core.render;
using SkiaSharp;

namespace core.controls;

public class VEControlVectorEditor
: Control {

    public VEIRenderable? skeletonRender { get; set; }

    public VEIPointerable? pointer { get; set; }
    
    protected override void OnPointerMoved(
        PointerEventArgs e
    ) {
        base.OnPointerMoved(e);
        pointer?.onPointerMove(e);
    }

    protected override void OnPointerPressed(
        PointerPressedEventArgs e
    ) {
        base.OnPointerPressed(e);
        pointer?.onPointerDown(e);
    }

    protected override void OnPointerReleased(
        PointerReleasedEventArgs e
    ) {
        base.OnPointerReleased(e);
        pointer?.onPointerUp(e);
    }

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