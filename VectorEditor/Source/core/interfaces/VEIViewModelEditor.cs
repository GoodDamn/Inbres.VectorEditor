using core.render;

namespace core.interfaces;

public interface VEIViewModelEditor {
    
    public VESkeleton2DRender? skeletonRender { get; }
    
    public VERenderShapes? renderShapes { get; }

    public VEIPointerable? pointer { get; }
}