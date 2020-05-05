using Avalonia;
using Avalonia.Controls;
using NodeNetwork.ViewModels;
using ReactiveUI;

namespace NodeNetwork.Views
{
    public class NodeEndpointEditorView : Control, IViewFor<NodeEndpointEditorViewModel>
    {
        #region ViewModel
        public static readonly AvaloniaProperty ViewModelProperty = AvaloniaProperty.Register(nameof(ViewModel),
            typeof(NodeEndpointEditorViewModel), typeof(NodeEndpointEditorView), new PropertyMetadata(default));

        public NodeEndpointEditorViewModel ViewModel
        {
            get => (NodeEndpointEditorViewModel)GetValue(ViewModelProperty);
            set => SetValue(ViewModelProperty, value);
        }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (NodeEndpointEditorViewModel)value;
        }
        #endregion

        public NodeEndpointEditorView()
        {
            DefaultStyleKey = typeof(NodeEndpointEditorView);
        }
    }
}
