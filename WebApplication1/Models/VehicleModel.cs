using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class VehicleModel
    {
        [Key, Required]
        public int idVehicle { get; set; }
        [Required]
        public string marcaAutomovil { get; set; }
        [Required]
        public string modeloAutomovil { get; set; }
        [Required]
        public int añoAutomovil { get; set; }
        [Required]
        public int kilometrosAutomovil { get; set; }
        [Required]
        public int precioAutomovil { get; set; }
    }
}
