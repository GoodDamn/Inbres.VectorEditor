using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using SkiaSharp;

namespace core.controls;

public class VEControlVectorEditor
: Control
{

    private readonly Pen _pen = new Pen(
        0xffff0000
    ) {
        LineCap = PenLineCap.Round,
        LineJoin = PenLineJoin.Round
    };

    public VEControlVectorEditor() {
        
    }
    
    
    public override void Render(
        DrawingContext context
    ) {
        base.Render(
            context
        );
        
        context.DrawLine(
            _pen,
            new Point(0,0),
            new Point(50,50)
        );
    }
}