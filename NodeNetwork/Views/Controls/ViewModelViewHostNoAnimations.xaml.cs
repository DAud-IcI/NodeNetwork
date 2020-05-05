using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;

namespace NodeNetwork.Views.Controls
{
    public partial class ViewModelViewHostNoAnimations : ViewModelViewHost
    {
        public ViewModelViewHostNoAnimations()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
