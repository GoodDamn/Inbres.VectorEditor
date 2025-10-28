using System;
using Avalonia.Controls;

namespace VectorEditor;

public partial class VEWindowMain
: Window {
    public VEWindowMain()
    {
        this.Content = new Label {
            Content = "bbbb",
            FontSize = 72
        };
    }
}