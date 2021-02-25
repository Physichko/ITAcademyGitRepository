using System;
using System.Collections.Generic;
using System.Text;

namespace AdditionalTask3_QueueWithPriority_
{
    interface IPrioritySorted
    {
        int PriorityLevel { get; }
        string KindOfType { get; }
    }
}
