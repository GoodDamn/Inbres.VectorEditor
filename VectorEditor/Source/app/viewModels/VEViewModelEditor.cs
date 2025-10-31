using Avalonia;
using Avalonia.Media;
using core.interfaces;
using core.pointers;
using core.render;

namespace core.viewModels;

public class VEViewModelEditor
: VEIViewModelEditor {
    
    private readonly VESkeleton2D _skeleton;
    public VESkeleton2DRender? skeletonRender { get; }
    public VEIPointerable pointer { get; }

    public VEViewModelEditor() {
        _skeleton = new VESkeleton2D();

        skeletonRender = new VESkeleton2DRender(
            new Pen(0xff00ff00),
            _skeleton
        ) {
            radiusX = 15,
            radiusY = 15
        };
        
        pointer = new VEPointerableImpl(
            _skeleton
        );
    }
}