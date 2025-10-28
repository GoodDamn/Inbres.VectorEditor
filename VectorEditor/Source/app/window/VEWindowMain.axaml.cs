using System;
using Avalonia.Controls;
using core.controls;

namespace VectorEditor;

public partial class VEWindowMain
: Window {
    public VEWindowMain() {
        Content = new VEControlVectorEditor();
    }
}