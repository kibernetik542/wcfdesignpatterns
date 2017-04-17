using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthWind.DTO
{
    public class SupplierDTO
    {
        [Key]
        public int TedarikciID { get; set; }

        [Required]
        [StringLength(40)]
        public string SirketAdi { get; set; }

        [StringLength(30)]
        public string MusteriAdi { get; set; }

        [StringLength(30)]
        public string MusteriUnvani { get; set; }

        [StringLength(60)]
        public string Adres { get; set; }

        [StringLength(15)]
        public string Sehir { get; set; }

        [StringLength(15)]
        public string Bolge { get; set; }

        [StringLength(10)]
        public string PostaKodu { get; set; }

        [StringLength(15)]
        public string Ulke { get; set; }

        [StringLength(24)]
        public string Telefon { get; set; }

        [StringLength(24)]
        public string Faks { get; set; }

        [Column(TypeName = "ntext")]
        public string WebSayfasi { get; set; }
    }
}
