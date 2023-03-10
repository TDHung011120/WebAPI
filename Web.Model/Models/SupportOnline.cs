using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Model.Models
{
    [Table("SupportOnlines")]
   public class SupportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [MaxLength(250)]
        public string Name { get; set; }
        [MaxLength(250)]
        public string Department { get; set; }
        [MaxLength(250)]
        public string Skype { get; set; }
        [MaxLength(250)]
        public string  Mobile { get; set; }
        [MaxLength(250)]
        public string  Email { get; set; }
        [MaxLength(250)]
        public string  FaceBook { get; set; }
        
        public bool  Status { get; set; }

    }
}
