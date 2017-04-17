using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthWind.DTO
{
    public class ProductDTO
    {
        [Key]
        public int UrunID { get; set; }

        [Required]
        [StringLength(40)]
        public string UrunAdi { get; set; }

        public int? TedarikciID { get; set; }

        public int? KategoriID { get; set; }

        [StringLength(20)]
        public string BirimdekiMiktar { get; set; }

        [Column(TypeName = "money")]
        public decimal? Fiyat { get; set; }

        public short? Stok { get; set; }

        public short? YeniSatis { get; set; }

        public short? EnAzYenidenSatisMikatari { get; set; }

        public bool Sonlandi { get; set; }
    }
}
