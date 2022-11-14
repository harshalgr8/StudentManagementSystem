using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementSystem.Students
{
    internal interface IStudent
    {
        internal void GetStudents();
        internal void SaveStudent();
       
        internal void DeleteStudent();
    }
}
