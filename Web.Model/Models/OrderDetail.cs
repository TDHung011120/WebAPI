using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.Model.Models
{
    [Table("OderDetails")]
    public class OrderDetail
    {
        [Key]
        [Column(Order = 1)]
        public int OderID { get; set; }

        [Key]
        [Column(Order = 2)]
        public int ProductID { get; set; }

        public int Quantity { get; set; } //số lượng

        [ForeignKey("OderID")]
        public virtual Order Oder { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }

        
    }
}