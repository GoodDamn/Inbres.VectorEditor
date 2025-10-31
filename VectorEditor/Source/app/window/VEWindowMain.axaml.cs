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
    public VEWindowMain() {
        VEViewModelEditorImpl viewModel = new();
        Content = new VEControlVectorEditor {
            skeletonRender = viewModel._skeletonRender,
            pointer = viewModel.pointer
        };
    }
}