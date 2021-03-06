
namespace DSBST.Containers
{
    public class Queue<T>
    {
        private LinkedList<T> elements;
        public int Count { get => elements.Count; }
        public LinkedList<T> Elements { get => elements; }

        public Queue()
        {
            elements = new LinkedList<T>();
        }

        public void Clear()
        {
            elements = new LinkedList<T>();
        }

        public T Dequeue()
        {
            Node<T> toRemove = elements.First;
            elements.RemoveFirst();
            return toRemove.item;
        }

        public void Enqueue(T item)
        {
            elements.AddLast(item);
        }

        public T Peek()
        {
            return elements.First.item;
        }

        public int IndexOf(T item) => elements.IndexOf(item);

        public override string ToString()
        {
            return elements.ToString();
        }
    }
}