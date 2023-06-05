using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblemUsingGenerics
{
    internal class UC_2Adding
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
            // Create nodes with values 70, 30, and 56
            Node<int> node1 = new Node<int>(70);
            Node<int> node2 = new Node<int>(30);
            Node<int> node3 = new Node<int>(56);

            // Link the nodes to create the linked list
            node1.Next = node2;
            node2.Next = node3;

            // Traverse the linked list and print the values
            Node<int> currentNode = node3;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }
    }
}
