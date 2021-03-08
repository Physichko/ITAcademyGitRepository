using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6Task1
{
    static class ExtensionMethod
    {
        public static void MoveToAnotherGroup(this Student student, Group group)
        {
            group.MoveStudentToAnotherGroup(student, group);
        }
    }
}
