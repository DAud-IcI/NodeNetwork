using Avalonia.Controls.Primitives;
using Avalonia.Markup.Xaml;

namespace NodeNetwork.Views.Controls
{
    public partial class ArrowToggleButton : ToggleButton
    {
        public ArrowToggleButton()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
