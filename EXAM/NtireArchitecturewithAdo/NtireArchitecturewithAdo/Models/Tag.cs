using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NtireArchitecturewithAdo.Models
{
    [Table("Tags")]
    public class Tag

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TageId { get; set; }
        public int BankId { get; set; }
        public int CustomerId { get; set; }
        public decimal Balance { get; set; }

    }
}
