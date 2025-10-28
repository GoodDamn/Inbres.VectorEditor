using Avalonia;
using Avalonia.Media;
using core.interfaces;

namespace core;

public record VESkeleton2D {
    public readonly LinkedList<Point> points = new();
}