using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar")]
        [MaxLength(250)]
        [Required]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        public string Description { get; set; }
        [MaxLength(500)]
        public string URL { get; set; }
        [Column(TypeName = "nvarchar")]
        public int? DisplayOder { get; set; }
        [Required]
        public int GroupID { get; set; }
        [Column(TypeName = "nvarchar")]
        public string Target { get; set; }
        [Required]
        public bool Status { get; set; }
        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroups { get; set; }
    }
}