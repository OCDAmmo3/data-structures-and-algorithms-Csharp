using System.Text;

namespace DataStructures.StacksAndQueues
{
    public class Queue<T>
    {
        public class QueueNode
        {
            public QueueNode(T value)
            {
                Value = value;
            }

            public T Value { get; set; }

            public QueueNode Next { get; set; }
            public QueueNode Prev { get; set; }
        }

        public QueueNode Front { get; set; }
        public QueueNode Back { get; set; }

        public int Length = 0;

        public void Enqueue(T value)
        {
            QueueNode newNode = new QueueNode(value);
            if (Front == null)
            {
                Front = newNode;
                Back = newNode;
                Length++;
            }
            else
            {
                newNode.Prev = Back;
                Back.Next = newNode;
                Back = newNode;
                Length++;
            }
        }

        public object Dequeue()
        {
            if (Front == null)
                throw new EmptyQueueException("dequeue");

            else if (Length == 1)
            {
                QueueNode temp = Front;
                Front = null;
                Back = null;
                Length--;
                return temp.Value;
            }
            else
            {
                QueueNode temp = Front;
                Front = Front.Next;
                Front.Prev = null;
                Length--;
                return temp.Value;
            }
        }

        public object Peek()
        {
            if (Front == null)
                throw new EmptyQueueException("peek");
            return Front.Value;
        }

        public bool IsEmpty()
        {
            return Front == null;
        }

        public override string ToString()
        {
            QueueNode curr = Front;
            string str = "";
            if (Front != null)
            {
                while (curr.Next != null)
                {
                    str = $"{str}{curr.Value}, ";
                    curr = curr.Next;
                }
                str = $"{str}{curr.Value}";
            }
            else
                str = "null";

            return str;
        }
    }
}
