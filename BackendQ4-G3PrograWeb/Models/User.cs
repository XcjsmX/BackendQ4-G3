namespace BackendQ4_G3PrograWeb.Models;

public class User
{
    public string ID { get; set;  } = string.Empty;
    
    public string FulName { get; set; } = string.Empty;
   
    public string Email { get; set; } = string.Empty;
    
    public string Password { get; set; } = string.Empty;
    
    public DateTime Created { get; set; } = DateTime.UtcNow;
}