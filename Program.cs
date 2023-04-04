using System;

namespace OOP_HA_2
{

    class FifoQueue<T>
    {
        private Queue<T> queue = new Queue<T>(); //<T> використовується для створення загального generic класу (може працювати з будь-якими типами даних)

        public void Enqueue(T item) //додає предмет до кінця черги 
        {
            queue.Enqueue(item);
        }

        public T Dequeue() //прибирає і повертає предмет на початку черги
        {
            return queue.Dequeue();
        }

        public T Peek() //повертає предмет на початку черги, не видаляючи його
        {
            return queue.Peek();
        }

        public int Count //рахує кількість предметів у черзі
        {
            get { return queue.Count; }
        }

        public bool IsEmpty //перевіряє чи є черга пустою
        {
            get { return queue.Count == 0; }
        }
    }
    internal class Program
    {
        static void Main(string[] args) //приклад роботи класу
        {
            FifoQueue<string> queue = new FifoQueue<string>(); //створюємо новий екземпляр цього класу
            queue.Enqueue("apple");
            queue.Enqueue("banana");
            queue.Enqueue("orange");
            Console.WriteLine(queue.Dequeue()); // вивід: apple
            Console.WriteLine(queue.Peek()); // вивід: banana
            Console.WriteLine(queue.Count); // вивід: 2 (яблуко прибрали)
            Console.WriteLine(queue.IsEmpty); // вивід: False

        }
    }
}