using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDClientes.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(12)]
        [Display(Name ="Clave del cliente")]
        public string Clave { get; set; }

        [Required]
        [MaxLength(250)]
        [Display(Name = "Razon Social")]
        public string RazonSocial { get; set; }

        [Required]
        public bool Estado { get; set; }

        [Required]
        [MaxLength(10)]
        [Display(Name = "Telefono")]
        public string Telefono { get; set; }
    }
}
