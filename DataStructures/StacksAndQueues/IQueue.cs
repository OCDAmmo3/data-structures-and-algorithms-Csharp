namespace DataStructures.StacksAndQueues
{
    public interface IQueue
    {
        object Dequeue();
        void Enqueue(object value);
    }
}