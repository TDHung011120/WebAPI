using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.Model.Models
{
    [Table("OderDetails")]
    public class OderDetail
    {
        [Key]
        public int OderID { get; set; }

        [Key]
        public int ProductID { get; set; }

        [Required]
        public int Quantity { get; set; } //số lượng

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }

        [ForeignKey("OderID")]
        public virtual Oder Oder { get; set; }
    }
}