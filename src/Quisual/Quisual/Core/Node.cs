using System.Drawing;

namespace Quisual.Core;

internal class Node
{
    public NodeType NodeType { get; set; }
    public Point Position { get; set; }
}

internal enum NodeType
{
    Intermediate,
    Finite
}
