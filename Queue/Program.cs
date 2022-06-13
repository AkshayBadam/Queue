class Queue
{
    int []queue;
    int rear;
    int front;
    int size;
    int num;
    Queue() : this(10)
    {

    }
    Queue(int size)
    {
        this.size = size;
        queue = new int[size];
        rear = -1;
        front = 0;
    }
    bool isfull()
    {
        return rear == size - 1;
    }
    bool isEmpty()
    {
        return front == rear+1;
    }
    void insert(int num)
    {
        if (isfull())
        {
            Console.WriteLine("Queue is full");
        }
        else
        {
            rear++;
            queue[rear] = num;
            Console.WriteLine(queue[rear]);
        }
    }
        void delete()
        {
        if (isEmpty())
        {
            Console.WriteLine("Queue is Empty");
        }
            else
            {
                Console.WriteLine(queue[front]);
                front++;
        }
        }
    void printQueue()
    {
        if (isEmpty())
        {
            Console.WriteLine("Queue is Empty");
        }
        else
        {
            for (int i = front; i <= rear; i++)
            {
                Console.WriteLine(queue[i]);
            }
        }
    }
    public static void Main()
    {
        Queue q = new Queue();
        q.insert(10);
        q.insert(50);
        q.insert(100);
        q.insert(10);
        q.insert(50);
        q.delete();
        q.delete();
        q.printQueue();
    }

}