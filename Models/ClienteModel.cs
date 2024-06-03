namespace Api.Models
{
     public class ClienteModel
 {
     public int Id { get; set; }
     public string Nombre { get; set; } = null!;
     public string Direccion { get; set; } = null!; 
     public string Telefono { get; set; } = null!;
     public string Identificador { get; set; } = null!;
     public DateTime FechaCreacion { get; set; } = DateTime.Now;
     public string CorreoElectronico { get; set; } = null!;

 }
}