using Avalonia;
using Avalonia.Input;

namespace core.interfaces;

public interface VEIPointerable {
    void onPointerMove(
        Point position
    );

    void onPointerDown(
        Point position
    );

    void onPointerUp(
        Point position
    );
}