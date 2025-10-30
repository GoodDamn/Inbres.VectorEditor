using Avalonia.Input;

namespace core.interfaces;

public interface VEIPointerable {
    void onPointerMove(
        PointerEventArgs e
    );

    void onPointerDown(
        PointerPressedEventArgs e
    );

    void onPointerUp(
        PointerReleasedEventArgs e
    );
}