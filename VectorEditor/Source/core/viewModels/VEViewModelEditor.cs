using Avalonia;
using core.render;

namespace core.viewModels;

public class VEViewModelEditor {
    
    private readonly VESkeleton2D _skeleton;

    public VESkeleton2DRender skeletonRender { get; }

    public VEViewModelEditor() {
        _skeleton = new VESkeleton2D();
        skeletonRender = new VESkeleton2DRender(
            _skeleton
        );
    }
    
    public void addPoint(
        Point point
    ) {
        
    }
    
}