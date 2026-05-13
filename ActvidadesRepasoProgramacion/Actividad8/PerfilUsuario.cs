using System.Text.Json.Serialization;

namespace Actividad8;

public record PerfilUsuario
{
    public string Username { get; init; }//con init lo haces inmutable
    [JsonPropertyName("correo_electronico")]
    public string Email { get; set; }
    [JsonIgnore]
    public string TokenSesion { get; init; }
    
    
}