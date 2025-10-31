using Avalonia;
using Avalonia.Media;
using core.interfaces;
using core.pointers;
using core.render;

namespace core.viewModels;

public class VEViewModelEditorImpl
: VEIViewModelEditor {
    
    private readonly VESkeleton2D _skeleton;
    public VESkeleton2DRender? skeletonRender { get; }
    public VEIPointerable? pointer { get; }

    public VEViewModelEditorImpl() {
        _skeleton = new VESkeleton2D();

        double radius = 15;
        
        skeletonRender = new VESkeleton2DRender(
            new Pen(0xff00ff00),
            _skeleton
        ) {
            radiusX = radius,
            radiusY = radius
        };

        pointer = new VEPointerableImpl(
            _skeleton
        ) {
            radius = radius
        };
    }
}