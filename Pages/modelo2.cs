using System.ComponentModel.DataAnnotations;

public class EventModel
{
    [Required(ErrorMessage = "El título es obligatorio")]
    public string? Titulo { get; set; }

    [Required(ErrorMessage = "La fecha es obligatoria")]
    public DateTime? Fecha { get; set; }

    [Required(ErrorMessage = "La ubicación es obligatoria")]
    public string? Ubicacion { get; set; }

    [StringLength(300, ErrorMessage = "La descripción no puede superar los 300 caracteres")]
    public string? Descripcion { get; set; }
}