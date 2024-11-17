using System;

namespace vyz.Models;

public class Student
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string? SecondName { get; set; }
    public string FullName { get; set; }
    public string Group { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public Student()
    {   
        if(SecondName != null){
            FullName = Surname + Name + SecondName;
        }else{
            FullName = Surname + Name;
        }
    }
}
