using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblemUsingGenerics
{
    internal class UC_6DeleteLastElement
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

        public static void Main(string[] args)
        {
            // Create nodes with values 56, 30, and 70
            Node<int> node1 = new Node<int>(56);
            Node<int> node2 = new Node<int>(30);
            Node<int> node3 = new Node<int>(70);

            // Link the nodes to create the linked list
            node1.Next = node2;
            node2.Next = node3;

            // Delete the last element (tail) and update the tail
            Node<int> currentNode = node1;
            Node<int> tail = null;
            while (currentNode.Next != null)
            {
                tail = currentNode;
                currentNode = currentNode.Next;
            }

            // Set the new tail's Next to null to remove the last element
            if (tail != null)
            {
                tail.Next = null;
            }

            // Traverse the linked list and print the values starting from the head
            currentNode = node1;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }
    }
}
