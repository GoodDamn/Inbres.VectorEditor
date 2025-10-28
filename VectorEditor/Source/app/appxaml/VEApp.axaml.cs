using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

namespace VectorEditor;

public partial class VEApp
: Application {
    
    public override void Initialize() {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted() {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new VEWindowMain {
                Title = "Vector Editor"
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}