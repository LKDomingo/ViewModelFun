namespace ViewModelFun.Models;
#pragma warning disable CS8618

public class User
{
    public string FirstName;
    public string LastName;

    public User(string first, string last) {
        FirstName = first;
        LastName = last;
    }

    public User(string first) 
    {
        FirstName = first;
    }
}