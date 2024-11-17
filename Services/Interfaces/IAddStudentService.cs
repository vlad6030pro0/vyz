using System;

namespace vyz.Services.Interfaces;

public interface IAddStudentService
{
    void AddStudent(string name, string surname, string group, string email);
    void AddStudent(string name, string secondname, string surname, string group, string email);
}
