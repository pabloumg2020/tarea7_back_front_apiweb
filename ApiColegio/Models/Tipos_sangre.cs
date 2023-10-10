using System.ComponentModel.DataAnnotations;

namespace ApiColegio.Models;
public class Tipos_sangre{
    [Key]
    public Int32 id_tipo_sangre { get; set; }
    public string? sangre { get; set; }
}