using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Domain.Models
{
    public class Goal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid ClientId { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        public string Detials { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DateCreated { get; set; }
        [ForeignKey("ClientId")]
        public Client Client { get; set; }
    }
}
