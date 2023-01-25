using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWProvincias_Kuttel.Models
{
    [Table("provincia")]
    public class Provincia
    {
        [Key]
        public int IdProvincia { get; set; }

        [Required]
        [Column(TypeName="varchar(50)")]
        public string Nombre { get; set; }

        public List<Ciudad> Ciudad { get; set; }
    }
}
