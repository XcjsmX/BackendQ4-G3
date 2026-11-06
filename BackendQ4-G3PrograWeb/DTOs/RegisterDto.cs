namespace BackendQ4_G3PrograWeb.DTOs;
/**
 *DTO significa  Data tansfer Object
 * Es una clase que describe solo los datos que el FE debe enviar 
*/


public class RegisterDto
{
    public string FullName { get; set; }= string.Empty;
     public string Email { get; set; }= string.Empty;
    public string Password { get; set; } = string.Empty;

}