namespace Anketa_2.Models;

public class Person
{
    string _name;
    string _surname;
    string _email;
    string _phone;
    ushort _birthYear;
    public string Name
    {
        get => _name;
        set
        {
            if (value.Length > 3)
                _name = value;
            else
                throw new ArgumentException("Name minimum symbols count = 3");
        }
    }
    public string Surname
    {
        get => _surname;
        set
        {
            if (value.Length > 5)
                _surname = value;
            else
                throw new ArgumentException("Surname minimum symbols count = 5");
        }
    }
    public string Email
    {
        get => _email;
        set
        {
            if (value.Length > 11 && value.Contains("@gmail.com"))
                _email = value;
            else
                throw new ArgumentException("Email will be find '@gmail.com' and minimum symbols count = 11");
        }
    }
    public string Phone
    {
        get => _phone;
        set
        {
            if (value.Length == 14 && value.StartsWith("+994"))
                _phone = value;
            else
                throw new ArgumentException("Phone will be start '+994' and symbols count = 11");
        }
    }
    public ushort BirthYear
    {
        get => _birthYear;
        set
        {
            if (_birthYear <= 2024)
                _birthYear = value;
            else
                throw new ArgumentException("The year must be valid");
        }
    }

    public Person() { }
    public Person(string name, string surname, string email, string phone, ushort birthYear)
    {
        Name = name;
        Surname = surname;
        Email = email;
        Phone = phone;
        BirthYear = birthYear;
    }

    public override string ToString()
    {
        string result = $"Name: {Name}\nSurname: {Surname}\nEmail: {Email}\nPhone: {Phone}\nBirthDay: {BirthYear}";
        return result;
    }
}
