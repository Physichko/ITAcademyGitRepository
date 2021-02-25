using System;
using System.Collections;
using System.Text;

namespace AdditionalTask3_QueueWithPriority_
{
    sealed class QueueWithPriority<T>: IEnumerable where T : IPrioritySorted, new()
    {
        T[] typeOfTArray;
        public QueueWithPriority()
        {
            typeOfTArray = new T[0];
        }
        public void Enqueue(T typeElement)
        {
            T[] bufferArr;
            bufferArr = this.typeOfTArray;
            this.typeOfTArray = new T[bufferArr.Length + 1];

            if (typeOfTArray.Length == 1)
                typeOfTArray[0] = typeElement;

            if (typeOfTArray.Length >= 2)
            {
                for (int i = 0; i < bufferArr.Length; i++)
                {
                    typeOfTArray[i] = bufferArr[i];
                }
                typeOfTArray[typeOfTArray.Length - 1] = typeElement;
            }
            SortByPriority();
        }
        public T Dequeue()
        {
            T buffElement = typeOfTArray[0];
            T[] buffArrayOfElements = typeOfTArray;
            this.typeOfTArray = new T[typeOfTArray.Length - 1];

            for (int i = 0; i < typeOfTArray.Length; i++)
            {
                typeOfTArray[i] = buffArrayOfElements[i + 1];
            }
            return buffElement;
        }

        public int Length
        {
            get { return typeOfTArray.Length; }
        }

        public String Peek
        {
            get { return String.Format($"Current peek is - {typeOfTArray[0].KindOfType} with priority level - {typeOfTArray[0].PriorityLevel}"); }
        }

        private void SortByPriority()
        {
            T typeBuffer;
            for (int i = 0; i < typeOfTArray.Length; i++)
            {
                for (int j = 0; j < typeOfTArray.Length; j++)
                {
                    if (typeOfTArray[i].PriorityLevel < typeOfTArray[j].PriorityLevel)
                    {
                        typeBuffer = typeOfTArray[i];
                        typeOfTArray[i] = typeOfTArray[j];
                        typeOfTArray[j] = typeBuffer;
                    }
                }
            }
        }
        public IEnumerator GetEnumerator()
        {
            return typeOfTArray.GetEnumerator();
        }
       
    }
}
