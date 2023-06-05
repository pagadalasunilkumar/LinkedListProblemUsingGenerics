using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblemUsingGenerics
{
    internal class UC10OrderedList
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

        public static void Delete<T>(Node<T> head, T key)
        {
            Node<T> currentNode = head;
            Node<T> previousNode = null;

            // Traverse the linked list to find the node to delete
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(key))
                {
                    // Node found, update the pointers to remove the node
                    if (previousNode != null)
                    {
                        previousNode.Next = currentNode.Next;
                    }
                    else
                    {
                        // Special case: Deleting the head node
                        head = currentNode.Next;
                    }
                    break;
                }

                // Move to the next node
                previousNode = currentNode;
                currentNode = currentNode.Next;
            }
        }

        public static int Size<T>(Node<T> head)
        {
            int count = 0;
            Node<T> currentNode = head;

            while (currentNode != null)
            {
                count++;
                currentNode = currentNode.Next;
            }

            return count;
        }

        public static void Main(string[] args)
        {
            // Create nodes with values 56, 30, 40, and 70
            Node<int> node1 = new Node<int>(56);
            Node<int> node2 = new Node<int>(30);
            Node<int> node3 = new Node<int>(40);
            Node<int> node4 = new Node<int>(70);

            // Link the nodes to create the linked list
            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;

            // Search the linked list for the node with value 40
            Node<int> foundNode = Search(node1, 40);
            if (foundNode != null)
            {
                Console.WriteLine("Node with value 40 found.");

                // Delete the node with value 40
                Delete(node1, 40);
            }
            else
            {
                Console.WriteLine("Node with value 40 not found.");
            }

            // Get the size of the linked list
            int size = Size(node1);
            Console.WriteLine("Linked List size is: " + size);

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
