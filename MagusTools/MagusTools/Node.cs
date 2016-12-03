using System;
using System.Drawing;
using System.Collections.Generic;

namespace MagusTools
{
    /// <summary>
    /// Base node class, can hold a constant value which is set on it's creation.
    /// Provides a single output value, no notifications.
    /// </summary>
    public class Node
    {
        protected int nodeValue;

        public Node() : this(0) { }
        public Node(int newValue)
        {
            nodeValue = newValue;

            Program.logger.Log(new object[] {
                Color.Blue, this.ToString() + " (" + this.GetHashCode().ToString() + ")",
                Color.Black, " object was created with value ",
                Color.Cyan, newValue.ToString() });        }

        public int GetValue()
        {
            return nodeValue;
        }
    }

    // TODO: Find a way to implement this instead of the EventedNode class
    public interface INodeEvents
    {
        void OnValueChanged(ValueChangedEventArgs e);

        event EventHandler<ValueChangedEventArgs> ValueChanged;
    }

    // TODO: Replace this with an Interface
    public abstract class EventedNode : Node
    {
        public EventedNode() { }

        protected void OnValueChanged(ValueChangedEventArgs e)
        {
            ValueChanged?.Invoke(this, e);
        }

        public event EventHandler<ValueChangedEventArgs> ValueChanged;
    }
    
    /// <summary>
    /// This node gets it's value from a single outside (non-node) source and passes it on.
    /// Provides a single output value and a notification event if that value changes.
    /// </summary>
    public class DataNode : EventedNode
    {
        public DataNode() { }

        public void SetValue(int newValue)
        {
            if (newValue != nodeValue)
            {
                nodeValue = newValue;

                Program.logger.Log(new object[] {
                    Color.Blue, this.ToString() + " (" + this.GetHashCode().ToString() + ")",
                    Color.Black, " changed it's value to ",
                    Color.Cyan, newValue.ToString() });

                // Initiate a Changed event
                ValueChangedEventArgs args = new ValueChangedEventArgs();
                args.NewValue = newValue;
                OnValueChanged(args);
            }
        }
    }

    /// <summary>
    /// This node gets it's values from other nodes, performs a specific operation
    /// on them then outputs the result.
    /// Provides a single output value, optional amount of input values
    /// and a notification event if anything changes.
    /// </summary>
    public class ModifierNode : EventedNode
    {
        // Collection of source nodes
        private HashSet<Node> prevNodes = new HashSet<Node>();
        // Determines the behaviour of this node
        private NodeType nodeType;

        public enum NodeType { Add, Subtract, Multiply, Divide }

        public ModifierNode(NodeType pNodeType)
        {
            nodeType = pNodeType;

            Program.logger.Log(new object[] {
                    Color.Blue, this.ToString() + " (" + this.GetHashCode().ToString() + ")",
                    Color.Black, " is now set to mode ",
                    Color.DarkGreen, Enum.GetName(typeof(NodeType), this.nodeType) });
        }

        // Sort out new sources and recalculate node value
        public void AddSource(Node newSource)
        {
            if (newSource != null && newSource != this)
            {
                Program.logger.Log(new object[] {
                    Color.Black, "New Node-source ",
                    Color.Blue, newSource.ToString() + " (" + newSource.GetHashCode().ToString() + ")",
                    Color.Black, " was added to ",
                    Color.Cyan, this.ToString() + " (" + this.GetHashCode().ToString() + ")" });

                if (newSource.GetType().IsSubclassOf(typeof(EventedNode)))
                    ((EventedNode)newSource).ValueChanged += SourceNode_ValueChanged;

                prevNodes.Add(newSource);

                CalculateOutput();
            }
        }

        // Remove and added source and recalculate node value
        public void RemoveSource(Node source)
        {
            if (source != null && source != this && prevNodes.Contains(source))
            {
                if (source.GetType() == typeof(EventedNode))
                    ((EventedNode)source).ValueChanged -= SourceNode_ValueChanged;

                prevNodes.Remove(source);

                CalculateOutput();
            }
        }

        // This method listens to the sources' changes
        private void SourceNode_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            CalculateOutput();
        }

        // Recalculate node value based on behavioural type
        private void CalculateOutput()
        {
            nodeValue = 0;
            bool first = true;

            foreach (var source in prevNodes)
            {
                // Always use the first source's value as a base
                // (important when subtracting and dividing)
                if (first && nodeValue == 0)
                {
                    nodeValue = source.GetValue();
                    first = false;
                }
                else
                    switch (nodeType)
                    {
                        case NodeType.Add:
                            nodeValue += source.GetValue();
                            break;
                        case NodeType.Subtract:
                            nodeValue -= source.GetValue();
                            break;
                        case NodeType.Multiply:
                            nodeValue *= source.GetValue();
                            break;
                        case NodeType.Divide:
                            nodeValue /= source.GetValue();
                            break;
                        default:
                            break;
                    }
            }

            // Initiate a Changed event
            ValueChangedEventArgs args = new ValueChangedEventArgs();
            args.NewValue = nodeValue;
            OnValueChanged(args);
        }
    }

    /// <summary>
    /// ValueChanged event arguments class
    /// </summary>
    public class ValueChangedEventArgs : EventArgs
    {
        public int NewValue { get; set; }
    }
}
