using System.ComponentModel.DataAnnotations;

namespace SampleBlazorApp.Data;

public class Mydata
{
    [Required]
    public string Name { get; set; }
    public string Password { get; set; }
    [EmailAddress]

    public string Mail { get; set; }

    public Mydata(string Name, string Password, string Mail)
    {
        this.Name = Name ?? "my name.";
        this.Password = Password ?? "";
        this.Mail = Mail ?? "";
    }

    public override string ToString()
    {
        return "[" + Name + " (" + Password + ") " + Mail + "]";
    }
}