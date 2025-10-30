using Avalonia;
using Avalonia.Media;
using core.interfaces;
using core.models;

namespace core;

public record VESkeleton2D {
    public readonly LinkedList<Point> points = new();
}