using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class UserModel
    {
        [Key, Required]
        public int idUser { get; set; }
        [Required]
        public string nombreUsuario { get; set; }
        [Required]
        public string passwordUsuario { get; set; }
    }
}
