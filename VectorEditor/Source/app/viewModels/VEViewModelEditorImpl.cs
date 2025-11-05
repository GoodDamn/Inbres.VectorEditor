using Avalonia;
using Avalonia.Media;
using core.interfaces;
using core.models;
using core.pointers;
using core.render;
using core.shapes;

namespace core.viewModels;

public class VEViewModelEditorImpl
: VEIViewModelEditor {
    
    private readonly VESkeleton2D _skeleton;
    private readonly VEShapes _shapes;
    public VESkeleton2DRender? skeletonRender { get; }
    
    public VERenderShapes? renderShapes { get; }
    
    public VEIPointerable? pointer { get; }

    public VEViewModelEditorImpl() {
        _skeleton = new VESkeleton2D();
        _shapes = new VEShapes();

        renderShapes = new VERenderShapes(
            _shapes
        );
        
        double radius = 15;
        
        skeletonRender = new VESkeleton2DRender(
            new Pen(0xff00ff00),
            _skeleton
        ) {
            radiusX = radius,
            radiusY = radius
        };

        pointer = new VEPointerableImpl(
            _skeleton,
            _shapes
        ) {
            radius = radius,
            shape = new VEShapeLine()
        };
    }
}