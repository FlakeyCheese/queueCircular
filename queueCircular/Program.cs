using System;

namespace queueCircular
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] circleQueue = new int[10]; //an array with space for 10 items
            int front = -1;
            int rear = 0;
            dequeue(circleQueue, ref front, rear);
            enqueue(circleQueue, ref rear,ref front, 12);
            enqueue(circleQueue, ref rear, ref front, 13);
            enqueue(circleQueue, ref rear, ref front, 14);
            enqueue(circleQueue, ref rear, ref front, 15);
            printQueue(circleQueue, front, rear);
            Console.WriteLine(dequeue(circleQueue, ref front, rear));//remove first item and print it out. 12!
            Console.WriteLine();//force a gap
            printQueue(circleQueue, front, rear);
            dequeue(circleQueue, ref front, rear);
            dequeue(circleQueue, ref front, rear);
            printQueue(circleQueue, front, rear);
            dequeue(circleQueue, ref front, rear);//remove the last item
            Console.WriteLine(dequeue(circleQueue, ref front, rear));// queue's empty

            enqueue(circleQueue, ref rear, ref front, 1);
            enqueue(circleQueue, ref rear, ref front, 2);
            enqueue(circleQueue, ref rear, ref front, 3);
            enqueue(circleQueue, ref rear, ref front, 4);
            enqueue(circleQueue, ref rear, ref front, 5);
            enqueue(circleQueue, ref rear, ref front, 6);
            enqueue(circleQueue, ref rear, ref front, 7);
            enqueue(circleQueue, ref rear, ref front, 8);
            enqueue(circleQueue, ref rear, ref front, 9);
            enqueue(circleQueue, ref rear,  ref front, 10);
            enqueue(circleQueue, ref rear, ref front, 11);
            printQueue(circleQueue, front, rear);
        }
        public static void printQueue(int[] queue, int front, int rear)
        {
            Console.WriteLine("Here is the queue");
            if (front <= rear)
            {
                for (int i = front; i < rear; i++)
                { Console.WriteLine(queue[i]); }
                Console.WriteLine();
            }
            else
            { for (int i = front; i < 9; i++)
                { Console.WriteLine(queue[i]); }
            for (int i =0; i<rear;i++)
                { Console.WriteLine(queue[i]);}
                        }
        }

        public static bool isEmpty(int front, int rear)
        {
            if (front==-1 || front==rear)
            { return true; }
            else
            { return false; }
        }
        public static bool isFull(int rear, int front)
        {
            if ((rear+1)% 10 == front)
            { return true; }
            else
            { return false; }
        }
        public static void enqueue(int[] queue, ref int rear,ref int front, int data)
        {
            if (isFull(rear, front ))
            { Console.WriteLine("The queue is full"); }
            else
            {   if (front == -1) { front = 0; }
                queue[rear] = data;
                rear++;
                rear = rear % 10;
                
            }
        }
        public static int dequeue(int[] queue, ref int front, int rear)
        {
            if (isEmpty(front, rear))
            {
                Console.WriteLine("There is nothing to dequeue - the queue is empty");
                return -1;
            }
            else
            {
                int temp = queue[front];
                front++;
                return temp;
            }
        }

    }
}
