using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_and_Queue.Classes
{

    /// <summary>
    /// Constructor for nodes. Instances of new nodes will use this constructor
    /// </summary>
    public class Node
    {
        public object Value { get; set; }
        public Node Next { get; set; }

        public Node(object value)
        {
            Value = value;
        }
    }
}
