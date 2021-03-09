using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6Task1
{
    sealed class Group
    {

        List<Student> listOfStudents;
        public int NumberOfGroup { get; }

        public Group(int NumberOfGroup)
        {
            this.NumberOfGroup = NumberOfGroup;
            listOfStudents = new List<Student>();
        }
        public Student this[int index]
        {
            get { return listOfStudents[index]; }
            set { listOfStudents[index] = value; }
        }
        public void AddNewStudentToGroup(Student newStudentToAdd)
        {
            if (!listOfStudents.Contains(newStudentToAdd))
            {
                listOfStudents.Add(newStudentToAdd);
            }
        }
        public void RemoveStudentFromGroup(Student studentToRemove)
        {
            if (listOfStudents.Contains(studentToRemove))
            {
                listOfStudents.Remove(studentToRemove);
            }
        }
        public string ShowGroupInfo()
        {
            StringBuilder sb = new StringBuilder($"Number of group is {NumberOfGroup}\n");
            for (int i = 0; i < listOfStudents.Count; i++)
            {
                sb.Append($"{listOfStudents[i].ShowStudentInfo()}\n");
            }
            return sb.ToString();
        }
    }
}
