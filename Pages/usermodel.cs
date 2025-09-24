using System.ComponentModel.DataAnnotations;

public class UserModel
{
    [Required(ErrorMessage = "El nombre es obligatorio")]
    public string? Nombre { get; set; }

    [Required(ErrorMessage = "El correo es obligatorio")]
    [EmailAddress(ErrorMessage = "Correo inválido")]
    public string? Correo { get; set; }

    [Required(ErrorMessage = "La contraseña es obligatoria")]
    [StringLength(100, MinimumLength = 6, ErrorMessage = "Debe tener al menos 6 caracteres")]
    public string? Contraseña { get; set; }
}