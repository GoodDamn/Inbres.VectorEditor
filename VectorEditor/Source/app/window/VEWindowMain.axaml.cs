using System;
using Avalonia;
using Avalonia.Controls;
using core;
using core.controls;
using core.render;
using core.viewModels;

namespace VectorEditor;

public partial class VEWindowMain
: Window {
    public VEWindowMain()
    {
        VEViewModelEditor viewModel = new();
        Content = new VEControlVectorEditor {
            skeletonRender = viewModel.skeletonRender
        };

        for (int i = 0; i < 16; i++) {
            viewModel.addPoint(
                new Point(i * 75, i * 75)
            );
        }
    }
}