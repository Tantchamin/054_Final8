using System;
using System.Collections.Generic;

namespace _054_Final8
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int check = 0;
            int number = int.Parse(Console.ReadLine());
            Queue waiting = new Queue();
            char[] production = new char[5];

            while(counter != number)
            {
                int waitingCounter = 0;  
                char piece = char.Parse(Console.ReadLine());
                Node pieceNode = new Node(piece);

                for(int i =0; i< production.Length; i++)
                {
                    if (piece == production[i])
                    {
                        waitingCounter++;
                    }           
                }

                if (waitingCounter == 0)
                {
                    production[check] = piece;
                    check++;
                }
                else
                {
                    waiting.Push(pieceNode);
                }

                if(check == 5)
                {
                    for(int i = 0; i < production.Length; i++)
                    {
                        production[i] = '0';
                    }
                    check = 0;
                    counter++;
                }

            }

            Console.WriteLine("Finish: {0} pieces", counter);

        }

    }

    class Node
    {
        public char Value;
        public Node Next;

        public Node(char value)
        {
            this.Value = value;
        }
    }

    class Queue
    {
        public Node Root;

        public void Push(Node node)
        {
            if (Root == null)
            {
                Root = node;
            }
            else
            {
                Node ptr = Root;
                while (ptr.Next != null)
                {
                    ptr = ptr.Next;
                }
                ptr.Next = node;
            }
        }

        public Node Pop()
        {
            if (Root == null)
            {
                return null;
            }
            Node node = Root;
            Root = Root.Next;
            node.Next = null;
            return node;
        }

    }

}
