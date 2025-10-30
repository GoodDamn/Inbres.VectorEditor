using Avalonia;
using core.interfaces;
using core.pointers;
using core.render;

namespace core.viewModels;

public class VEViewModelEditor {
    
    private readonly VESkeleton2D _skeleton;

    public VESkeleton2DRender skeletonRender { get; }
    
    public VEIPointerable pointer { get; }

    public VEViewModelEditor() {
        _skeleton = new VESkeleton2D();
        
        skeletonRender = new VESkeleton2DRender(
            _skeleton
        );
        
        pointer = new VEPointerableImpl(
            _skeleton
        );
    }
}