using Avalonia;

namespace Avalonia.Gif.Demo
{
    public static class Program
    {
        public static void Main(string[] args) => BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .With(new AvaloniaNativePlatformOptions()
                {
                    RenderingMode = [AvaloniaNativeRenderingMode.Metal, AvaloniaNativeRenderingMode.Software]
                })
                .UsePlatformDetect()
                .LogToTrace();
    }
}