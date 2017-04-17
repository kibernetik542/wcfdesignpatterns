using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthWind.DTO
{
    public class CategoryDTO
    {
        [Key]
        public int KategoriID { get; set; }

        [Required]
        [StringLength(15)]
        public string KategoriAdi { get; set; }

        [Column(TypeName = "ntext")]
        public string Tanimi { get; set; }

        [Column(TypeName = "image")]
        public byte[] Resim { get; set; }
    }
}
