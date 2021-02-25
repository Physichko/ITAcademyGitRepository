using System;
using System.Collections.Generic;
using System.Text;

namespace AdditionalTask3_QueueWithPriority_
{
    sealed class Fruit : IPrioritySorted
    {
        readonly int priorityLevel;
        readonly string kindOfFruit;
        public Fruit(int priorityLevel, string kindOfFruit)
        {
            this.priorityLevel = priorityLevel;
            this.kindOfFruit = kindOfFruit;
        }
        public Fruit()
        {

        }
        public int PriorityLevel
        {
            get { return priorityLevel; }
        }
        public string KindOfType
        {
            get { return kindOfFruit; }
        }
    }
}
