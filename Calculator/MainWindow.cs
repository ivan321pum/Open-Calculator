using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace GitHubRepos
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            Initialize();
        }
        private void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}