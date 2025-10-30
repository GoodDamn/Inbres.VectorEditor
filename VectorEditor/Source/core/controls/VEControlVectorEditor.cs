using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Media;
using core.interfaces;
using core.render;
using SkiaSharp;

namespace core.controls;

public class VEControlVectorEditor
: UserControl {

    public VEIRenderable? skeletonRender { get; set; }

    public VEIPointerable? pointer { get; set; }

    public VEControlVectorEditor() {
        Background = new SolidColorBrush(Colors.Transparent);
    }
    
    protected override void OnPointerMoved(
        PointerEventArgs e
    ) {
        base.OnPointerMoved(e);
        pointer?.onPointerMove(
            e.GetPosition(this)
        );
        InvalidateVisual();
    }

    protected override void OnPointerPressed(
        PointerPressedEventArgs e
    ) {
        base.OnPointerPressed(e);
        pointer?.onPointerDown(
            e.GetPosition(this)
        );
        InvalidateVisual();
    }

    protected override void OnPointerReleased(
        PointerReleasedEventArgs e
    ) {
        base.OnPointerReleased(e);
        pointer?.onPointerUp(
            e.GetPosition(this)
        );
        InvalidateVisual();
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