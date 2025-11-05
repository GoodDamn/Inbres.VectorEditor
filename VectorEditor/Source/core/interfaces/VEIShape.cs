using core.models;

namespace core.interfaces;

public interface VEIShape {
    public VEIRenderable create(
        VEPoint from,
        VEPoint to
    );
}