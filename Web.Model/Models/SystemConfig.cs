using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Model.Models
{
    [Table("SystemConfigs")]
    public class SystemConfig
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        public string Code { get; set; }
        [MaxLength(250)]
        public string ValueString { get; set; }
        public int? ValueInt { get; set; }


    }
}
