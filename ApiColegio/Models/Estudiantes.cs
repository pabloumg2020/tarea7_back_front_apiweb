using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiColegio.Models;
public class Estudiantes{
    [Key]
    public Int32 id_estudiante { get; set; }
    public Int32 carne { get; set; }
    public string? nombres { get; set; }
    public string? apellidos { get; set; }
    public string? direccion { get; set; }
    public string? telefono { get; set; }
    public string? correo_electronico { get; set; }
    public Int32 id_tipo_sangre { get; set; }
    public DateTime? fecha_nacimiento { get; set; }
}