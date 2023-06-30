using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sondagemSP.Models
{
    [Table("usuario")]
    public class Usuario : IdentityUser
    {
        [Key]
        [Column("id")]
        public int ID { get; set; }

        [Required]
        [Column("login")]
        public string? Login { get; set; }

        [Required]
        [Column("password_user")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
