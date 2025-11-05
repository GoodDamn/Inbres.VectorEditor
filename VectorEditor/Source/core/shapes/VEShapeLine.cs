using core.interfaces;
using core.models;
using core.render;

namespace core.shapes;

public class VEShapeLine
: VEIShape {
    
    public VEIRenderable create(
        VEPoint from,
        VEPoint to
    ) {
        return new VERenderLine(
            from,
            to
        );
    }
}