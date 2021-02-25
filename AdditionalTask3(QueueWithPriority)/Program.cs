using System;

namespace AdditionalTask3_QueueWithPriority_
{
    class Program
    {
        static void Main()
        {
            QueueWithPriority<Person> queue1 = new QueueWithPriority<Person>();//Очередь закрытая типом Person

            Person human1 = new Person(2, "Old man");
            Person human2 = new Person(1, "Invalid");
            Person human3 = new Person(0, "Screaming rich woman");
            Person human4 = new Person(2, "Old woman");
            Person human5 = new Person(2, "Second old man");
            Person human6 = new Person(3, "Boy");
            Person human7 = new Person(4, "Poorman");
            Person human8 = new Person(3, "Girl");

            queue1.Enqueue(human1);
            queue1.Enqueue(human2);
            queue1.Enqueue(human3);
            queue1.Enqueue(human4);
            queue1.Enqueue(human5);
            queue1.Enqueue(human6);
            queue1.Enqueue(human7);
            queue1.Enqueue(human8);

            foreach (Person person in queue1)
            {
                Console.WriteLine(person.KindOfType + "   and (His/her) priority is " + person.PriorityLevel);
            }

            Console.WriteLine($"Length of queue is - {queue1.Length}");
            Console.WriteLine();
            Console.WriteLine("First element dequeue :");
            Person person1Duqueued = queue1.Dequeue();
            Console.WriteLine(person1Duqueued.KindOfType);
            Console.WriteLine($"queue length after dequeue is - {queue1.Length}");
            Console.WriteLine();
            Console.WriteLine("Second element dequeue :");
            Person person2Dequeued = queue1.Dequeue();
            Console.WriteLine(person2Dequeued.KindOfType);
            Console.WriteLine($"queue length after dequeue is - {queue1.Length}");
            Console.WriteLine();
            Console.WriteLine(queue1.Peek);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            QueueWithPriority<Fruit> queue2 = new QueueWithPriority<Fruit>();//Очередь параметризированная типом Fruit

            Fruit fruit1 = new Fruit(2, "Apple");
            Fruit fruit2 = new Fruit(1, "Orange");
            Fruit fruit3 = new Fruit(0, "Watermelon");
            Fruit fruit4 = new Fruit(2, "Peach");
            Fruit fruit5 = new Fruit(2, "Pear");
            Fruit fruit6 = new Fruit(0, "Melon");
            Fruit fruit7 = new Fruit(4, "Grapefruit");
            Fruit fruit8 = new Fruit(3, "Grape");

            queue2.Enqueue(fruit1);
            queue2.Enqueue(fruit2);
            queue2.Enqueue(fruit3);
            queue2.Enqueue(fruit4);
            queue2.Enqueue(fruit5);
            queue2.Enqueue(fruit6);
            queue2.Enqueue(fruit7);
            queue2.Enqueue(fruit8);

            foreach (Fruit fruit in queue2)
            {
                Console.WriteLine(fruit.KindOfType + "   and  priority is " + fruit.PriorityLevel);
            }

            Console.WriteLine($"Length of queue is - {queue2.Length}");
            Console.WriteLine();
            Console.WriteLine("First element dequeue :");
            Fruit fruit1Duqueued = queue2.Dequeue();
            Console.WriteLine(fruit1Duqueued.KindOfType);
            Console.WriteLine($"queue length after dequeue is - {queue2.Length}");
            Console.WriteLine();
            Console.WriteLine("Second element dequeue :");
            Fruit fruit2Dequeued = queue2.Dequeue();
            Console.WriteLine(fruit2Dequeued.KindOfType);
            Console.WriteLine($"queue length after dequeue is - {queue2.Length}");
            Console.WriteLine();
            Console.WriteLine(queue2.Peek);
        }
    }
}
