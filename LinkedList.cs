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
        /// UC1
        /// </summary>
        /// <param name="newData"></param>
        public void AppendLast(int newData)
        {
            ///Creating new node to insert at last
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
        /// UC1
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Inserting in the begining 
        /// UC2
        /// </summary>
        /// <param name="newData"></param>
        public void AppendFirst(int newData)
        {
            ///Creating a new node
            ///if node is empty initailising the new node to head     
            Node newNode = new Node(newData);
            if (head == null)
            {
                this.head = newNode;
            }
            else
            {
                newNode.next = this.head;
                this.head = newNode;
            }
        }
        /// <summary>
        /// displaying the Linked List
        /// </summary>
        public void Display()
        {
            ///we initialise this temp so that head remains the same
            Node temp = this.head;
            if (temp.next == null)
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }
            else
            {
                Console.WriteLine("The values in LinkedList is ");
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }

        }
    }
}