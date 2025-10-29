using System;
using Avalonia;
using Avalonia.Controls;
using core;
using core.controls;
using core.render;

namespace VectorEditor;

public partial class VEWindowMain
: Window {
    public VEWindowMain()
    {
        var skeleton = new VESkeleton2D();
        Content = new VEControlVectorEditor {
            skeletonRender = new VESkeleton2DRender(
                skeleton
            )
        };

        for (int i = 0; i < 16; i++) {
            skeleton.points.AddLast(
                new Point(i * 75, i * 75)
            );
        }
    }
}