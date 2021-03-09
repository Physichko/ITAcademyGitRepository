using System;

namespace Lesson6Task1
{
    class Program
    {
        static void Main()
        {
            Student student0 = new Student("Alieksei", "Valkovich");
            Student student1 = new Student("Viktor", "Popov  ");
            Student student2 = new Student("Genady", "Gorin  ");
            Student student3 = new Student("Shapka", "Ushanka");
            Student student4 = new Student("Bus", "Trolley   ");
            Student student5 = new Student("Aleksandr", "Shevchuk");
            Student student6 = new Student("Herbert", "Shildt    ");
            Student student7 = new Student("Jeffrey", "Richter    ");
            Student student8 = new Student("Sam", "Fisher    ");
            Student student9 = new Student("Jack", "Sparrow    ");

            Group aspDotNetCoreDevelopers = new Group(220116);
            Group unityDevelopers = new Group(220117);

            student5.AddToGroup(unityDevelopers);
            student6.AddToGroup(unityDevelopers);
            student7.AddToGroup(unityDevelopers);
            student8.AddToGroup(unityDevelopers);
            student9.AddToGroup(unityDevelopers);
            student0.AddToGroup(aspDotNetCoreDevelopers);
            student1.AddToGroup(aspDotNetCoreDevelopers);
            student2.AddToGroup(aspDotNetCoreDevelopers);
            student3.AddToGroup(aspDotNetCoreDevelopers);
            student4.AddToGroup(aspDotNetCoreDevelopers);

            student1.RemoveFromGroup(aspDotNetCoreDevelopers);
            student1.AddToGroup(unityDevelopers);
            student1.AddToGroup(aspDotNetCoreDevelopers);

            aspDotNetCoreDevelopers.AddNewStudentToGroup(student6);
            aspDotNetCoreDevelopers.AddNewStudentToGroup(student5);

            unityDevelopers.RemoveStudentFromGroup(student9);
            unityDevelopers.RemoveStudentFromGroup(student8);

            student8.AddToGroup(aspDotNetCoreDevelopers);
            student9.AddToGroup(aspDotNetCoreDevelopers);


            Console.WriteLine(new string('-', 120));
            Console.WriteLine(aspDotNetCoreDevelopers.ShowGroupInfo());
            Console.WriteLine(new string('-', 120));
            Console.WriteLine(unityDevelopers.ShowGroupInfo());
            Console.WriteLine(new string('-', 120));
        }
    }
}
