using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6Task1
{
    sealed class Student
    {
        readonly Random random = new Random();
        public string Name { get; }
        public string Surname { get; }
        public uint?[] Marks { get; private set; }
        public Student(string Name, string Surname)
        {
            this.Name = Name;
            this.Surname = Surname;
            Marks = new uint?[10];
            RandomMarks(Marks);
        }
        public string ShowMarks()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Marks.Length; i++)
            {
                sb.Append(Marks[i] + " ");
            }
            return sb.ToString();
        }
        public double? ShowAverageMark()
        {
            double? result = 0;
            int amoutOfNotNullMarks = 0;
            for (int i = 0; i < Marks.Length; i++)
            {
                if (Marks[i] != null)
                {
                    amoutOfNotNullMarks++;
                    result += Marks[i];
                }
            }
            if (amoutOfNotNullMarks != 0)
                return result / amoutOfNotNullMarks;
            else return null;
        }
        public void AddToGroup(Group groupToAdd)
        {
            groupToAdd.AddNewStudentToGroup(this);
        }
        public void RemoveFromGroup(Group groupToRemoveFrom)
        {
            groupToRemoveFrom.RemoveStudentFromGroup(this);
        }
        public string ShowStudentInfo()
        {
            return string.Format($"student : {Name} {Surname}\t with marks: {ShowMarks()}\t and average score : {ShowAverageMark()}");
        }
        private void RandomMarks(uint?[] Marks)
        {
            for (int i = 0; i < Marks.Length; i++)
            {
                Marks[i] = (uint)random.Next(5, 11);
            }
        }

    }
}
