using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblemUsingGenerics
{
    internal class UC_8InsertingAn_Element
    {
        public class Node<T>
        {
            public T Value { get; set; }
            public Node<T> Next { get; set; }

            public Node(T value)
            {
                Value = value;
                Next = null;
            }
        }

        public static Node<T> Search<T>(Node<T> head, T key)
        {
            Node<T> currentNode = head;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(key))
                {
                    return currentNode;
                }
                currentNode = currentNode.Next;
            }
            return null;
        }

        public static void InsertAfter<T>(Node<T> node, T value)
        {
            Node<T> newNode = new Node<T>(value);
            newNode.Next = node.Next;
            node.Next = newNode;
        }

        public static void Main(string[] args)
        {
            // Create nodes with values 56, 30, and 70
            Node<int> node1 = new Node<int>(56);
            Node<int> node2 = new Node<int>(30);
            Node<int> node3 = new Node<int>(70);

            // Link the nodes to create the linked list
            node1.Next = node2;
            node2.Next = node3;

            // Search the linked list for the node with value 30
            Node<int> foundNode = Search(node1, 30);
            if (foundNode != null)
            {
                Console.WriteLine("Node with value 30 found.");

                // Insert 40 after the node with value 30
                InsertAfter(foundNode, 40);
            }
            else
            {
                Console.WriteLine("Node with value 30 not found.");
            }

            // Traverse the linked list and print the values
            Node<int> currentNode = node1;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }
    }
}
