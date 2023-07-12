using Avalonia.Controls;

namespace Quisual.Controls;

public partial class NodeEditor : UserControl
{
    public NodeEditor()
    {
        InitializeComponent();

        Canvas.DoubleTapped += (sender, args) => AddNode();
    }

    private void AddNode()
    {
        var node = new Node
        {
            Height = 250,
            Width = 350,
            Margin = Avalonia.Thickness.Parse("30")
        };

        Canvas.Children.Add(node);
    }
}
