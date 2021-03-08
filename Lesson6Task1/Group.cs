using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6Task1
{
    sealed class Group
    {
        Student[] listOfStudents;
        public int NumberOfGroup { get; }
        public Group(int NumberOfGroup, params Student[] students)
        {
            this.NumberOfGroup = NumberOfGroup;
            listOfStudents = students;
        }
        public void MoveStudentToAnotherGroup(Student student, Group groupToMove)
        {
            groupToMove.AddNewStudentToGroup(RemoveStudentFromGroup(student));
        }
        public Student this[int index] 
        {
            get { return listOfStudents[index]; }
            set { listOfStudents[index] = value; }
        }
        private void AddNewStudentToGroup(Student newStudentToAdd) 
        {
            Array.Resize<Student>(ref listOfStudents, listOfStudents.Length + 1);
            listOfStudents[listOfStudents.GetUpperBound(0)] = newStudentToAdd;
        }
        private Student RemoveStudentFromGroup(Student studentToRemove) 
        {
            Student[] newListOfStudents = new Student[listOfStudents.Length -1];
            int indexofStudentToRemove = Array.IndexOf(listOfStudents, studentToRemove);
            Array.Copy(listOfStudents, 0, newListOfStudents, 0, indexofStudentToRemove );
            Array.Copy(listOfStudents, indexofStudentToRemove+1, newListOfStudents, indexofStudentToRemove,listOfStudents.Length - indexofStudentToRemove-1);
            Array.Resize<Student>(ref listOfStudents, newListOfStudents.Length);
            listOfStudents = newListOfStudents;
            return studentToRemove;
        }
        public string ShowGroupInfo() 
        {
            string result = $"Number of group is {NumberOfGroup}\n";
            for (int i = 0; i < listOfStudents.Length; i++)
            {
               result += $"{listOfStudents[i].ShowStudentInfo()}\n";
            }
            return result;
        }
    }
}
