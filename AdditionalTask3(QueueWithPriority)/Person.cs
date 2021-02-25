using System;
using System.Collections.Generic;
using System.Text;

namespace AdditionalTask3_QueueWithPriority_
{
    sealed class Person : IPrioritySorted
    {
        readonly int priorityLevel;
        readonly string kindOfPerson;
        public Person(int priorityLevel, string kindOfPerson)
        {
            this.priorityLevel = priorityLevel;
            this.kindOfPerson = kindOfPerson;
        }
        public Person()
        {

        }
        public int PriorityLevel
        {
            get { return priorityLevel; }
        }
        public string KindOfType
        {
            get { return kindOfPerson; }
        }
    }
}
