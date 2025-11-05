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

    private readonly VEIViewModelEditor _editor;
    public VEControlVectorEditor(
        VEIViewModelEditor editor
    ) {
        _editor = editor;
        Background = new SolidColorBrush(Colors.Transparent);
    }

    protected override void OnPointerMoved(
        PointerEventArgs e
    ) {
        base.OnPointerMoved(e);
        _editor.pointer?.onPointerMove(
            e.GetPosition(this)
        );
        InvalidateVisual();
    }

    protected override void OnPointerPressed(
        PointerPressedEventArgs e
    ) {
        base.OnPointerPressed(e);
        _editor.pointer?.onPointerDown(
            e.GetPosition(this)
        );
        InvalidateVisual();
    }

    protected override void OnPointerReleased(
        PointerReleasedEventArgs e
    ) {
        base.OnPointerReleased(e);
        _editor.pointer?.onPointerUp(
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
        
        _editor.renderShapes?.render(
            context
        );
        
        _editor.skeletonRender?.render(
            context
        );
    }
}