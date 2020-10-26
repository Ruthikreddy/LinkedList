using Microsoft.VisualBasic;
using System;

namespace DataStructures_LinkedList
{   /// <summary>
    /// Creating LinkedList
    /// </summary>
    class LinkedList
    {
        public Node head;
        /// <summary>
        /// Inserting the node at Last
        /// </summary>
        /// <param name="newData"></param>
        public void AppendLast(int newData)
        { 
            Node newNode = new Node(newData);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = newNode;
            }
        }
        /// <summary>
        /// Identifying the last Node
        /// </summary>
        public Node GetLastNode()
        {
            /// initialising temp to head 
            /// iterating till the temp is pointing towards null to get last node
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

    }
}
