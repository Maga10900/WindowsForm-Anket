namespace WinFormsApp_Task_3_Anket;

public class User
{
    public string Name{ get; set; }
    public string Surname{ get; set; }
    public string Email { get; set; }
    public string Telefon{ get; set; }
    public DateTime Dogun { get; set; }

    public User()
    {
        
    }
    public User(string name, string surname, string email, string telefon, DateTime dogun)
    {
        Name = name;
        Surname = surname;
        Email = email;
        Telefon = telefon;
        Dogun = dogun;
    }

    public override string ToString()
    {
        return $"{Name}";
    }
}

