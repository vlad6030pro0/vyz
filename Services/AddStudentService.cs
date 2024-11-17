using System;
using vyz.Models;
using vyz.Services.Interfaces;

namespace vyz.Services;

public class AddStudentService : IAddStudentService
{
    StreamWriter writer = new StreamWriter("students.txt", true);
    public void AddStudent(string name, string surname, string group, string email)
    {
        Student student = new Student(){
            Name = name,
            Surname = surname,
            Group = group,
            Email = email
        };
        writer.WriteLine(student.FullName + " " + student.Group + " " + student.Email);
        writer.Close();
    }

    public void AddStudent(string name, string secondname, string surname, string group, string email)
    {
        Student student = new Student(){
            Name = name,
            SecondName = secondname,
            Surname = surname,
            Group = group,
            Email = email
        };
        writer.WriteLine(student.FullName + " " + student.Group + " " + student.Email);
        writer.Close();
    }
}
