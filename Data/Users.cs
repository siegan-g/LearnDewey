//user poco for account registration/login 
namespace PROG7312_POE;
public class User
{
    public int ID { get; set; }
    public String Email { get; set; }
    public String Password { get; set; }
    public bool AccountConfirmed { get; set; }
    public DateTime DateCreated { get; set; }
}